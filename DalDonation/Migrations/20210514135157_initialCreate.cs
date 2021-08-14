using Microsoft.EntityFrameworkCore.Migrations;

namespace DalDonation.Migrations
{
    public partial class initialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "currency",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DescriptionCurrency = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_currency", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "donation",
                columns: table => new
                {
                    DonationId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    YeshutName = table.Column<string>(nullable: true),
                    CountDonation = table.Column<float>(nullable: false),
                    CodeSugYeshut = table.Column<int>(nullable: false),
                    ReasonDonation = table.Column<string>(nullable: true),
                    ConditionDonation = table.Column<string>(nullable: true),
                    CodeSugCurrency = table.Column<int>(nullable: true),
                    ConversionRate = table.Column<float>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_donation", x => x.DonationId);
                });

            migrationBuilder.CreateTable(
                name: "sugYeshut",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DescriptionYeshut = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sugYeshut", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "currency");

            migrationBuilder.DropTable(
                name: "donation");

            migrationBuilder.DropTable(
                name: "sugYeshut");
        }
    }
}
