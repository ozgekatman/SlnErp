using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SlnErp102.Data.Migrations
{
    public partial class addSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "tblCompanies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 43, 18, 59, DateTimeKind.Local).AddTicks(5989), new DateTime(2022, 1, 19, 19, 43, 18, 59, DateTimeKind.Local).AddTicks(5990) });

            migrationBuilder.UpdateData(
                table: "tblCompanies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 43, 18, 59, DateTimeKind.Local).AddTicks(5993), new DateTime(2022, 1, 19, 19, 43, 18, 59, DateTimeKind.Local).AddTicks(5994) });

            migrationBuilder.UpdateData(
                table: "tblCompanies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 43, 18, 59, DateTimeKind.Local).AddTicks(5995), new DateTime(2022, 1, 19, 19, 43, 18, 59, DateTimeKind.Local).AddTicks(5996) });

            migrationBuilder.UpdateData(
                table: "tblCompanyBranches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 43, 18, 59, DateTimeKind.Local).AddTicks(5739), new DateTime(2022, 1, 19, 19, 43, 18, 59, DateTimeKind.Local).AddTicks(5740) });

            migrationBuilder.UpdateData(
                table: "tblCompanyBranches",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 43, 18, 59, DateTimeKind.Local).AddTicks(5743), new DateTime(2022, 1, 19, 19, 43, 18, 59, DateTimeKind.Local).AddTicks(5743) });

            migrationBuilder.UpdateData(
                table: "tblCompanyBranches",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 43, 18, 59, DateTimeKind.Local).AddTicks(5745), new DateTime(2022, 1, 19, 19, 43, 18, 59, DateTimeKind.Local).AddTicks(5745) });

            migrationBuilder.UpdateData(
                table: "tblCompanyBranches",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 43, 18, 59, DateTimeKind.Local).AddTicks(5746), new DateTime(2022, 1, 19, 19, 43, 18, 59, DateTimeKind.Local).AddTicks(5747) });

            migrationBuilder.UpdateData(
                table: "tblCompanyBranches",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 43, 18, 59, DateTimeKind.Local).AddTicks(5748), new DateTime(2022, 1, 19, 19, 43, 18, 59, DateTimeKind.Local).AddTicks(5749) });

            migrationBuilder.UpdateData(
                table: "tblCompanyBranches",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 43, 18, 59, DateTimeKind.Local).AddTicks(5750), new DateTime(2022, 1, 19, 19, 43, 18, 59, DateTimeKind.Local).AddTicks(5751) });

            migrationBuilder.UpdateData(
                table: "tblDoctors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BirthDay", "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 43, 18, 59, DateTimeKind.Local).AddTicks(6066), new DateTime(2022, 1, 19, 19, 43, 18, 59, DateTimeKind.Local).AddTicks(6067), new DateTime(2022, 1, 19, 19, 43, 18, 59, DateTimeKind.Local).AddTicks(6068) });

            migrationBuilder.UpdateData(
                table: "tblDoctors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BirthDay", "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 43, 18, 59, DateTimeKind.Local).AddTicks(6069), new DateTime(2022, 1, 19, 19, 43, 18, 59, DateTimeKind.Local).AddTicks(6070), new DateTime(2022, 1, 19, 19, 43, 18, 59, DateTimeKind.Local).AddTicks(6071) });

            migrationBuilder.UpdateData(
                table: "tblDoctors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BirthDay", "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 43, 18, 59, DateTimeKind.Local).AddTicks(6072), new DateTime(2022, 1, 19, 19, 43, 18, 59, DateTimeKind.Local).AddTicks(6072), new DateTime(2022, 1, 19, 19, 43, 18, 59, DateTimeKind.Local).AddTicks(6073) });

            migrationBuilder.UpdateData(
                table: "tblEmployees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BirthDay", "CreatedOn", "ModifiedOn", "WorkEnd", "WorkStart" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 43, 18, 59, DateTimeKind.Local).AddTicks(6309), new DateTime(2022, 1, 19, 19, 43, 18, 59, DateTimeKind.Local).AddTicks(6310), new DateTime(2022, 1, 19, 19, 43, 18, 59, DateTimeKind.Local).AddTicks(6310), new DateTime(2022, 1, 19, 19, 43, 18, 59, DateTimeKind.Local).AddTicks(6308), new DateTime(2022, 1, 19, 19, 43, 18, 59, DateTimeKind.Local).AddTicks(6307) });

            migrationBuilder.UpdateData(
                table: "tblEmployees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BirthDay", "CreatedOn", "ModifiedOn", "WorkEnd", "WorkStart" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 43, 18, 59, DateTimeKind.Local).AddTicks(6313), new DateTime(2022, 1, 19, 19, 43, 18, 59, DateTimeKind.Local).AddTicks(6314), new DateTime(2022, 1, 19, 19, 43, 18, 59, DateTimeKind.Local).AddTicks(6314), new DateTime(2022, 1, 19, 19, 43, 18, 59, DateTimeKind.Local).AddTicks(6312), new DateTime(2022, 1, 19, 19, 43, 18, 59, DateTimeKind.Local).AddTicks(6312) });

            migrationBuilder.UpdateData(
                table: "tblEmployees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BirthDay", "CreatedOn", "ModifiedOn", "WorkEnd", "WorkStart" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 43, 18, 59, DateTimeKind.Local).AddTicks(6317), new DateTime(2022, 1, 19, 19, 43, 18, 59, DateTimeKind.Local).AddTicks(6317), new DateTime(2022, 1, 19, 19, 43, 18, 59, DateTimeKind.Local).AddTicks(6318), new DateTime(2022, 1, 19, 19, 43, 18, 59, DateTimeKind.Local).AddTicks(6316), new DateTime(2022, 1, 19, 19, 43, 18, 59, DateTimeKind.Local).AddTicks(6315) });

            migrationBuilder.UpdateData(
                table: "tblHospitalBranches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 43, 18, 59, DateTimeKind.Local).AddTicks(5652), new DateTime(2022, 1, 19, 19, 43, 18, 59, DateTimeKind.Local).AddTicks(5652) });

            migrationBuilder.UpdateData(
                table: "tblHospitalBranches",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 43, 18, 59, DateTimeKind.Local).AddTicks(5655), new DateTime(2022, 1, 19, 19, 43, 18, 59, DateTimeKind.Local).AddTicks(5655) });

            migrationBuilder.UpdateData(
                table: "tblHospitalBranches",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 43, 18, 59, DateTimeKind.Local).AddTicks(5657), new DateTime(2022, 1, 19, 19, 43, 18, 59, DateTimeKind.Local).AddTicks(5657) });

            migrationBuilder.UpdateData(
                table: "tblHospitalBranches",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 43, 18, 59, DateTimeKind.Local).AddTicks(5659), new DateTime(2022, 1, 19, 19, 43, 18, 59, DateTimeKind.Local).AddTicks(5659) });

            migrationBuilder.UpdateData(
                table: "tblHospitalBranches",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 43, 18, 59, DateTimeKind.Local).AddTicks(5661), new DateTime(2022, 1, 19, 19, 43, 18, 59, DateTimeKind.Local).AddTicks(5661) });

            migrationBuilder.UpdateData(
                table: "tblHospitalBranches",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 43, 18, 59, DateTimeKind.Local).AddTicks(5663), new DateTime(2022, 1, 19, 19, 43, 18, 59, DateTimeKind.Local).AddTicks(5663) });

            migrationBuilder.UpdateData(
                table: "tblHospitalBranches",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 43, 18, 59, DateTimeKind.Local).AddTicks(5664), new DateTime(2022, 1, 19, 19, 43, 18, 59, DateTimeKind.Local).AddTicks(5665) });

            migrationBuilder.UpdateData(
                table: "tblHospitalBranches",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 43, 18, 59, DateTimeKind.Local).AddTicks(5666), new DateTime(2022, 1, 19, 19, 43, 18, 59, DateTimeKind.Local).AddTicks(5667) });

            migrationBuilder.UpdateData(
                table: "tblHospitals",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 43, 18, 59, DateTimeKind.Local).AddTicks(5466), new DateTime(2022, 1, 19, 19, 43, 18, 59, DateTimeKind.Local).AddTicks(5454) });

            migrationBuilder.UpdateData(
                table: "tblHospitals",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 43, 18, 59, DateTimeKind.Local).AddTicks(5469), new DateTime(2022, 1, 19, 19, 43, 18, 59, DateTimeKind.Local).AddTicks(5468) });

            migrationBuilder.UpdateData(
                table: "tblHospitals",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 43, 18, 59, DateTimeKind.Local).AddTicks(5471), new DateTime(2022, 1, 19, 19, 43, 18, 59, DateTimeKind.Local).AddTicks(5470) });

            migrationBuilder.UpdateData(
                table: "tblHospitals",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 43, 18, 59, DateTimeKind.Local).AddTicks(5472), new DateTime(2022, 1, 19, 19, 43, 18, 59, DateTimeKind.Local).AddTicks(5472) });

            migrationBuilder.UpdateData(
                table: "tblHospitals",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 43, 18, 59, DateTimeKind.Local).AddTicks(5474), new DateTime(2022, 1, 19, 19, 43, 18, 59, DateTimeKind.Local).AddTicks(5473) });

            migrationBuilder.UpdateData(
                table: "tblHospitals",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 43, 18, 59, DateTimeKind.Local).AddTicks(5475), new DateTime(2022, 1, 19, 19, 43, 18, 59, DateTimeKind.Local).AddTicks(5475) });

            migrationBuilder.UpdateData(
                table: "tblHospitals",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 43, 18, 59, DateTimeKind.Local).AddTicks(5477), new DateTime(2022, 1, 19, 19, 43, 18, 59, DateTimeKind.Local).AddTicks(5476) });

            migrationBuilder.UpdateData(
                table: "tblHospitals",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 43, 18, 59, DateTimeKind.Local).AddTicks(5479), new DateTime(2022, 1, 19, 19, 43, 18, 59, DateTimeKind.Local).AddTicks(5478) });

            migrationBuilder.UpdateData(
                table: "tblHospitals",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 43, 18, 59, DateTimeKind.Local).AddTicks(5480), new DateTime(2022, 1, 19, 19, 43, 18, 59, DateTimeKind.Local).AddTicks(5480) });

            migrationBuilder.InsertData(
                table: "tblProductEntries",
                columns: new[] { "Id", "Barcode", "CompanyId", "CreatedOn", "Description", "EntryDate", "EntryTypeId", "ExpirationDate", "InvoiceNumber", "LotSerial", "ModifiedOn", "ModifiedUser", "ProductId", "ProductionDate", "Quantity" },
                values: new object[,]
                {
                    { 1, "AR-1000/1", 1, new DateTime(2022, 1, 19, 19, 43, 18, 60, DateTimeKind.Local).AddTicks(1594), "Test1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2022, 1, 19, 19, 43, 18, 60, DateTimeKind.Local).AddTicks(1600), "1234", "1", new DateTime(2022, 1, 19, 19, 43, 18, 60, DateTimeKind.Local).AddTicks(1599), null, 1, new DateTime(2022, 1, 19, 19, 43, 18, 60, DateTimeKind.Local).AddTicks(1601), 0 },
                    { 2, "AR-1000/2", 1, new DateTime(2022, 1, 19, 19, 43, 18, 60, DateTimeKind.Local).AddTicks(1603), "Test2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2022, 1, 19, 19, 43, 18, 60, DateTimeKind.Local).AddTicks(1604), "1234", "2", new DateTime(2022, 1, 19, 19, 43, 18, 60, DateTimeKind.Local).AddTicks(1603), "system", 1, new DateTime(2022, 1, 19, 19, 43, 18, 60, DateTimeKind.Local).AddTicks(1605), 100 },
                    { 3, "AR-1001/1", 1, new DateTime(2022, 1, 19, 19, 43, 18, 60, DateTimeKind.Local).AddTicks(1607), "Test3", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2022, 1, 19, 19, 43, 18, 60, DateTimeKind.Local).AddTicks(1609), "1234", "1", new DateTime(2022, 1, 19, 19, 43, 18, 60, DateTimeKind.Local).AddTicks(1608), "system", 2, new DateTime(2022, 1, 19, 19, 43, 18, 60, DateTimeKind.Local).AddTicks(1609), 0 },
                    { 4, "AR-1002/1", 1, new DateTime(2022, 1, 19, 19, 43, 18, 60, DateTimeKind.Local).AddTicks(1611), "Test4", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2022, 1, 19, 19, 43, 18, 60, DateTimeKind.Local).AddTicks(1612), "4321", "1", new DateTime(2022, 1, 19, 19, 43, 18, 60, DateTimeKind.Local).AddTicks(1611), "system", 3, new DateTime(2022, 1, 19, 19, 43, 18, 60, DateTimeKind.Local).AddTicks(1613), 0 }
                });

            migrationBuilder.UpdateData(
                table: "tblProducts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "EntryDate", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 43, 18, 59, DateTimeKind.Local).AddTicks(6561), new DateTime(2022, 1, 19, 19, 43, 18, 59, DateTimeKind.Local).AddTicks(6557), new DateTime(2022, 1, 19, 19, 43, 18, 59, DateTimeKind.Local).AddTicks(6562) });

            migrationBuilder.UpdateData(
                table: "tblProducts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "EntryDate", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 43, 18, 59, DateTimeKind.Local).AddTicks(6565), new DateTime(2022, 1, 19, 19, 43, 18, 59, DateTimeKind.Local).AddTicks(6563), new DateTime(2022, 1, 19, 19, 43, 18, 59, DateTimeKind.Local).AddTicks(6566) });

            migrationBuilder.UpdateData(
                table: "tblProducts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "EntryDate", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 43, 18, 59, DateTimeKind.Local).AddTicks(6568), new DateTime(2022, 1, 19, 19, 43, 18, 59, DateTimeKind.Local).AddTicks(6567), new DateTime(2022, 1, 19, 19, 43, 18, 59, DateTimeKind.Local).AddTicks(6568) });

            migrationBuilder.UpdateData(
                table: "tblProducts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "EntryDate", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 43, 18, 59, DateTimeKind.Local).AddTicks(6571), new DateTime(2022, 1, 19, 19, 43, 18, 59, DateTimeKind.Local).AddTicks(6570), new DateTime(2022, 1, 19, 19, 43, 18, 59, DateTimeKind.Local).AddTicks(6571) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "tblProductEntries",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "tblProductEntries",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "tblProductEntries",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "tblProductEntries",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "tblCompanies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 18, 0, 49, 473, DateTimeKind.Local).AddTicks(5640), new DateTime(2022, 1, 19, 18, 0, 49, 473, DateTimeKind.Local).AddTicks(5640) });

            migrationBuilder.UpdateData(
                table: "tblCompanies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 18, 0, 49, 473, DateTimeKind.Local).AddTicks(5643), new DateTime(2022, 1, 19, 18, 0, 49, 473, DateTimeKind.Local).AddTicks(5644) });

            migrationBuilder.UpdateData(
                table: "tblCompanies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 18, 0, 49, 473, DateTimeKind.Local).AddTicks(5645), new DateTime(2022, 1, 19, 18, 0, 49, 473, DateTimeKind.Local).AddTicks(5646) });

            migrationBuilder.UpdateData(
                table: "tblCompanyBranches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 18, 0, 49, 473, DateTimeKind.Local).AddTicks(5355), new DateTime(2022, 1, 19, 18, 0, 49, 473, DateTimeKind.Local).AddTicks(5355) });

            migrationBuilder.UpdateData(
                table: "tblCompanyBranches",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 18, 0, 49, 473, DateTimeKind.Local).AddTicks(5357), new DateTime(2022, 1, 19, 18, 0, 49, 473, DateTimeKind.Local).AddTicks(5358) });

            migrationBuilder.UpdateData(
                table: "tblCompanyBranches",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 18, 0, 49, 473, DateTimeKind.Local).AddTicks(5359), new DateTime(2022, 1, 19, 18, 0, 49, 473, DateTimeKind.Local).AddTicks(5360) });

            migrationBuilder.UpdateData(
                table: "tblCompanyBranches",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 18, 0, 49, 473, DateTimeKind.Local).AddTicks(5361), new DateTime(2022, 1, 19, 18, 0, 49, 473, DateTimeKind.Local).AddTicks(5362) });

            migrationBuilder.UpdateData(
                table: "tblCompanyBranches",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 18, 0, 49, 473, DateTimeKind.Local).AddTicks(5363), new DateTime(2022, 1, 19, 18, 0, 49, 473, DateTimeKind.Local).AddTicks(5363) });

            migrationBuilder.UpdateData(
                table: "tblCompanyBranches",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 18, 0, 49, 473, DateTimeKind.Local).AddTicks(5365), new DateTime(2022, 1, 19, 18, 0, 49, 473, DateTimeKind.Local).AddTicks(5365) });

            migrationBuilder.UpdateData(
                table: "tblDoctors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BirthDay", "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 18, 0, 49, 473, DateTimeKind.Local).AddTicks(5721), new DateTime(2022, 1, 19, 18, 0, 49, 473, DateTimeKind.Local).AddTicks(5721), new DateTime(2022, 1, 19, 18, 0, 49, 473, DateTimeKind.Local).AddTicks(5722) });

            migrationBuilder.UpdateData(
                table: "tblDoctors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BirthDay", "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 18, 0, 49, 473, DateTimeKind.Local).AddTicks(5724), new DateTime(2022, 1, 19, 18, 0, 49, 473, DateTimeKind.Local).AddTicks(5724), new DateTime(2022, 1, 19, 18, 0, 49, 473, DateTimeKind.Local).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "tblDoctors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BirthDay", "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 18, 0, 49, 473, DateTimeKind.Local).AddTicks(5726), new DateTime(2022, 1, 19, 18, 0, 49, 473, DateTimeKind.Local).AddTicks(5727), new DateTime(2022, 1, 19, 18, 0, 49, 473, DateTimeKind.Local).AddTicks(5727) });

            migrationBuilder.UpdateData(
                table: "tblEmployees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BirthDay", "CreatedOn", "ModifiedOn", "WorkEnd", "WorkStart" },
                values: new object[] { new DateTime(2022, 1, 19, 18, 0, 49, 473, DateTimeKind.Local).AddTicks(5886), new DateTime(2022, 1, 19, 18, 0, 49, 473, DateTimeKind.Local).AddTicks(5887), new DateTime(2022, 1, 19, 18, 0, 49, 473, DateTimeKind.Local).AddTicks(5887), new DateTime(2022, 1, 19, 18, 0, 49, 473, DateTimeKind.Local).AddTicks(5885), new DateTime(2022, 1, 19, 18, 0, 49, 473, DateTimeKind.Local).AddTicks(5884) });

            migrationBuilder.UpdateData(
                table: "tblEmployees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BirthDay", "CreatedOn", "ModifiedOn", "WorkEnd", "WorkStart" },
                values: new object[] { new DateTime(2022, 1, 19, 18, 0, 49, 473, DateTimeKind.Local).AddTicks(5890), new DateTime(2022, 1, 19, 18, 0, 49, 473, DateTimeKind.Local).AddTicks(5891), new DateTime(2022, 1, 19, 18, 0, 49, 473, DateTimeKind.Local).AddTicks(5892), new DateTime(2022, 1, 19, 18, 0, 49, 473, DateTimeKind.Local).AddTicks(5889), new DateTime(2022, 1, 19, 18, 0, 49, 473, DateTimeKind.Local).AddTicks(5889) });

            migrationBuilder.UpdateData(
                table: "tblEmployees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BirthDay", "CreatedOn", "ModifiedOn", "WorkEnd", "WorkStart" },
                values: new object[] { new DateTime(2022, 1, 19, 18, 0, 49, 473, DateTimeKind.Local).AddTicks(5894), new DateTime(2022, 1, 19, 18, 0, 49, 473, DateTimeKind.Local).AddTicks(5894), new DateTime(2022, 1, 19, 18, 0, 49, 473, DateTimeKind.Local).AddTicks(5895), new DateTime(2022, 1, 19, 18, 0, 49, 473, DateTimeKind.Local).AddTicks(5893), new DateTime(2022, 1, 19, 18, 0, 49, 473, DateTimeKind.Local).AddTicks(5893) });

            migrationBuilder.UpdateData(
                table: "tblHospitalBranches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 18, 0, 49, 473, DateTimeKind.Local).AddTicks(5264), new DateTime(2022, 1, 19, 18, 0, 49, 473, DateTimeKind.Local).AddTicks(5266) });

            migrationBuilder.UpdateData(
                table: "tblHospitalBranches",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 18, 0, 49, 473, DateTimeKind.Local).AddTicks(5268), new DateTime(2022, 1, 19, 18, 0, 49, 473, DateTimeKind.Local).AddTicks(5269) });

            migrationBuilder.UpdateData(
                table: "tblHospitalBranches",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 18, 0, 49, 473, DateTimeKind.Local).AddTicks(5271), new DateTime(2022, 1, 19, 18, 0, 49, 473, DateTimeKind.Local).AddTicks(5271) });

            migrationBuilder.UpdateData(
                table: "tblHospitalBranches",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 18, 0, 49, 473, DateTimeKind.Local).AddTicks(5272), new DateTime(2022, 1, 19, 18, 0, 49, 473, DateTimeKind.Local).AddTicks(5273) });

            migrationBuilder.UpdateData(
                table: "tblHospitalBranches",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 18, 0, 49, 473, DateTimeKind.Local).AddTicks(5275), new DateTime(2022, 1, 19, 18, 0, 49, 473, DateTimeKind.Local).AddTicks(5275) });

            migrationBuilder.UpdateData(
                table: "tblHospitalBranches",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 18, 0, 49, 473, DateTimeKind.Local).AddTicks(5276), new DateTime(2022, 1, 19, 18, 0, 49, 473, DateTimeKind.Local).AddTicks(5277) });

            migrationBuilder.UpdateData(
                table: "tblHospitalBranches",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 18, 0, 49, 473, DateTimeKind.Local).AddTicks(5278), new DateTime(2022, 1, 19, 18, 0, 49, 473, DateTimeKind.Local).AddTicks(5279) });

            migrationBuilder.UpdateData(
                table: "tblHospitalBranches",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 18, 0, 49, 473, DateTimeKind.Local).AddTicks(5280), new DateTime(2022, 1, 19, 18, 0, 49, 473, DateTimeKind.Local).AddTicks(5281) });

            migrationBuilder.UpdateData(
                table: "tblHospitals",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 18, 0, 49, 473, DateTimeKind.Local).AddTicks(5103), new DateTime(2022, 1, 19, 18, 0, 49, 473, DateTimeKind.Local).AddTicks(5091) });

            migrationBuilder.UpdateData(
                table: "tblHospitals",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 18, 0, 49, 473, DateTimeKind.Local).AddTicks(5105), new DateTime(2022, 1, 19, 18, 0, 49, 473, DateTimeKind.Local).AddTicks(5105) });

            migrationBuilder.UpdateData(
                table: "tblHospitals",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 18, 0, 49, 473, DateTimeKind.Local).AddTicks(5107), new DateTime(2022, 1, 19, 18, 0, 49, 473, DateTimeKind.Local).AddTicks(5106) });

            migrationBuilder.UpdateData(
                table: "tblHospitals",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 18, 0, 49, 473, DateTimeKind.Local).AddTicks(5109), new DateTime(2022, 1, 19, 18, 0, 49, 473, DateTimeKind.Local).AddTicks(5108) });

            migrationBuilder.UpdateData(
                table: "tblHospitals",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 18, 0, 49, 473, DateTimeKind.Local).AddTicks(5110), new DateTime(2022, 1, 19, 18, 0, 49, 473, DateTimeKind.Local).AddTicks(5110) });

            migrationBuilder.UpdateData(
                table: "tblHospitals",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 18, 0, 49, 473, DateTimeKind.Local).AddTicks(5112), new DateTime(2022, 1, 19, 18, 0, 49, 473, DateTimeKind.Local).AddTicks(5111) });

            migrationBuilder.UpdateData(
                table: "tblHospitals",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 18, 0, 49, 473, DateTimeKind.Local).AddTicks(5114), new DateTime(2022, 1, 19, 18, 0, 49, 473, DateTimeKind.Local).AddTicks(5113) });

            migrationBuilder.UpdateData(
                table: "tblHospitals",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 18, 0, 49, 473, DateTimeKind.Local).AddTicks(5116), new DateTime(2022, 1, 19, 18, 0, 49, 473, DateTimeKind.Local).AddTicks(5115) });

            migrationBuilder.UpdateData(
                table: "tblHospitals",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 18, 0, 49, 473, DateTimeKind.Local).AddTicks(5117), new DateTime(2022, 1, 19, 18, 0, 49, 473, DateTimeKind.Local).AddTicks(5116) });

            migrationBuilder.UpdateData(
                table: "tblProducts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "EntryDate", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 18, 0, 49, 473, DateTimeKind.Local).AddTicks(6048), new DateTime(2022, 1, 19, 18, 0, 49, 473, DateTimeKind.Local).AddTicks(6044), new DateTime(2022, 1, 19, 18, 0, 49, 473, DateTimeKind.Local).AddTicks(6048) });

            migrationBuilder.UpdateData(
                table: "tblProducts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "EntryDate", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 18, 0, 49, 473, DateTimeKind.Local).AddTicks(6051), new DateTime(2022, 1, 19, 18, 0, 49, 473, DateTimeKind.Local).AddTicks(6050), new DateTime(2022, 1, 19, 18, 0, 49, 473, DateTimeKind.Local).AddTicks(6052) });

            migrationBuilder.UpdateData(
                table: "tblProducts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "EntryDate", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 18, 0, 49, 473, DateTimeKind.Local).AddTicks(6054), new DateTime(2022, 1, 19, 18, 0, 49, 473, DateTimeKind.Local).AddTicks(6053), new DateTime(2022, 1, 19, 18, 0, 49, 473, DateTimeKind.Local).AddTicks(6055) });

            migrationBuilder.UpdateData(
                table: "tblProducts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "EntryDate", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 18, 0, 49, 473, DateTimeKind.Local).AddTicks(6057), new DateTime(2022, 1, 19, 18, 0, 49, 473, DateTimeKind.Local).AddTicks(6056), new DateTime(2022, 1, 19, 18, 0, 49, 473, DateTimeKind.Local).AddTicks(6058) });
        }
    }
}
