using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Ocit.Exezrcies.Emds.Data.Migrations
{
    /// <inheritdoc />
    public partial class EntityDocumentChanged : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BasicDocumentDocumentKind");

            migrationBuilder.DropTable(
                name: "DocumentKind");

            migrationBuilder.RenameColumn(
                name: "DocumentKindIds",
                table: "BasicDocuments",
                newName: "DocumentKind");

            migrationBuilder.UpdateData(
                table: "BasicDocuments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "DocumentKind" },
                values: new object[] { new DateTime(2023, 8, 17, 12, 7, 7, 984, DateTimeKind.Utc).AddTicks(984), new[] { 0 } });

            migrationBuilder.UpdateData(
                table: "BasicDocuments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "DocumentKind" },
                values: new object[] { new DateTime(2023, 8, 17, 12, 7, 7, 984, DateTimeKind.Utc).AddTicks(1001), new[] { 0 } });

            migrationBuilder.UpdateData(
                table: "BasicDocuments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "DocumentKind" },
                values: new object[] { new DateTime(2023, 8, 17, 12, 7, 7, 984, DateTimeKind.Utc).AddTicks(1067), new[] { 1 } });

            migrationBuilder.UpdateData(
                table: "BasicDocuments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "DocumentKind" },
                values: new object[] { new DateTime(2023, 8, 17, 12, 7, 7, 984, DateTimeKind.Utc).AddTicks(1076), new[] { 1 } });

            migrationBuilder.UpdateData(
                table: "BasicDocuments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "DocumentKind" },
                values: new object[] { new DateTime(2023, 8, 17, 12, 7, 7, 984, DateTimeKind.Utc).AddTicks(1085), new[] { 1 } });

            migrationBuilder.UpdateData(
                table: "IncomingDocuments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AddresseIds", "CameFromIds", "CounterPartyIds", "DeliveryMethodIds" },
                values: new object[] { new List<int> { 1 }, new List<int> { 1 }, new List<int> { 1 }, new List<int> { 1 } });

            migrationBuilder.UpdateData(
                table: "IncomingDocuments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AddresseIds", "CameFromIds", "CounterPartyIds", "DeliveryMethodIds" },
                values: new object[] { new List<int> { 2 }, new List<int> { 2, 1 }, new List<int> { 1, 1 }, new List<int> { 1, 2 } });

            migrationBuilder.UpdateData(
                table: "IncomingDocuments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AddresseIds", "CameFromIds", "CounterPartyIds", "DeliveryMethodIds" },
                values: new object[] { new List<int> { 2 }, new List<int> { 3, 2 }, new List<int> { 1, 3 }, new List<int> { 3 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DocumentKind",
                table: "BasicDocuments",
                newName: "DocumentKindIds");

            migrationBuilder.CreateTable(
                name: "DocumentKind",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocumentKind", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BasicDocumentDocumentKind",
                columns: table => new
                {
                    BasicDocumentsId = table.Column<int>(type: "integer", nullable: false),
                    DocumentKindId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BasicDocumentDocumentKind", x => new { x.BasicDocumentsId, x.DocumentKindId });
                    table.ForeignKey(
                        name: "FK_BasicDocumentDocumentKind_BasicDocuments_BasicDocumentsId",
                        column: x => x.BasicDocumentsId,
                        principalTable: "BasicDocuments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BasicDocumentDocumentKind_DocumentKind_DocumentKindId",
                        column: x => x.DocumentKindId,
                        principalTable: "DocumentKind",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "BasicDocuments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "DocumentKindIds" },
                values: new object[] { new DateTime(2023, 8, 17, 11, 40, 46, 985, DateTimeKind.Utc).AddTicks(6488), new List<int> { 1 } });

            migrationBuilder.UpdateData(
                table: "BasicDocuments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "DocumentKindIds" },
                values: new object[] { new DateTime(2023, 8, 17, 11, 40, 46, 985, DateTimeKind.Utc).AddTicks(6518), new List<int> { 1 } });

            migrationBuilder.UpdateData(
                table: "BasicDocuments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "DocumentKindIds" },
                values: new object[] { new DateTime(2023, 8, 17, 11, 40, 46, 985, DateTimeKind.Utc).AddTicks(6554), new List<int> { 2 } });

            migrationBuilder.UpdateData(
                table: "BasicDocuments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "DocumentKindIds" },
                values: new object[] { new DateTime(2023, 8, 17, 11, 40, 46, 985, DateTimeKind.Utc).AddTicks(6563), new List<int> { 2 } });

            migrationBuilder.UpdateData(
                table: "BasicDocuments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "DocumentKindIds" },
                values: new object[] { new DateTime(2023, 8, 17, 11, 40, 46, 985, DateTimeKind.Utc).AddTicks(6572), new List<int> { 2 } });

            migrationBuilder.InsertData(
                table: "DocumentKind",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Basic document" },
                    { 2, "Incoming document" }
                });

            migrationBuilder.UpdateData(
                table: "IncomingDocuments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AddresseIds", "CameFromIds", "CounterPartyIds", "DeliveryMethodIds" },
                values: new object[] { new List<int> { 1 }, new List<int> { 1 }, new List<int> { 1 }, new List<int> { 1 } });

            migrationBuilder.UpdateData(
                table: "IncomingDocuments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AddresseIds", "CameFromIds", "CounterPartyIds", "DeliveryMethodIds" },
                values: new object[] { new List<int> { 2 }, new List<int> { 2, 1 }, new List<int> { 1, 1 }, new List<int> { 1, 2 } });

            migrationBuilder.UpdateData(
                table: "IncomingDocuments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AddresseIds", "CameFromIds", "CounterPartyIds", "DeliveryMethodIds" },
                values: new object[] { new List<int> { 2 }, new List<int> { 3, 2 }, new List<int> { 1, 3 }, new List<int> { 3 } });

            migrationBuilder.CreateIndex(
                name: "IX_BasicDocumentDocumentKind_DocumentKindId",
                table: "BasicDocumentDocumentKind",
                column: "DocumentKindId");
        }
    }
}
