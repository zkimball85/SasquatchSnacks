using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SasquatchSnacks.Migrations
{
    /// <inheritdoc />
    public partial class AddressCodeReview : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RentalBooking_Customers_CustomerId",
                table: "RentalBooking");

            migrationBuilder.DropForeignKey(
                name: "FK_RentalBooking_RentalEquipment_RentalEquipmentId",
                table: "RentalBooking");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RentalBooking",
                table: "RentalBooking");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ConsumableProduct",
                table: "ConsumableProduct");

            migrationBuilder.RenameTable(
                name: "RentalBooking",
                newName: "RentalBookings");

            migrationBuilder.RenameTable(
                name: "ConsumableProduct",
                newName: "ConsumableProducts");

            migrationBuilder.RenameIndex(
                name: "IX_RentalBooking_RentalEquipmentId",
                table: "RentalBookings",
                newName: "IX_RentalBookings_RentalEquipmentId");

            migrationBuilder.RenameIndex(
                name: "IX_RentalBooking_CustomerId",
                table: "RentalBookings",
                newName: "IX_RentalBookings_CustomerId");

            migrationBuilder.AlterColumn<string>(
                name: "OperatingHours",
                table: "VendingLocations",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RentalBookings",
                table: "RentalBookings",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ConsumableProducts",
                table: "ConsumableProducts",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_RentalBookings_Customers_CustomerId",
                table: "RentalBookings",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RentalBookings_RentalEquipment_RentalEquipmentId",
                table: "RentalBookings",
                column: "RentalEquipmentId",
                principalTable: "RentalEquipment",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RentalBookings_Customers_CustomerId",
                table: "RentalBookings");

            migrationBuilder.DropForeignKey(
                name: "FK_RentalBookings_RentalEquipment_RentalEquipmentId",
                table: "RentalBookings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RentalBookings",
                table: "RentalBookings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ConsumableProducts",
                table: "ConsumableProducts");

            migrationBuilder.RenameTable(
                name: "RentalBookings",
                newName: "RentalBooking");

            migrationBuilder.RenameTable(
                name: "ConsumableProducts",
                newName: "ConsumableProduct");

            migrationBuilder.RenameIndex(
                name: "IX_RentalBookings_RentalEquipmentId",
                table: "RentalBooking",
                newName: "IX_RentalBooking_RentalEquipmentId");

            migrationBuilder.RenameIndex(
                name: "IX_RentalBookings_CustomerId",
                table: "RentalBooking",
                newName: "IX_RentalBooking_CustomerId");

            migrationBuilder.AlterColumn<string>(
                name: "OperatingHours",
                table: "VendingLocations",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_RentalBooking",
                table: "RentalBooking",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ConsumableProduct",
                table: "ConsumableProduct",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_RentalBooking_Customers_CustomerId",
                table: "RentalBooking",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RentalBooking_RentalEquipment_RentalEquipmentId",
                table: "RentalBooking",
                column: "RentalEquipmentId",
                principalTable: "RentalEquipment",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
