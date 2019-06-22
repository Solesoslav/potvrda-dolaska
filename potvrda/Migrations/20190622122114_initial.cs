using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace potvrda.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Odgovori",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ImeDeteta = table.Column<string>(nullable: false),
                    ImeRoditelja = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    Telefon = table.Column<string>(nullable: true),
                    Viber = table.Column<bool>(nullable: true),
                    PotvrdaDolaska = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Odgovori", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Odgovori");
        }
    }
}
