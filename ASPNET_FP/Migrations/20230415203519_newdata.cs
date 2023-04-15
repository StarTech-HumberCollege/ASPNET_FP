using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ASPNET_FP.Migrations
{
    /// <inheritdoc />
    public partial class newdata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Notification",
                table: "Messages",
                newName: "MessageString");

            //migrationBuilder.RenameColumn(
            //    name: "NoteID",
            //    table: "Messages",
            //    newName: "MessageID");

            migrationBuilder.CreateTable(
                name: "Notifications",
                columns: table => new
                {
                    NoteId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReceiverId = table.Column<int>(type: "int", nullable: false),
                    SenderId = table.Column<int>(type: "int", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NotificationString = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notifications", x => x.NoteId);
                });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "AcctId", "CreationTime", "Email", "Gender", "LastLoginTime", "Name", "Password", "Phone" },
                values: new object[,]
                {
                    { 1001, new DateTime(2023, 4, 15, 16, 35, 19, 526, DateTimeKind.Local).AddTicks(864), "beltranalvaro08@gmail.com", "Male", new DateTime(2023, 4, 15, 16, 35, 19, 526, DateTimeKind.Local).AddTicks(898), "Alvaro Beltran", "alvaro1234", 123456789L },
                    { 1002, new DateTime(2023, 4, 15, 16, 35, 19, 526, DateTimeKind.Local).AddTicks(900), "tuyichen90@gmail.com", "Female", new DateTime(2023, 4, 15, 16, 35, 19, 526, DateTimeKind.Local).AddTicks(902), "Tuyi Chen", "tuyi1234", 123456789L },
                    { 1003, new DateTime(2023, 4, 15, 16, 35, 19, 526, DateTimeKind.Local).AddTicks(904), "katya.menesesr@gmail.com", "Female", new DateTime(2023, 4, 15, 16, 35, 19, 526, DateTimeKind.Local).AddTicks(906), "Katya Meneses", "katya1234", 123456789L },
                    { 1004, new DateTime(2023, 4, 15, 16, 35, 19, 526, DateTimeKind.Local).AddTicks(957), "antonvinokurov101@gmail.com", "Male", new DateTime(2023, 4, 15, 16, 35, 19, 526, DateTimeKind.Local).AddTicks(959), "Anton Vinokurov", "anton1234", 123456789L }
                });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "ListingId",
                keyValue: 1,
                column: "ListingTime",
                value: new DateTime(2023, 4, 15, 16, 35, 19, 526, DateTimeKind.Local).AddTicks(1172));

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "ListingId",
                keyValue: 2,
                column: "ListingTime",
                value: new DateTime(2023, 4, 15, 16, 35, 19, 526, DateTimeKind.Local).AddTicks(1177));

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "ListingId",
                keyValue: 3,
                column: "ListingTime",
                value: new DateTime(2023, 4, 15, 16, 35, 19, 526, DateTimeKind.Local).AddTicks(1180));

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "ListingId",
                keyValue: 4,
                column: "ListingTime",
                value: new DateTime(2023, 4, 15, 16, 35, 19, 526, DateTimeKind.Local).AddTicks(1182));

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "ListingId",
                keyValue: 5,
                column: "ListingTime",
                value: new DateTime(2023, 4, 15, 16, 35, 19, 526, DateTimeKind.Local).AddTicks(1185));

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "ListingId",
                keyValue: 6,
                column: "ListingTime",
                value: new DateTime(2023, 4, 15, 16, 35, 19, 526, DateTimeKind.Local).AddTicks(1187));

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "ListingId",
                keyValue: 7,
                column: "ListingTime",
                value: new DateTime(2023, 4, 15, 16, 35, 19, 526, DateTimeKind.Local).AddTicks(1189));

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "ListingId",
                keyValue: 8,
                column: "ListingTime",
                value: new DateTime(2023, 4, 15, 16, 35, 19, 526, DateTimeKind.Local).AddTicks(1191));

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "ListingId",
                keyValue: 9,
                column: "ListingTime",
                value: new DateTime(2023, 4, 15, 16, 35, 19, 526, DateTimeKind.Local).AddTicks(1194));

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "MessageID", "CreationTime", "MessageString", "ReceiverID", "SenderID" },
                values: new object[,]
                {
                    { 2001, new DateTime(2023, 4, 15, 16, 35, 19, 526, DateTimeKind.Local).AddTicks(1110), "Hi Alvaro! I was referred to you by Anton, told me you’re looking to rent your... ", 1001, 1002 },
                    { 2002, new DateTime(2023, 4, 15, 16, 35, 19, 526, DateTimeKind.Local).AddTicks(1114), "Hey man, i have someone interested in your apartment, she will contact you. ", 1001, 1004 }
                });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "NoteId", "CreationTime", "NotificationString", "ReceiverId", "SenderId" },
                values: new object[,]
                {
                    { 1001, new DateTime(2023, 4, 15, 16, 35, 19, 526, DateTimeKind.Local).AddTicks(1131), "Tuyi sent you a friend request", 1001, 1002 },
                    { 1002, new DateTime(2023, 4, 15, 16, 35, 19, 526, DateTimeKind.Local).AddTicks(1134), "Katya published a new listing", 1001, 1003 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Notifications");

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "AcctId",
                keyValue: 1001);

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "AcctId",
                keyValue: 1002);

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "AcctId",
                keyValue: 1003);

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "AcctId",
                keyValue: 1004);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "MessageID",
                keyValue: 2001);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "MessageID",
                keyValue: 2002);

            migrationBuilder.RenameColumn(
                name: "MessageString",
                table: "Messages",
                newName: "Notification");

            migrationBuilder.RenameColumn(
                name: "MessageID",
                table: "Messages",
                newName: "NoteID");

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "ListingId",
                keyValue: 1,
                column: "ListingTime",
                value: new DateTime(2023, 4, 15, 1, 49, 24, 342, DateTimeKind.Local).AddTicks(1041));

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "ListingId",
                keyValue: 2,
                column: "ListingTime",
                value: new DateTime(2023, 4, 15, 1, 49, 24, 342, DateTimeKind.Local).AddTicks(1073));

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "ListingId",
                keyValue: 3,
                column: "ListingTime",
                value: new DateTime(2023, 4, 15, 1, 49, 24, 342, DateTimeKind.Local).AddTicks(1076));

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "ListingId",
                keyValue: 4,
                column: "ListingTime",
                value: new DateTime(2023, 4, 15, 1, 49, 24, 342, DateTimeKind.Local).AddTicks(1078));

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "ListingId",
                keyValue: 5,
                column: "ListingTime",
                value: new DateTime(2023, 4, 15, 1, 49, 24, 342, DateTimeKind.Local).AddTicks(1081));

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "ListingId",
                keyValue: 6,
                column: "ListingTime",
                value: new DateTime(2023, 4, 15, 1, 49, 24, 342, DateTimeKind.Local).AddTicks(1083));

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "ListingId",
                keyValue: 7,
                column: "ListingTime",
                value: new DateTime(2023, 4, 15, 1, 49, 24, 342, DateTimeKind.Local).AddTicks(1085));

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "ListingId",
                keyValue: 8,
                column: "ListingTime",
                value: new DateTime(2023, 4, 15, 1, 49, 24, 342, DateTimeKind.Local).AddTicks(1087));

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "ListingId",
                keyValue: 9,
                column: "ListingTime",
                value: new DateTime(2023, 4, 15, 1, 49, 24, 342, DateTimeKind.Local).AddTicks(1089));
        }
    }
}
