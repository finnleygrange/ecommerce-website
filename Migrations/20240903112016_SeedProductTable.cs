using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ECommerceWebsite.Migrations
{
    /// <inheritdoc />
    public partial class SeedProductTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Name", "Price", "Quantity" },
                values: new object[,]
                {
                    { 1, "A high-performance laptop with 16GB RAM and 512GB SSD.", "Laptop", 999.99m, 10 },
                    { 2, "A latest model smartphone with a 6.5-inch display and 128GB storage.", "Smartphone", 699.99m, 25 },
                    { 3, "Noise-cancelling wireless headphones with up to 20 hours of battery life.", "Wireless Headphones", 149.99m, 50 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
