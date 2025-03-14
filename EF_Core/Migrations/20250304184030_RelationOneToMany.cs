using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_Core.Migrations
{
    /// <inheritdoc />
    public partial class RelationOneToMany : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_SubscriptionPeriod_MemberID",
                table: "SubscriptionPeriod",
                column: "MemberID");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_MemberID",
                table: "Payments",
                column: "MemberID");

            migrationBuilder.CreateIndex(
                name: "IX_BeltTests_BeltRankID",
                table: "BeltTests",
                column: "BeltRankID");

            migrationBuilder.CreateIndex(
                name: "IX_BeltTests_InstructorID",
                table: "BeltTests",
                column: "InstructorID");

            migrationBuilder.CreateIndex(
                name: "IX_BeltTests_MemberID",
                table: "BeltTests",
                column: "MemberID");

            migrationBuilder.AddForeignKey(
                name: "FK_BeltTests_BeltRanks_BeltRankID",
                table: "BeltTests",
                column: "BeltRankID",
                principalTable: "BeltRanks",
                principalColumn: "BeltRankID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BeltTests_Instructors_InstructorID",
                table: "BeltTests",
                column: "InstructorID",
                principalTable: "Instructors",
                principalColumn: "PersonID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BeltTests_Members_MemberID",
                table: "BeltTests",
                column: "MemberID",
                principalTable: "Members",
                principalColumn: "PersonID",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_Members_MemberID",
                table: "Payments",
                column: "MemberID",
                principalTable: "Members",
                principalColumn: "PersonID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SubscriptionPeriod_Members_MemberID",
                table: "SubscriptionPeriod",
                column: "MemberID",
                principalTable: "Members",
                principalColumn: "PersonID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BeltTests_BeltRanks_BeltRankID",
                table: "BeltTests");

            migrationBuilder.DropForeignKey(
                name: "FK_BeltTests_Instructors_InstructorID",
                table: "BeltTests");

            migrationBuilder.DropForeignKey(
                name: "FK_BeltTests_Members_MemberID",
                table: "BeltTests");

            migrationBuilder.DropForeignKey(
                name: "FK_Payments_Members_MemberID",
                table: "Payments");

            migrationBuilder.DropForeignKey(
                name: "FK_SubscriptionPeriod_Members_MemberID",
                table: "SubscriptionPeriod");

            migrationBuilder.DropIndex(
                name: "IX_SubscriptionPeriod_MemberID",
                table: "SubscriptionPeriod");

            migrationBuilder.DropIndex(
                name: "IX_Payments_MemberID",
                table: "Payments");

            migrationBuilder.DropIndex(
                name: "IX_BeltTests_BeltRankID",
                table: "BeltTests");

            migrationBuilder.DropIndex(
                name: "IX_BeltTests_InstructorID",
                table: "BeltTests");

            migrationBuilder.DropIndex(
                name: "IX_BeltTests_MemberID",
                table: "BeltTests");
        }
    }
}
