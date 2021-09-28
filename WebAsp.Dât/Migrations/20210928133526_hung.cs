using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class hung : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "V",
                table: "AppConfigs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "c88efed0-a885-48bc-ba6f-c4c423e81fc2");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a7ef6195-42bf-4a03-aaa9-cb892ebaefb0", "AQAAAAEAACcQAAAAEKs/5HfXPoQYyJPuRqGqFDXa/Zf0Q4IoYVbcUu8sqao8PC+kVtYAePdBSe0qwEj2/w==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 9, 28, 20, 35, 24, 63, DateTimeKind.Local).AddTicks(8694));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "V",
                table: "AppConfigs");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "c397bee6-9d0c-4c33-8aef-5cc6c1eadb3f");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "70bf2bb6-2b22-409f-9702-f5cdcf3072cf", "AQAAAAEAACcQAAAAELuImMrfZ7SifxHndBgBOeHhWtvgGW+UV8AwIOL7g3+RKJvJKct8J4GBjL8FRU4Bzg==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 9, 24, 18, 15, 58, 607, DateTimeKind.Local).AddTicks(9963));
        }
    }
}
