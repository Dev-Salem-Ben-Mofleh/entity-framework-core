using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_Core.Migrations
{
    /// <inheritdoc />
    public partial class AddEnum : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "PaymentID",
                keyValue: 1,
                column: "PaymentFor",
                value: (byte)0);

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "PaymentID",
                keyValue: 6,
                column: "PaymentFor",
                value: (byte)0);

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "PaymentID",
                keyValue: 14,
                column: "PaymentFor",
                value: (byte)0);

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "PaymentID",
                keyValue: 17,
                column: "PaymentFor",
                value: (byte)1);

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "PaymentID",
                keyValue: 18,
                column: "PaymentFor",
                value: (byte)1);

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "PaymentID",
                keyValue: 19,
                column: "PaymentFor",
                value: (byte)1);

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "PaymentID",
                keyValue: 20,
                column: "PaymentFor",
                value: (byte)1);

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "PaymentID",
                keyValue: 21,
                column: "PaymentFor",
                value: (byte)1);

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "PaymentID",
                keyValue: 22,
                column: "PaymentFor",
                value: (byte)0);

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "PaymentID",
                keyValue: 23,
                column: "PaymentFor",
                value: (byte)0);

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "PaymentID",
                keyValue: 24,
                column: "PaymentFor",
                value: (byte)0);

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "PaymentID",
                keyValue: 25,
                column: "PaymentFor",
                value: (byte)0);

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "PaymentID",
                keyValue: 26,
                column: "PaymentFor",
                value: (byte)0);

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "PaymentID",
                keyValue: 27,
                column: "PaymentFor",
                value: (byte)0);

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "PaymentID",
                keyValue: 32,
                column: "PaymentFor",
                value: (byte)1);

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "PaymentID",
                keyValue: 33,
                column: "PaymentFor",
                value: (byte)1);

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "PaymentID",
                keyValue: 34,
                column: "PaymentFor",
                value: (byte)1);

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "PaymentID",
                keyValue: 35,
                column: "PaymentFor",
                value: (byte)1);

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "PaymentID",
                keyValue: 36,
                column: "PaymentFor",
                value: (byte)1);

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "PaymentID",
                keyValue: 37,
                column: "PaymentFor",
                value: (byte)1);

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "PaymentID",
                keyValue: 38,
                column: "PaymentFor",
                value: (byte)1);

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonID",
                keyValue: 3,
                columns: new[] { "Address", "Email" },
                values: new object[] { "1Street", null });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonID",
                keyValue: 4,
                column: "Phone",
                value: "77829388");

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonID",
                keyValue: 6,
                columns: new[] { "Address", "Phone" },
                values: new object[] { "1Street", "77829388" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "PaymentID",
                keyValue: 1,
                column: "PaymentFor",
                value: (byte)1);

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "PaymentID",
                keyValue: 6,
                column: "PaymentFor",
                value: (byte)1);

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "PaymentID",
                keyValue: 14,
                column: "PaymentFor",
                value: (byte)1);

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "PaymentID",
                keyValue: 17,
                column: "PaymentFor",
                value: (byte)2);

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "PaymentID",
                keyValue: 18,
                column: "PaymentFor",
                value: (byte)2);

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "PaymentID",
                keyValue: 19,
                column: "PaymentFor",
                value: (byte)2);

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "PaymentID",
                keyValue: 20,
                column: "PaymentFor",
                value: (byte)2);

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "PaymentID",
                keyValue: 21,
                column: "PaymentFor",
                value: (byte)2);

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "PaymentID",
                keyValue: 22,
                column: "PaymentFor",
                value: (byte)1);

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "PaymentID",
                keyValue: 23,
                column: "PaymentFor",
                value: (byte)1);

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "PaymentID",
                keyValue: 24,
                column: "PaymentFor",
                value: (byte)1);

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "PaymentID",
                keyValue: 25,
                column: "PaymentFor",
                value: (byte)1);

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "PaymentID",
                keyValue: 26,
                column: "PaymentFor",
                value: (byte)1);

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "PaymentID",
                keyValue: 27,
                column: "PaymentFor",
                value: (byte)1);

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "PaymentID",
                keyValue: 32,
                column: "PaymentFor",
                value: (byte)2);

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "PaymentID",
                keyValue: 33,
                column: "PaymentFor",
                value: (byte)2);

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "PaymentID",
                keyValue: 34,
                column: "PaymentFor",
                value: (byte)2);

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "PaymentID",
                keyValue: 35,
                column: "PaymentFor",
                value: (byte)2);

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "PaymentID",
                keyValue: 36,
                column: "PaymentFor",
                value: (byte)2);

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "PaymentID",
                keyValue: 37,
                column: "PaymentFor",
                value: (byte)2);

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "PaymentID",
                keyValue: 38,
                column: "PaymentFor",
                value: (byte)2);

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonID",
                keyValue: 3,
                columns: new[] { "Address", "Email" },
                values: new object[] { "Cinma Street", "Ali @gmail.com" });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonID",
                keyValue: 4,
                column: "Phone",
                value: "77823388");

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonID",
                keyValue: 6,
                columns: new[] { "Address", "Phone" },
                values: new object[] { "2Street", "71829388" });
        }
    }
}
