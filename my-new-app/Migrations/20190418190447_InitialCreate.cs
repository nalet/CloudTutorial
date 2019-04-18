using Microsoft.EntityFrameworkCore.Migrations;

namespace my_new_app.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Person",
                columns: table => new
                {
                    PersonId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => x.PersonId);
                });

            migrationBuilder.CreateTable(
                name: "Objekt",
                columns: table => new
                {
                    ObjektId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    name = table.Column<string>(nullable: true),
                    besitzerPersonId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Objekt", x => x.ObjektId);
                    table.ForeignKey(
                        name: "FK_Objekt_Person_besitzerPersonId",
                        column: x => x.besitzerPersonId,
                        principalTable: "Person",
                        principalColumn: "PersonId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Einheit",
                columns: table => new
                {
                    EinheitId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    name = table.Column<string>(nullable: true),
                    PersonId = table.Column<int>(nullable: true),
                    ObjektId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Einheit", x => x.EinheitId);
                    table.ForeignKey(
                        name: "FK_Einheit_Objekt_ObjektId",
                        column: x => x.ObjektId,
                        principalTable: "Objekt",
                        principalColumn: "ObjektId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Einheit_Person_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Person",
                        principalColumn: "PersonId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Verbrauch",
                columns: table => new
                {
                    VerbrauchId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    verbrauch = table.Column<int>(nullable: false),
                    EinheitId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Verbrauch", x => x.VerbrauchId);
                    table.ForeignKey(
                        name: "FK_Verbrauch_Einheit_EinheitId",
                        column: x => x.EinheitId,
                        principalTable: "Einheit",
                        principalColumn: "EinheitId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Einheit_ObjektId",
                table: "Einheit",
                column: "ObjektId");

            migrationBuilder.CreateIndex(
                name: "IX_Einheit_PersonId",
                table: "Einheit",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Objekt_besitzerPersonId",
                table: "Objekt",
                column: "besitzerPersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Verbrauch_EinheitId",
                table: "Verbrauch",
                column: "EinheitId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Verbrauch");

            migrationBuilder.DropTable(
                name: "Einheit");

            migrationBuilder.DropTable(
                name: "Objekt");

            migrationBuilder.DropTable(
                name: "Person");
        }
    }
}
