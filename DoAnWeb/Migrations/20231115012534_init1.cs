using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DoAnWeb.Migrations
{
    public partial class init1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductReviews_Invoices_InvoiceId",
                table: "ProductReviews");

            migrationBuilder.DropIndex(
                name: "IX_ProductReviews_InvoiceId",
                table: "ProductReviews");

            migrationBuilder.DropColumn(
                name: "InvoiceId",
                table: "ProductReviews");

            migrationBuilder.AddColumn<string>(
                name: "linkDowLoadEbook",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "price_new",
                table: "Combos",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "price_old",
                table: "Combos",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "linkDowLoadEbook",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "price_new",
                table: "Combos");

            migrationBuilder.DropColumn(
                name: "price_old",
                table: "Combos");

            migrationBuilder.AddColumn<int>(
                name: "InvoiceId",
                table: "ProductReviews",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ProductReviews_InvoiceId",
                table: "ProductReviews",
                column: "InvoiceId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductReviews_Invoices_InvoiceId",
                table: "ProductReviews",
                column: "InvoiceId",
                principalTable: "Invoices",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
