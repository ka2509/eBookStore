using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assignment.Migrations
{
    public partial class Modify : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Publishers_PublisherPub_id",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_Books_PublisherPub_id",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "PublisherPub_id",
                table: "Books");

            migrationBuilder.CreateIndex(
                name: "IX_Books_Pub_id",
                table: "Books",
                column: "Pub_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Publishers_Pub_id",
                table: "Books",
                column: "Pub_id",
                principalTable: "Publishers",
                principalColumn: "Pub_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Publishers_Pub_id",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_Books_Pub_id",
                table: "Books");

            migrationBuilder.AddColumn<int>(
                name: "PublisherPub_id",
                table: "Books",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Books_PublisherPub_id",
                table: "Books",
                column: "PublisherPub_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Publishers_PublisherPub_id",
                table: "Books",
                column: "PublisherPub_id",
                principalTable: "Publishers",
                principalColumn: "Pub_id");
        }
    }
}
