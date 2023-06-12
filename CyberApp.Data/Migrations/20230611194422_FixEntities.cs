using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CyberApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class FixEntities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CharacterStats_Stat_StatId",
                table: "CharacterStats");

            migrationBuilder.DropTable(
                name: "Stat");

            migrationBuilder.DropColumn(
                name: "Value",
                table: "Stats");

            migrationBuilder.AlterColumn<string>(
                name: "Image",
                table: "CharacterClasses",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "CharacterClasses",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterStats_CharacterClassId",
                table: "CharacterStats",
                column: "CharacterClassId");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterSkills_CharacterClassId",
                table: "CharacterSkills",
                column: "CharacterClassId");

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterSkills_CharacterClasses_CharacterClassId",
                table: "CharacterSkills",
                column: "CharacterClassId",
                principalTable: "CharacterClasses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterStats_CharacterClasses_CharacterClassId",
                table: "CharacterStats",
                column: "CharacterClassId",
                principalTable: "CharacterClasses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterStats_Stats_StatId",
                table: "CharacterStats",
                column: "StatId",
                principalTable: "Stats",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CharacterSkills_CharacterClasses_CharacterClassId",
                table: "CharacterSkills");

            migrationBuilder.DropForeignKey(
                name: "FK_CharacterStats_CharacterClasses_CharacterClassId",
                table: "CharacterStats");

            migrationBuilder.DropForeignKey(
                name: "FK_CharacterStats_Stats_StatId",
                table: "CharacterStats");

            migrationBuilder.DropIndex(
                name: "IX_CharacterStats_CharacterClassId",
                table: "CharacterStats");

            migrationBuilder.DropIndex(
                name: "IX_CharacterSkills_CharacterClassId",
                table: "CharacterSkills");

            migrationBuilder.AddColumn<int>(
                name: "Value",
                table: "Stats",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Image",
                table: "CharacterClasses",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "CharacterClasses",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Stat",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stat", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterStats_Stat_StatId",
                table: "CharacterStats",
                column: "StatId",
                principalTable: "Stat",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
