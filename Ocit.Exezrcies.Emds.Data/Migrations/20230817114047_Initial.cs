using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Ocit.Exezrcies.Emds.Data.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BasicDocuments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Discriminator = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    DocumentKindIds = table.Column<List<int>>(type: "integer[]", nullable: false),
                    Subject = table.Column<string>(type: "text", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DocumentNumber = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BasicDocuments", x => x.Id);
                });

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
                name: "IncomingDocuments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false),
                    AddresseIds = table.Column<List<int>>(type: "integer[]", nullable: false),
                    CounterPartyIds = table.Column<List<int>>(type: "integer[]", nullable: false),
                    DeliveryMethodIds = table.Column<List<int>>(type: "integer[]", nullable: false),
                    CameFromIds = table.Column<List<int>>(type: "integer[]", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IncomingDocuments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IncomingDocuments_BasicDocuments_Id",
                        column: x => x.Id,
                        principalTable: "BasicDocuments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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

            migrationBuilder.CreateTable(
                name: "Addresse",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FullName = table.Column<string>(type: "text", nullable: false),
                    IncomingDocumentId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresse", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Addresse_IncomingDocuments_IncomingDocumentId",
                        column: x => x.IncomingDocumentId,
                        principalTable: "IncomingDocuments",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CameFrom",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    IncomingDocumentId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CameFrom", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CameFrom_IncomingDocuments_IncomingDocumentId",
                        column: x => x.IncomingDocumentId,
                        principalTable: "IncomingDocuments",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CounterParty",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    IncomingDocumentId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CounterParty", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CounterParty_IncomingDocuments_IncomingDocumentId",
                        column: x => x.IncomingDocumentId,
                        principalTable: "IncomingDocuments",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "DeliveryMethod",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    IncomingDocumentId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeliveryMethod", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DeliveryMethod_IncomingDocuments_IncomingDocumentId",
                        column: x => x.IncomingDocumentId,
                        principalTable: "IncomingDocuments",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Addresse",
                columns: new[] { "Id", "FullName", "IncomingDocumentId" },
                values: new object[,]
                {
                    { 1, "FIO", null },
                    { 2, "FIO2", null }
                });

            migrationBuilder.InsertData(
                table: "BasicDocuments",
                columns: new[] { "Id", "CreatedDate", "Discriminator", "DocumentKindIds", "DocumentNumber", "Name", "Subject" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 8, 17, 11, 40, 46, 985, DateTimeKind.Utc).AddTicks(6488), new Guid("d27975a9-4b07-4883-b236-f4361245975b"), new List<int> { 1 }, "Number1", "Name", "subject" },
                    { 2, new DateTime(2023, 8, 17, 11, 40, 46, 985, DateTimeKind.Utc).AddTicks(6518), new Guid("e4321c60-166c-4479-9eb7-b71768832fb3"), new List<int> { 1 }, "Number2", "Name2", "subject2" },
                    { 4, new DateTime(2023, 8, 17, 11, 40, 46, 985, DateTimeKind.Utc).AddTicks(6554), new Guid("d27975a9-4b07-4883-b236-f4361245975b"), new List<int> { 2 }, "docNumber1", "incomingName1", "incomingSubject1" },
                    { 5, new DateTime(2023, 8, 17, 11, 40, 46, 985, DateTimeKind.Utc).AddTicks(6563), new Guid("e4321c60-166c-4479-9eb7-b71768832fb3"), new List<int> { 2 }, "docNumber2", "incomingName2", "incomingSubject2" },
                    { 6, new DateTime(2023, 8, 17, 11, 40, 46, 985, DateTimeKind.Utc).AddTicks(6572), new Guid("d27975a9-4b07-4883-b236-f4361245975b"), new List<int> { 2 }, "docNumber3", "incomingName3", "incomingSubject3" }
                });

            migrationBuilder.InsertData(
                table: "CameFrom",
                columns: new[] { "Id", "IncomingDocumentId", "Name" },
                values: new object[,]
                {
                    { 1, null, "cameFrom1" },
                    { 2, null, "cameFrom2" },
                    { 3, null, "cameFrom3" }
                });

            migrationBuilder.InsertData(
                table: "CounterParty",
                columns: new[] { "Id", "IncomingDocumentId", "Name" },
                values: new object[,]
                {
                    { 1, null, "party1" },
                    { 2, null, "party2" },
                    { 3, null, "party3" }
                });

            migrationBuilder.InsertData(
                table: "DeliveryMethod",
                columns: new[] { "Id", "IncomingDocumentId", "Name" },
                values: new object[,]
                {
                    { 1, null, "EMAIL" },
                    { 2, null, "EDMS" },
                    { 3, null, "MAIL" }
                });

            migrationBuilder.InsertData(
                table: "DocumentKind",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Basic document" },
                    { 2, "Incoming document" }
                });

            migrationBuilder.InsertData(
                table: "IncomingDocuments",
                columns: new[] { "Id", "AddresseIds", "CameFromIds", "CounterPartyIds", "DeliveryMethodIds" },
                values: new object[,]
                {
                    { 4, new List<int> { 1 }, new List<int> { 1 }, new List<int> { 1 }, new List<int> { 1 } },
                    { 5, new List<int> { 2 }, new List<int> { 2, 1 }, new List<int> { 1, 1 }, new List<int> { 1, 2 } },
                    { 6, new List<int> { 2 }, new List<int> { 3, 2 }, new List<int> { 1, 3 }, new List<int> { 3 } }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Addresse_IncomingDocumentId",
                table: "Addresse",
                column: "IncomingDocumentId");

            migrationBuilder.CreateIndex(
                name: "IX_BasicDocumentDocumentKind_DocumentKindId",
                table: "BasicDocumentDocumentKind",
                column: "DocumentKindId");

            migrationBuilder.CreateIndex(
                name: "IX_CameFrom_IncomingDocumentId",
                table: "CameFrom",
                column: "IncomingDocumentId");

            migrationBuilder.CreateIndex(
                name: "IX_CounterParty_IncomingDocumentId",
                table: "CounterParty",
                column: "IncomingDocumentId");

            migrationBuilder.CreateIndex(
                name: "IX_DeliveryMethod_IncomingDocumentId",
                table: "DeliveryMethod",
                column: "IncomingDocumentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Addresse");

            migrationBuilder.DropTable(
                name: "BasicDocumentDocumentKind");

            migrationBuilder.DropTable(
                name: "CameFrom");

            migrationBuilder.DropTable(
                name: "CounterParty");

            migrationBuilder.DropTable(
                name: "DeliveryMethod");

            migrationBuilder.DropTable(
                name: "DocumentKind");

            migrationBuilder.DropTable(
                name: "IncomingDocuments");

            migrationBuilder.DropTable(
                name: "BasicDocuments");
        }
    }
}
