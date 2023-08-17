using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ocit.Exezrcies.Emds.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedNewDbSets : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Addresse_IncomingDocuments_IncomingDocumentId",
                table: "Addresse");

            migrationBuilder.DropForeignKey(
                name: "FK_CameFrom_IncomingDocuments_IncomingDocumentId",
                table: "CameFrom");

            migrationBuilder.DropForeignKey(
                name: "FK_CounterParty_IncomingDocuments_IncomingDocumentId",
                table: "CounterParty");

            migrationBuilder.DropForeignKey(
                name: "FK_DeliveryMethod_IncomingDocuments_IncomingDocumentId",
                table: "DeliveryMethod");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DeliveryMethod",
                table: "DeliveryMethod");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CounterParty",
                table: "CounterParty");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CameFrom",
                table: "CameFrom");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Addresse",
                table: "Addresse");

            migrationBuilder.RenameTable(
                name: "DeliveryMethod",
                newName: "DeliveryMethods");

            migrationBuilder.RenameTable(
                name: "CounterParty",
                newName: "CounterParties");

            migrationBuilder.RenameTable(
                name: "CameFrom",
                newName: "CameFroms");

            migrationBuilder.RenameTable(
                name: "Addresse",
                newName: "Addresses");

            migrationBuilder.RenameIndex(
                name: "IX_DeliveryMethod_IncomingDocumentId",
                table: "DeliveryMethods",
                newName: "IX_DeliveryMethods_IncomingDocumentId");

            migrationBuilder.RenameIndex(
                name: "IX_CounterParty_IncomingDocumentId",
                table: "CounterParties",
                newName: "IX_CounterParties_IncomingDocumentId");

            migrationBuilder.RenameIndex(
                name: "IX_CameFrom_IncomingDocumentId",
                table: "CameFroms",
                newName: "IX_CameFroms_IncomingDocumentId");

            migrationBuilder.RenameIndex(
                name: "IX_Addresse_IncomingDocumentId",
                table: "Addresses",
                newName: "IX_Addresses_IncomingDocumentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DeliveryMethods",
                table: "DeliveryMethods",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CounterParties",
                table: "CounterParties",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CameFroms",
                table: "CameFroms",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Addresses",
                table: "Addresses",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "BasicDocuments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 17, 12, 40, 22, 559, DateTimeKind.Utc).AddTicks(5420));

            migrationBuilder.UpdateData(
                table: "BasicDocuments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 17, 12, 40, 22, 559, DateTimeKind.Utc).AddTicks(5438));

            migrationBuilder.UpdateData(
                table: "BasicDocuments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 17, 12, 40, 22, 559, DateTimeKind.Utc).AddTicks(5493));

            migrationBuilder.UpdateData(
                table: "BasicDocuments",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 17, 12, 40, 22, 559, DateTimeKind.Utc).AddTicks(5505));

            migrationBuilder.UpdateData(
                table: "BasicDocuments",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 17, 12, 40, 22, 559, DateTimeKind.Utc).AddTicks(5516));

            migrationBuilder.InsertData(
                table: "BasicDocuments",
                columns: new[] { "Id", "CreatedDate", "Discriminator", "DocumentKind", "DocumentNumber", "Name", "Subject" },
                values: new object[] { 3, new DateTime(2023, 8, 17, 12, 40, 22, 559, DateTimeKind.Utc).AddTicks(5443), new Guid("d27975a9-4b07-4883-b236-f4361245975b"), new[] { 0 }, "Number3", "Name3", "subject3" });

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

            migrationBuilder.AddForeignKey(
                name: "FK_Addresses_IncomingDocuments_IncomingDocumentId",
                table: "Addresses",
                column: "IncomingDocumentId",
                principalTable: "IncomingDocuments",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CameFroms_IncomingDocuments_IncomingDocumentId",
                table: "CameFroms",
                column: "IncomingDocumentId",
                principalTable: "IncomingDocuments",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CounterParties_IncomingDocuments_IncomingDocumentId",
                table: "CounterParties",
                column: "IncomingDocumentId",
                principalTable: "IncomingDocuments",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DeliveryMethods_IncomingDocuments_IncomingDocumentId",
                table: "DeliveryMethods",
                column: "IncomingDocumentId",
                principalTable: "IncomingDocuments",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Addresses_IncomingDocuments_IncomingDocumentId",
                table: "Addresses");

            migrationBuilder.DropForeignKey(
                name: "FK_CameFroms_IncomingDocuments_IncomingDocumentId",
                table: "CameFroms");

            migrationBuilder.DropForeignKey(
                name: "FK_CounterParties_IncomingDocuments_IncomingDocumentId",
                table: "CounterParties");

            migrationBuilder.DropForeignKey(
                name: "FK_DeliveryMethods_IncomingDocuments_IncomingDocumentId",
                table: "DeliveryMethods");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DeliveryMethods",
                table: "DeliveryMethods");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CounterParties",
                table: "CounterParties");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CameFroms",
                table: "CameFroms");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Addresses",
                table: "Addresses");

            migrationBuilder.DeleteData(
                table: "BasicDocuments",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.RenameTable(
                name: "DeliveryMethods",
                newName: "DeliveryMethod");

            migrationBuilder.RenameTable(
                name: "CounterParties",
                newName: "CounterParty");

            migrationBuilder.RenameTable(
                name: "CameFroms",
                newName: "CameFrom");

            migrationBuilder.RenameTable(
                name: "Addresses",
                newName: "Addresse");

            migrationBuilder.RenameIndex(
                name: "IX_DeliveryMethods_IncomingDocumentId",
                table: "DeliveryMethod",
                newName: "IX_DeliveryMethod_IncomingDocumentId");

            migrationBuilder.RenameIndex(
                name: "IX_CounterParties_IncomingDocumentId",
                table: "CounterParty",
                newName: "IX_CounterParty_IncomingDocumentId");

            migrationBuilder.RenameIndex(
                name: "IX_CameFroms_IncomingDocumentId",
                table: "CameFrom",
                newName: "IX_CameFrom_IncomingDocumentId");

            migrationBuilder.RenameIndex(
                name: "IX_Addresses_IncomingDocumentId",
                table: "Addresse",
                newName: "IX_Addresse_IncomingDocumentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DeliveryMethod",
                table: "DeliveryMethod",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CounterParty",
                table: "CounterParty",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CameFrom",
                table: "CameFrom",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Addresse",
                table: "Addresse",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "BasicDocuments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 17, 12, 7, 7, 984, DateTimeKind.Utc).AddTicks(984));

            migrationBuilder.UpdateData(
                table: "BasicDocuments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 17, 12, 7, 7, 984, DateTimeKind.Utc).AddTicks(1001));

            migrationBuilder.UpdateData(
                table: "BasicDocuments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 17, 12, 7, 7, 984, DateTimeKind.Utc).AddTicks(1067));

            migrationBuilder.UpdateData(
                table: "BasicDocuments",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 17, 12, 7, 7, 984, DateTimeKind.Utc).AddTicks(1076));

            migrationBuilder.UpdateData(
                table: "BasicDocuments",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 17, 12, 7, 7, 984, DateTimeKind.Utc).AddTicks(1085));

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

            migrationBuilder.AddForeignKey(
                name: "FK_Addresse_IncomingDocuments_IncomingDocumentId",
                table: "Addresse",
                column: "IncomingDocumentId",
                principalTable: "IncomingDocuments",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CameFrom_IncomingDocuments_IncomingDocumentId",
                table: "CameFrom",
                column: "IncomingDocumentId",
                principalTable: "IncomingDocuments",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CounterParty_IncomingDocuments_IncomingDocumentId",
                table: "CounterParty",
                column: "IncomingDocumentId",
                principalTable: "IncomingDocuments",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DeliveryMethod_IncomingDocuments_IncomingDocumentId",
                table: "DeliveryMethod",
                column: "IncomingDocumentId",
                principalTable: "IncomingDocuments",
                principalColumn: "Id");
        }
    }
}
