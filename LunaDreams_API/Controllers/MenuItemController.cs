using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using LunaDreams_API.Data;
using System.Net;
using LunaDreams_API.Models;
using LunaDreams_API.Models.DTO;
using LunaDreams_API.Services;
using LunaDreams_API.Utility;
using System.Runtime.InteropServices;
using static System.Net.Mime.MediaTypeNames;

namespace LunaDreams_API.Controllers
{
    [Route("api/MenuItem")]
    [ApiController]
    public class MenuItemController : ControllerBase
    {
        private readonly ApplicationDbContext _db;
        private readonly IBlobService _blobService;
        private ApiResponse _response;
        public MenuItemController(ApplicationDbContext db, IBlobService blobService)
        {
            _db = db;
            _blobService = blobService;
            _response = new ApiResponse();
        }

        [HttpGet]
        public async Task<IActionResult> GetMenuItems()
        {
            _response.Result = _db.MenuItems;
            _response.StatusCode = HttpStatusCode.OK;
            return Ok(_response);

        }

        [HttpGet("{id:int}", Name = "GetMenuItem")]
        public async Task<IActionResult> GetIndividualItem(int id)
        {
            if (id == 0)
            {
                _response.StatusCode = HttpStatusCode.BadRequest;
                _response.IsSuccess = false;
                return BadRequest(_response);
            }
            MenuItem menuItem = _db.MenuItems.FirstOrDefault(x => x.Id == id);
            if (menuItem == null)
            {
                _response.StatusCode = HttpStatusCode.NotFound;
                _response.IsSuccess = false;
                return NotFound(_response);
            }
            _response.Result = menuItem;
            _response.StatusCode = HttpStatusCode.OK;
            return Ok(_response);

        }

        [HttpPost]
        public async Task<ActionResult<ApiResponse>> CreateMenuItem([FromForm] MenuItemCreate menuItemCreate)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (menuItemCreate.File == null || menuItemCreate.File.Length == 0)
                    {
                        _response.StatusCode = HttpStatusCode.BadRequest;
                        _response.IsSuccess = false;
                        return BadRequest();
                    }

                    string fileName = $"{Guid.NewGuid()}{Path.GetExtension(menuItemCreate.File.FileName)}";
                    //string fileName = "";
                    MenuItem menuItemToCreate = new()
                    {
                        Name = menuItemCreate.Name,
                        Price = menuItemCreate.Price,
                        Category = menuItemCreate.Category,
                        SpecialTag = menuItemCreate.SpecialTag,
                        Description = menuItemCreate.Description,
                        Image = await _blobService.UploadBlob(fileName, SD.SD_Storage_Container, menuItemCreate.File)
                    };
                    _db.MenuItems.Add(menuItemToCreate);
                    _db.SaveChanges();
                    _response.Result = menuItemToCreate;
                    _response.StatusCode=HttpStatusCode.Created;
                    return CreatedAtRoute("GetMenuItem", new {id = menuItemToCreate.Id}, _response);
                }
                else
                {
                    _response.IsSuccess = false;
                }


            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string>() { ex.ToString() };
            }
            return _response;
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult<ApiResponse>> UpdateMenuItem(int id, [FromForm] MenuItemUpdate menuItemUpdate)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (menuItemUpdate == null || id != menuItemUpdate.Id)
                    {
                        _response.StatusCode = HttpStatusCode.BadRequest;
                        _response.IsSuccess = false;
                        return BadRequest();
                    }

                    MenuItem menuItemFromDb = await _db.MenuItems.FindAsync(id);

                    if(menuItemFromDb == null)
                    {
                        _response.StatusCode = HttpStatusCode.BadRequest;
                        _response.IsSuccess = false;
                        return BadRequest();
                    }

                    menuItemFromDb.Name = menuItemUpdate.Name;
                    menuItemFromDb.Price = menuItemUpdate.Price;
                    menuItemFromDb.Category = menuItemUpdate.Category;  
                    menuItemFromDb.SpecialTag = menuItemUpdate.SpecialTag;
                    menuItemFromDb.Description = menuItemUpdate.Description;

                    if(menuItemUpdate.File != null && menuItemUpdate.File.Length > 0)
                    {
                        await _blobService.DeleteBlob(menuItemFromDb.Image.Split('/').Last(), SD.SD_Storage_Container);
                        string fileName = $"{Guid.NewGuid()}{Path.GetExtension(menuItemUpdate.File.FileName)}";
                        menuItemFromDb.Image = await _blobService.UploadBlob(fileName, SD.SD_Storage_Container, menuItemUpdate.File);
                    }
                    _db.MenuItems.Update(menuItemFromDb);
                    _db.SaveChanges();
                    _response.StatusCode = HttpStatusCode.NoContent;
                    return Ok(_response);
                }
                else
                {
                    _response.IsSuccess = false;
                }


            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string>() { ex.ToString() };
            }
            return _response;
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult<ApiResponse>> UpdateMenuItem(int id)
        {
            try
            {
               
                if (id == 0)
                {
                    _response.StatusCode = HttpStatusCode.BadRequest;
                    _response.IsSuccess = false;
                    return BadRequest();
                }

                MenuItem menuItemFromDb = await _db.MenuItems.FindAsync(id);

                if (menuItemFromDb == null)
                {
                    _response.StatusCode = HttpStatusCode.BadRequest;
                    _response.IsSuccess = false;
                    return BadRequest();
                }
                await _blobService.DeleteBlob(menuItemFromDb.Image.Split('/').Last(), SD.SD_Storage_Container);
                Thread.Sleep(2000);

                _db.MenuItems.Remove(menuItemFromDb);
                _db.SaveChanges();
                _response.StatusCode = HttpStatusCode.NoContent;
                return Ok(_response);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string>() { ex.ToString() };
            }
            return _response;
        }
    }
}
