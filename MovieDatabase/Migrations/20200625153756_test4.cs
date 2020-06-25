using Microsoft.EntityFrameworkCore.Migrations;

namespace MovieDatabase.Migrations
{
    public partial class test4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Actors",
                table: "Movies",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "AvgVote",
                table: "Movies",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Movies",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Director",
                table: "Movies",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Duration",
                table: "Movies",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Genre",
                table: "Movies",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Language",
                table: "Movies",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Votes",
                table: "Movies",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Year",
                table: "Movies",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Actors",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "AvgVote",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "Director",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "Duration",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "Genre",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "Language",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "Votes",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "Year",
                table: "Movies");
        }
    }
}
