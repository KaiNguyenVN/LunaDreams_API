using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using LunaDreams_API.Models;

namespace LunaDreams_API.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions options)
            : base(options) 
        { }
        
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<MenuItem> MenuItems { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<OrderHeader> OrderHeaders { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<MenuItem>().HasData(new MenuItem
            {
                Id = 1,
                Name = "Vietnamese Thick Noodle Soup",
                Description = "A hearty noodle soup with thick, chewy rice or tapioca noodles, often served with shrimp, crab, or pork in a savoury broth.",
                Image = "https://phase2foodimages.blob.core.windows.net/lunarestaurant/banh-canh.jpg",
                Price = 8.50,
                Category = "Main Dish",
                SpecialTag = "Traditional"
            }, new MenuItem
            {
                Id = 2,
                Name = "Bun Cha",
                Description = "Grilled pork patties and slices of pork belly served over rice noodles with fresh herbs and a tangy dipping sauce.",
                Image = "https://phase2foodimages.blob.core.windows.net/lunarestaurant/bun-cha.jpg",
                Price = 9.00,
                Category = "Main Dish",
                SpecialTag = "Popular"
            }, new MenuItem
            {
                Id = 3,
                Name = "Pho",
                Description = "A fragrant noodle soup made with beef or chicken, rice noodles, and a rich broth, garnished with herbs, lime, and bean sprouts.",
                Image = "https://phase2foodimages.blob.core.windows.net/lunarestaurant/pho.jpg",
                Price = 10.00,
                Category = "Main Dish",
                SpecialTag = "Iconic"
            }, new MenuItem
            {
                Id = 4,
                Name = "Banh Mi",
                Description = "A Vietnamese sandwich made with a French baguette, filled with meats such as pork, chicken, or pâté, and topped with pickled vegetables and fresh herbs.",
                Image = "https://phase2foodimages.blob.core.windows.net/lunarestaurant/banh-mi.jpg",
                Price = 7.00,
                Category = "Main Dish",
                SpecialTag = "Fusion"
            }, new MenuItem
            {
                Id = 5,
                Name = "Broken Rice",
                Description = "Broken rice served with grilled pork, pickled vegetables, and a fried egg, often accompanied by a side of fish sauce.",
                Image = "https://phase2foodimages.blob.core.windows.net/lunarestaurant/com-tam.jpg",
                Price = 8.00,
                Category = "Main Dish",
                SpecialTag = "Classic"
            }, new MenuItem
            {
                Id = 6,
                Name = "Vietnamese Spring Rolls",
                Description = "Fresh spring rolls filled with shrimp, herbs, pork, rice noodles, and lettuce, often served with a hoisin-peanut dipping sauce.",
                Image = "https://phase2foodimages.blob.core.windows.net/lunarestaurant/nem-ran.jpg",
                Price = 6.00,
                Category = "Appetizer",
                SpecialTag = "Light"
            }, new MenuItem
            {
                Id = 7,
                Name = "Vietnamese Pancakes",
                Description = "Savory crepes made from rice flour, turmeric, and coconut milk, stuffed with pork, shrimp, bean sprouts, and green onions, usually served with lettuce and herbs.",
                Image = "https://phase2foodimages.blob.core.windows.net/lunarestaurant/che-thai.jpg",
                Price = 7.50,
                Category = "Appetizer",
                SpecialTag = "Crispy"
            }, new MenuItem
            {
                Id = 8,
                Name = "Hu Tieu",
                Description = "A noodle soup with a clear, flavorful broth, typically made with pork or seafood, and served with a variety of toppings such as bean sprouts, herbs, and lime.",
                Image = "https://phase2foodimages.blob.core.windows.net/lunarestaurant/hu-tieu.jpg",
                Price = 8.50,
                Category = "Main Dish",
                SpecialTag = "Savory"
            }, new MenuItem

            {
                Id = 9,
                Name = "Quang-style Noodles",
                Description = "A specialty noodle dish from Quang Nam province, featuring wide rice noodles in a flavorful broth with a mix of proteins (often shrimp, pork, or chicken), and garnished with peanuts, herbs, and crispy rice crackers.",
                Image = "https://phase2foodimages.blob.core.windows.net/lunarestaurant/mi-quang.jpg",
                Price = 9.00,
                Category = "Main Dish",
                SpecialTag = "Regional"
            }, new MenuItem
            {
                Id = 10,
                Name = "Thai-style Dessert",
                Description = "A Thai-inspired Vietnamese dessert with a mix of colorful fruits, jelly, and coconut milk, often served chilled.",
                Image = "https://phase2foodimages.blob.core.windows.net/lunarestaurant/che-thai.jpg",
                Price = 4.50,
                Category = "Dessert",
                SpecialTag = "Fruity"
            }, new MenuItem
            {
                Id = 11,
                Name = "Flan",
                Description = "A Vietnamese-style caramel custard dessert, smooth and creamy, often topped with a caramel sauce.",
                Image = "https://phase2foodimages.blob.core.windows.net/lunarestaurant/flan.jpg",
                Price = 3.50,
                Category = "Dessert",
                SpecialTag = "Creamy"
            }
            );
        }

    }
}
