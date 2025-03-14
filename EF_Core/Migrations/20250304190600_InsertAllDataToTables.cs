using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EF_Core.Migrations
{
    /// <inheritdoc />
    public partial class InsertAllDataToTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "BeltRanks",
                columns: new[] { "BeltRankID", "RankName", "TestFees" },
                values: new object[,]
                {
                    { 1, "White Belt", 50.0000m },
                    { 2, "Yellow Belt", 60.0000m },
                    { 3, "Orange Belt", 70.0000m },
                    { 4, "Green Belt", 80.0000m },
                    { 5, "Blue Belt", 90.0000m },
                    { 6, "Purple Belt", 100.0000m },
                    { 7, "Brown Belt", 110.0000m },
                    { 8, "Black Belt (1nd Dan)", 120.0000m },
                    { 9, "Black Belt (2nd Dan)", 130.0000m },
                    { 10, "Black Belt (3nd Dan)", 140.0000m },
                    { 11, "Black Belt (4nd Dan)", 150.0000m },
                    { 12, "Black Belt (5nd Dan)", 160.0000m },
                    { 13, "Black Belt (6nd Dan)", 170.0000m },
                    { 14, "Black Belt (7nd Dan)", 180.0000m },
                    { 15, "Black Belt (8nd Dan)", 190.0000m },
                    { 16, "Black Belt (9nd Dan)", 200.0000m },
                    { 17, "Black Belt (10nd Dan)", 210.0000m }
                });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "PersonID", "Address", "DateOfBirth", "Email", "Gender", "Name", "Phone" },
                values: new object[,]
                {
                    { 1, "1Street", new DateTime(2005, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, (byte)1, "Salem", "77829388" },
                    { 3, "Cinma Street", new DateTime(2004, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ali @gmail.com", (byte)1, "Ali Ahemd", "77829388" },
                    { 4, "1Street", new DateTime(2005, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, (byte)1, " Ahmed", "77823388" },
                    { 6, "2Street", new DateTime(2005, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, (byte)1, "Saleh", "71829388" },
                    { 7, "1Street", new DateTime(2005, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, (byte)2, "Salwa", "77829388" },
                    { 9, "1Street", new DateTime(2005, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, (byte)1, "Mohammed", "77829388" },
                    { 21, "1Street", new DateTime(2005, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, (byte)1, "Waled", "77829388" },
                    { 25, "1Street", new DateTime(2005, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, (byte)1, "Hadi", "77829388" },
                    { 33, "1Street", new DateTime(2005, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, (byte)1, "Fahed Ahmed", "77829388" },
                    { 34, "1Street", new DateTime(2005, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, (byte)1, "Faisle", "77829388" },
                    { 36, "1Street", new DateTime(2005, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, (byte)1, "Omar Ali", "77829388" },
                    { 37, "1Street", new DateTime(2005, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, (byte)1, "Mohand Faisle", "77829388" },
                    { 38, "1Street", new DateTime(2005, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, (byte)1, "Khaled Waled", "77829388" },
                    { 39, "1Street", new DateTime(2005, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, (byte)0, "Zahrh Ahmed", "77829388" },
                    { 40, "1Street", new DateTime(2005, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, (byte)1, "Faozy", "77829388" },
                    { 41, "1Street", new DateTime(2005, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, (byte)0, "Rima Waled", "77829388" },
                    { 42, "1Street", new DateTime(2005, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, (byte)1, "ALi Faozy", "77829388" }
                });

            migrationBuilder.InsertData(
                table: "Instructors",
                columns: new[] { "PersonID", "Qualification" },
                values: new object[,]
                {
                    { 6, "Belt" },
                    { 7, "Belt" },
                    { 9, "Win Teakwindo" },
                    { 34, "Belt Champions" },
                    { 40, "Belt Win" },
                    { 41, null }
                });

            migrationBuilder.InsertData(
                table: "Members",
                columns: new[] { "PersonID", "EmergencyContactInfo", "IsActive", "LastBeltRankID" },
                values: new object[,]
                {
                    { 3, "343434", true, 4 },
                    { 4, "343434", false, 1 },
                    { 21, "343434", true, 3 },
                    { 33, "343434", true, 5 },
                    { 36, "343434", true, 1 },
                    { 37, "343434", true, 1 },
                    { 38, "343434", true, 10 },
                    { 39, "343434", true, 4 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "PersonID", "IsActive", "Password", "Permission", "UserName" },
                values: new object[,]
                {
                    { 1, true, "1111", (byte)1, "s123" },
                    { 25, true, "1111", (byte)1, "s123" },
                    { 42, true, "1111", (byte)1, "s123" }
                });

            migrationBuilder.InsertData(
                table: "MemberInstructors",
                columns: new[] { "MemberInstructorID", "AssignDate", "InstructorID", "MemberID" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 3 },
                    { 7, new DateTime(2024, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, 3 },
                    { 8, new DateTime(2024, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 34, 33 },
                    { 9, new DateTime(2024, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, 21 },
                    { 10, new DateTime(2024, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, 33 },
                    { 11, new DateTime(2024, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, 3 },
                    { 12, new DateTime(2024, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 41, 39 },
                    { 13, new DateTime(2024, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 40, 39 },
                    { 14, new DateTime(2024, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 40, 38 },
                    { 15, new DateTime(2024, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 34, 38 },
                    { 16, new DateTime(2024, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 40, 36 },
                    { 18, new DateTime(2024, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 41, 38 }
                });

            migrationBuilder.InsertData(
                table: "Payments",
                columns: new[] { "PaymentID", "Amount", "Date", "MemberID", "PaymentFor" },
                values: new object[,]
                {
                    { 1, 20.00m, new DateTime(2024, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, (byte)1 },
                    { 6, 60.00m, new DateTime(2024, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 21, (byte)1 },
                    { 14, 50.00m, new DateTime(2024, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, (byte)1 },
                    { 17, 60.00m, new DateTime(2024, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, (byte)2 },
                    { 18, 60.00m, new DateTime(2024, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, (byte)2 },
                    { 19, 60.00m, new DateTime(2024, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, (byte)2 },
                    { 20, 60.00m, new DateTime(2024, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, (byte)2 },
                    { 21, 70.00m, new DateTime(2024, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, (byte)2 },
                    { 22, 200.00m, new DateTime(2024, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 39, (byte)1 },
                    { 23, 400.00m, new DateTime(2024, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 38, (byte)1 },
                    { 24, 300.00m, new DateTime(2024, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 36, (byte)1 },
                    { 25, 70.00m, new DateTime(2024, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 21, (byte)1 },
                    { 26, 60.00m, new DateTime(2024, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 21, (byte)1 },
                    { 27, 60.00m, new DateTime(2024, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 21, (byte)1 },
                    { 32, 110.00m, new DateTime(2024, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 38, (byte)2 },
                    { 33, 120.00m, new DateTime(2024, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 38, (byte)2 },
                    { 34, 130.00m, new DateTime(2024, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 38, (byte)2 },
                    { 35, 50.00m, new DateTime(2024, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 39, (byte)2 },
                    { 36, 50.00m, new DateTime(2024, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 39, (byte)2 },
                    { 37, 60.00m, new DateTime(2024, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 39, (byte)2 },
                    { 38, 70.00m, new DateTime(2024, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 39, (byte)2 }
                });

            migrationBuilder.InsertData(
                table: "SubscriptionPeriod",
                columns: new[] { "SubscriptionPeriodID", "EndDate", "Fees", "IsActive", "IssueReason", "MemberID", "Paid", "PaymentID", "StartDate", "SubscrpitonDays" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 50.0000m, false, (byte)1, 3, true, 1, new DateTime(2024, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), (byte)30 },
                    { 9, new DateTime(2024, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 60.0000m, false, (byte)1, 21, true, 6, new DateTime(2024, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), (byte)38 },
                    { 14, new DateTime(2024, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 70.0000m, false, (byte)1, 21, true, 25, new DateTime(2024, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), (byte)30 },
                    { 19, new DateTime(2024, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 50.0000m, false, (byte)1, 3, true, 14, new DateTime(2024, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), (byte)30 },
                    { 25, new DateTime(2024, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 200.0000m, false, (byte)1, 39, true, 22, new DateTime(2024, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), (byte)48 },
                    { 26, new DateTime(2024, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 400.0000m, false, (byte)1, 38, true, 23, new DateTime(2024, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), (byte)30 },
                    { 28, new DateTime(2024, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 300.0000m, false, (byte)1, 36, true, 24, new DateTime(2024, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), (byte)30 },
                    { 29, new DateTime(2024, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 300.0000m, false, (byte)1, 37, true, null, new DateTime(2024, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), (byte)30 },
                    { 30, new DateTime(2024, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 60.0000m, false, (byte)2, 21, true, 26, new DateTime(2024, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), (byte)38 },
                    { 31, new DateTime(2024, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 60.0000m, false, (byte)2, 21, true, 27, new DateTime(2024, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), (byte)38 },
                    { 33, new DateTime(2025, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 35.0000m, true, (byte)2, 21, true, 27, new DateTime(2025, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), (byte)34 }
                });

            migrationBuilder.InsertData(
                table: "BeltTests",
                columns: new[] { "BeltTestID", "BeltRankID", "Date", "InstructorID", "MemberID", "PaymentID", "Result" },
                values: new object[,]
                {
                    { 2, 1, new DateTime(2024, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, 3, 17, true },
                    { 3, 2, new DateTime(2024, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, 3, 18, false },
                    { 4, 2, new DateTime(2024, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, 3, 19, false },
                    { 5, 2, new DateTime(2024, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, 3, 20, true },
                    { 6, 6, new DateTime(2024, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, 3, 21, true },
                    { 11, 7, new DateTime(2024, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 40, 38, 32, true },
                    { 12, 8, new DateTime(2024, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 41, 38, 33, true },
                    { 13, 9, new DateTime(2024, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 40, 38, 34, true },
                    { 14, 1, new DateTime(2024, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 40, 39, 35, false },
                    { 15, 1, new DateTime(2024, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 41, 39, 36, true },
                    { 16, 2, new DateTime(2024, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 41, 39, 37, true },
                    { 17, 2, new DateTime(2024, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 40, 39, 38, true }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BeltRanks",
                keyColumn: "BeltRankID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "BeltRanks",
                keyColumn: "BeltRankID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "BeltRanks",
                keyColumn: "BeltRankID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "BeltRanks",
                keyColumn: "BeltRankID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "BeltRanks",
                keyColumn: "BeltRankID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "BeltRanks",
                keyColumn: "BeltRankID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "BeltRanks",
                keyColumn: "BeltRankID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "BeltTests",
                keyColumn: "BeltTestID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "BeltTests",
                keyColumn: "BeltTestID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "BeltTests",
                keyColumn: "BeltTestID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "BeltTests",
                keyColumn: "BeltTestID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "BeltTests",
                keyColumn: "BeltTestID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "BeltTests",
                keyColumn: "BeltTestID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "BeltTests",
                keyColumn: "BeltTestID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "BeltTests",
                keyColumn: "BeltTestID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "BeltTests",
                keyColumn: "BeltTestID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "BeltTests",
                keyColumn: "BeltTestID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "BeltTests",
                keyColumn: "BeltTestID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "BeltTests",
                keyColumn: "BeltTestID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "MemberInstructors",
                keyColumn: "MemberInstructorID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "MemberInstructors",
                keyColumn: "MemberInstructorID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "MemberInstructors",
                keyColumn: "MemberInstructorID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "MemberInstructors",
                keyColumn: "MemberInstructorID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "MemberInstructors",
                keyColumn: "MemberInstructorID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "MemberInstructors",
                keyColumn: "MemberInstructorID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "MemberInstructors",
                keyColumn: "MemberInstructorID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "MemberInstructors",
                keyColumn: "MemberInstructorID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "MemberInstructors",
                keyColumn: "MemberInstructorID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "MemberInstructors",
                keyColumn: "MemberInstructorID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "MemberInstructors",
                keyColumn: "MemberInstructorID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "MemberInstructors",
                keyColumn: "MemberInstructorID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Members",
                keyColumn: "PersonID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "PaymentID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "PaymentID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "PaymentID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "PaymentID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "PaymentID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "PaymentID",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "PaymentID",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "PaymentID",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "PaymentID",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "SubscriptionPeriod",
                keyColumn: "SubscriptionPeriodID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SubscriptionPeriod",
                keyColumn: "SubscriptionPeriodID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "SubscriptionPeriod",
                keyColumn: "SubscriptionPeriodID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "SubscriptionPeriod",
                keyColumn: "SubscriptionPeriodID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "SubscriptionPeriod",
                keyColumn: "SubscriptionPeriodID",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "SubscriptionPeriod",
                keyColumn: "SubscriptionPeriodID",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "SubscriptionPeriod",
                keyColumn: "SubscriptionPeriodID",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "SubscriptionPeriod",
                keyColumn: "SubscriptionPeriodID",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "SubscriptionPeriod",
                keyColumn: "SubscriptionPeriodID",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "SubscriptionPeriod",
                keyColumn: "SubscriptionPeriodID",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "SubscriptionPeriod",
                keyColumn: "SubscriptionPeriodID",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "PersonID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "PersonID",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "PersonID",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "BeltRanks",
                keyColumn: "BeltRankID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "BeltRanks",
                keyColumn: "BeltRankID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "BeltRanks",
                keyColumn: "BeltRankID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "BeltRanks",
                keyColumn: "BeltRankID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "BeltRanks",
                keyColumn: "BeltRankID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Instructors",
                keyColumn: "PersonID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Instructors",
                keyColumn: "PersonID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Instructors",
                keyColumn: "PersonID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Instructors",
                keyColumn: "PersonID",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Instructors",
                keyColumn: "PersonID",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Instructors",
                keyColumn: "PersonID",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Members",
                keyColumn: "PersonID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Members",
                keyColumn: "PersonID",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Members",
                keyColumn: "PersonID",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Members",
                keyColumn: "PersonID",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "PaymentID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "PaymentID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "PaymentID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "PaymentID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "PaymentID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "PaymentID",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "PaymentID",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "PaymentID",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "PaymentID",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "PaymentID",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "PaymentID",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "PaymentID",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonID",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonID",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "BeltRanks",
                keyColumn: "BeltRankID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "BeltRanks",
                keyColumn: "BeltRankID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "BeltRanks",
                keyColumn: "BeltRankID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Members",
                keyColumn: "PersonID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Members",
                keyColumn: "PersonID",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Members",
                keyColumn: "PersonID",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonID",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonID",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonID",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonID",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonID",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonID",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "BeltRanks",
                keyColumn: "BeltRankID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "BeltRanks",
                keyColumn: "BeltRankID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonID",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonID",
                keyValue: 39);
        }
    }
}
