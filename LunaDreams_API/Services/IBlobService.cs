namespace LunaDreams_API.Services
{
    public interface IBlobService
    {
        Task<string> GetBlob(string blobName, string containerName); //filename
        Task<bool> DeleteBlob(string blobName, string containerName); //filename
        Task<string> UploadBlob(string blobName, string containerName, IFormFile file); //filename

    }
}
