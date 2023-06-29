using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FileStorageDAL.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "AQAAAAIAAYagAAAAEAZxgGx9vQr5qc+7ArajYsi4UYPk7ahQsbH+1/Q1mp9iQMAlf4pYW+gDe1Dk1ddvzg==");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEMsRjIdIZPytpCnNfwWRPXgftI+mEvPoXfvLnAJ3gFwfoM2UJbhIfyM5EDjJ8H0SyQ==");
        }
    }
}
