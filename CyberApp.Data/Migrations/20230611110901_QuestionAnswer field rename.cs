using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CyberApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class QuestionAnswerfieldrename : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StoryQuestionTextId",
                table: "ClassQuestions");

            migrationBuilder.RenameColumn(
                name: "Answer",
                table: "ClassQuestionAnswers",
                newName: "Text");

            migrationBuilder.AddColumn<string>(
                name: "Text",
                table: "ClassQuestions",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Text",
                table: "ClassQuestions");

            migrationBuilder.RenameColumn(
                name: "Text",
                table: "ClassQuestionAnswers",
                newName: "Answer");

            migrationBuilder.AddColumn<int>(
                name: "StoryQuestionTextId",
                table: "ClassQuestions",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }
    }
}
