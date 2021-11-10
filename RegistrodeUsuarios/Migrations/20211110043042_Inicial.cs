using Microsoft.EntityFrameworkCore.Migrations;

namespace RegistrodeUsuarios.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Usuarioid = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombres = table.Column<string>(type: "TEXT", nullable: true),
                    Apellidos = table.Column<string>(type: "TEXT", nullable: true),
                    NombreDeUsuario = table.Column<string>(type: "TEXT", nullable: true),
                    Contrasena = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Usuarioid);
                });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "Usuarioid", "Apellidos", "Contrasena", "NombreDeUsuario", "Nombres" },
                values: new object[] { 1, "Osorio", "e1ab9d7f0b137ad16566742ad38863ec42b6d7fba157ef51638e60a4e044bd13", "Josue2018", "Josue" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
