using Microsoft.EntityFrameworkCore.Migrations;

namespace BankServer.Migrations
{
    public partial class Bank_InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Transactions",
                columns: table => new
                {
                    TransactionReference = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccountNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    StartBalance = table.Column<double>(type: "float", nullable: false),
                    Mutation = table.Column<double>(type: "float", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EndBalance = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transactions", x => x.TransactionReference);
                });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionReference", "AccountNumber", "Description", "EndBalance", "Mutation", "StartBalance" },
                values: new object[] { 1, "NL10RABO9182987610", "Food", 965.0, -35.950000000000003, 1000.95 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Transactions");
        }
    }
}
