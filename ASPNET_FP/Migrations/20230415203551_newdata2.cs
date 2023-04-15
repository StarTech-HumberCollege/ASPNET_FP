using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASPNET_FP.Migrations
{
    /// <inheritdoc />
    public partial class newdata2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "AcctId",
                keyValue: 1001,
                columns: new[] { "CreationTime", "LastLoginTime" },
                values: new object[] { new DateTime(2023, 4, 15, 16, 35, 50, 991, DateTimeKind.Local).AddTicks(4303), new DateTime(2023, 4, 15, 16, 35, 50, 991, DateTimeKind.Local).AddTicks(4344) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "AcctId",
                keyValue: 1002,
                columns: new[] { "CreationTime", "LastLoginTime" },
                values: new object[] { new DateTime(2023, 4, 15, 16, 35, 50, 991, DateTimeKind.Local).AddTicks(4347), new DateTime(2023, 4, 15, 16, 35, 50, 991, DateTimeKind.Local).AddTicks(4349) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "AcctId",
                keyValue: 1003,
                columns: new[] { "CreationTime", "LastLoginTime" },
                values: new object[] { new DateTime(2023, 4, 15, 16, 35, 50, 991, DateTimeKind.Local).AddTicks(4397), new DateTime(2023, 4, 15, 16, 35, 50, 991, DateTimeKind.Local).AddTicks(4399) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "AcctId",
                keyValue: 1004,
                columns: new[] { "CreationTime", "LastLoginTime" },
                values: new object[] { new DateTime(2023, 4, 15, 16, 35, 50, 991, DateTimeKind.Local).AddTicks(4401), new DateTime(2023, 4, 15, 16, 35, 50, 991, DateTimeKind.Local).AddTicks(4403) });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "ListingId",
                keyValue: 1,
                column: "ListingTime",
                value: new DateTime(2023, 4, 15, 16, 35, 50, 991, DateTimeKind.Local).AddTicks(4717));

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "ListingId",
                keyValue: 2,
                column: "ListingTime",
                value: new DateTime(2023, 4, 15, 16, 35, 50, 991, DateTimeKind.Local).AddTicks(4723));

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "ListingId",
                keyValue: 3,
                column: "ListingTime",
                value: new DateTime(2023, 4, 15, 16, 35, 50, 991, DateTimeKind.Local).AddTicks(4727));

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "ListingId",
                keyValue: 4,
                column: "ListingTime",
                value: new DateTime(2023, 4, 15, 16, 35, 50, 991, DateTimeKind.Local).AddTicks(4729));

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "ListingId",
                keyValue: 5,
                column: "ListingTime",
                value: new DateTime(2023, 4, 15, 16, 35, 50, 991, DateTimeKind.Local).AddTicks(4732));

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "ListingId",
                keyValue: 6,
                column: "ListingTime",
                value: new DateTime(2023, 4, 15, 16, 35, 50, 991, DateTimeKind.Local).AddTicks(4734));

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "ListingId",
                keyValue: 7,
                column: "ListingTime",
                value: new DateTime(2023, 4, 15, 16, 35, 50, 991, DateTimeKind.Local).AddTicks(4737));

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "ListingId",
                keyValue: 8,
                column: "ListingTime",
                value: new DateTime(2023, 4, 15, 16, 35, 50, 991, DateTimeKind.Local).AddTicks(4739));

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "ListingId",
                keyValue: 9,
                column: "ListingTime",
                value: new DateTime(2023, 4, 15, 16, 35, 50, 991, DateTimeKind.Local).AddTicks(4742));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageID",
                keyValue: 2001,
                column: "CreationTime",
                value: new DateTime(2023, 4, 15, 16, 35, 50, 991, DateTimeKind.Local).AddTicks(4640));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageID",
                keyValue: 2002,
                column: "CreationTime",
                value: new DateTime(2023, 4, 15, 16, 35, 50, 991, DateTimeKind.Local).AddTicks(4644));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "NoteId",
                keyValue: 1001,
                column: "CreationTime",
                value: new DateTime(2023, 4, 15, 16, 35, 50, 991, DateTimeKind.Local).AddTicks(4662));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "NoteId",
                keyValue: 1002,
                column: "CreationTime",
                value: new DateTime(2023, 4, 15, 16, 35, 50, 991, DateTimeKind.Local).AddTicks(4666));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "AcctId",
                keyValue: 1001,
                columns: new[] { "CreationTime", "LastLoginTime" },
                values: new object[] { new DateTime(2023, 4, 15, 16, 35, 19, 526, DateTimeKind.Local).AddTicks(864), new DateTime(2023, 4, 15, 16, 35, 19, 526, DateTimeKind.Local).AddTicks(898) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "AcctId",
                keyValue: 1002,
                columns: new[] { "CreationTime", "LastLoginTime" },
                values: new object[] { new DateTime(2023, 4, 15, 16, 35, 19, 526, DateTimeKind.Local).AddTicks(900), new DateTime(2023, 4, 15, 16, 35, 19, 526, DateTimeKind.Local).AddTicks(902) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "AcctId",
                keyValue: 1003,
                columns: new[] { "CreationTime", "LastLoginTime" },
                values: new object[] { new DateTime(2023, 4, 15, 16, 35, 19, 526, DateTimeKind.Local).AddTicks(904), new DateTime(2023, 4, 15, 16, 35, 19, 526, DateTimeKind.Local).AddTicks(906) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "AcctId",
                keyValue: 1004,
                columns: new[] { "CreationTime", "LastLoginTime" },
                values: new object[] { new DateTime(2023, 4, 15, 16, 35, 19, 526, DateTimeKind.Local).AddTicks(957), new DateTime(2023, 4, 15, 16, 35, 19, 526, DateTimeKind.Local).AddTicks(959) });

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

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageID",
                keyValue: 2001,
                column: "CreationTime",
                value: new DateTime(2023, 4, 15, 16, 35, 19, 526, DateTimeKind.Local).AddTicks(1110));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageID",
                keyValue: 2002,
                column: "CreationTime",
                value: new DateTime(2023, 4, 15, 16, 35, 19, 526, DateTimeKind.Local).AddTicks(1114));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "NoteId",
                keyValue: 1001,
                column: "CreationTime",
                value: new DateTime(2023, 4, 15, 16, 35, 19, 526, DateTimeKind.Local).AddTicks(1131));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "NoteId",
                keyValue: 1002,
                column: "CreationTime",
                value: new DateTime(2023, 4, 15, 16, 35, 19, 526, DateTimeKind.Local).AddTicks(1134));
        }
    }
}
