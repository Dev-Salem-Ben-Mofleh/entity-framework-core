using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_Core.Migrations
{
    /// <inheritdoc />
    public partial class RelationOneToOne : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Members_LastBeltRankID",
                table: "Members",
                column: "LastBeltRankID");

            migrationBuilder.CreateIndex(
                name: "IX_BeltTests_PaymentID",
                table: "BeltTests",
                column: "PaymentID",
                unique: true,
                filter: "[PaymentID] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_BeltTests_Payments_PaymentID",
                table: "BeltTests",
                column: "PaymentID",
                principalTable: "Payments",
                principalColumn: "PaymentID");

            migrationBuilder.AddForeignKey(
                name: "FK_Members_BeltRanks_LastBeltRankID",
                table: "Members",
                column: "LastBeltRankID",
                principalTable: "BeltRanks",
                principalColumn: "BeltRankID",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BeltTests_Payments_PaymentID",
                table: "BeltTests");

            migrationBuilder.DropForeignKey(
                name: "FK_Members_BeltRanks_LastBeltRankID",
                table: "Members");

            migrationBuilder.DropIndex(
                name: "IX_Members_LastBeltRankID",
                table: "Members");

            migrationBuilder.DropIndex(
                name: "IX_BeltTests_PaymentID",
                table: "BeltTests");
        }
    }
}
