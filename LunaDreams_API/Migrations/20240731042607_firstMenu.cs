using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LunaDreams_API.Migrations
{
    /// <inheritdoc />
    public partial class firstMenu : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "MenuItems",
                columns: new[] { "Id", "Category", "Description", "Image", "Name", "Price", "SpecialTag" },
                values: new object[,]
                {
                    { 1, "Main Dish", "A hearty noodle soup with thick, chewy rice or tapioca noodles, often served with shrimp, crab, or pork in a savoury broth.", "https://phase2foodimages.blob.core.windows.net/lunarestaurant/banh-canh.jpg", "Vietnamese Thick Noodle Soup", 8.5, "Traditional" },
                    { 2, "Main Dish", "Grilled pork patties and slices of pork belly served over rice noodles with fresh herbs and a tangy dipping sauce.", "https://phase2foodimages.blob.core.windows.net/lunarestaurant/bun-cha.jpg", "Bun Cha", 9.0, "Popular" },
                    { 3, "Main Dish", "A fragrant noodle soup made with beef or chicken, rice noodles, and a rich broth, garnished with herbs, lime, and bean sprouts.", "https://phase2foodimages.blob.core.windows.net/lunarestaurant/pho.jpg", "Pho", 10.0, "Iconic" },
                    { 4, "Main Dish", "A Vietnamese sandwich made with a French baguette, filled with meats such as pork, chicken, or pâté, and topped with pickled vegetables and fresh herbs.", "https://phase2foodimages.blob.core.windows.net/lunarestaurant/banh-mi.jpg", "Banh Mi", 7.0, "Fusion" },
                    { 5, "Main Dish", "Broken rice served with grilled pork, pickled vegetables, and a fried egg, often accompanied by a side of fish sauce.", "https://phase2foodimages.blob.core.windows.net/lunarestaurant/com-tam.jpg", "Broken Rice", 8.0, "Classic" },
                    { 6, "Appetizer", "Fresh spring rolls filled with shrimp, herbs, pork, rice noodles, and lettuce, often served with a hoisin-peanut dipping sauce.", "https://phase2foodimages.blob.core.windows.net/lunarestaurant/nem-ran.jpg", "Vietnamese Spring Rolls", 6.0, "Light" },
                    { 7, "Appetizer", "Savory crepes made from rice flour, turmeric, and coconut milk, stuffed with pork, shrimp, bean sprouts, and green onions, usually served with lettuce and herbs.", "https://phase2foodimages.blob.core.windows.net/lunarestaurant/che-thai.jpg", "Vietnamese Pancakes", 7.5, "Crispy" },
                    { 8, "Main Dish", "A noodle soup with a clear, flavorful broth, typically made with pork or seafood, and served with a variety of toppings such as bean sprouts, herbs, and lime.", "https://phase2foodimages.blob.core.windows.net/lunarestaurant/hu-tieu.jpg", "Hu Tieu", 8.5, "Savory" },
                    { 9, "Main Dish", "A specialty noodle dish from Quang Nam province, featuring wide rice noodles in a flavorful broth with a mix of proteins (often shrimp, pork, or chicken), and garnished with peanuts, herbs, and crispy rice crackers.", "https://phase2foodimages.blob.core.windows.net/lunarestaurant/mi-quang.jpg", "Quang-style Noodles", 9.0, "Regional" },
                    { 10, "Dessert", "A Thai-inspired Vietnamese dessert with a mix of colorful fruits, jelly, and coconut milk, often served chilled.", "https://phase2foodimages.blob.core.windows.net/lunarestaurant/che-thai.jpg", "Thai-style Dessert", 4.5, "Fruity" },
                    { 11, "Dessert", "A Vietnamese-style caramel custard dessert, smooth and creamy, often topped with a caramel sauce.", "https://phase2foodimages.blob.core.windows.net/lunarestaurant/flan.jpg", "Flan", 3.5, "Creamy" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 11);
        }
    }
}
