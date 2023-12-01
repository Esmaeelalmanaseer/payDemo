using Microsoft.EntityFrameworkCore.Migrations;

namespace payDemo.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "paydetals",
                columns: table => new
                {
                    PayId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CardOwner = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    CardNumber = table.Column<string>(type: "nvarchar(16)", nullable: true),
                    ExpirPay = table.Column<string>(type: "nvarchar(5)", nullable: true),
                    securityCode = table.Column<string>(type: "nvarchar(3)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_paydetals", x => x.PayId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "paydetals");
        }
    }
}
