using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataLayer.Migrations
{
    /// <inheritdoc />
    public partial class SetUpBaseDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Actors",
                columns: table => new
                {
                    ActorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ActorName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sex = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Added = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AddedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReasonForUpdating = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Actors", x => x.ActorId);
                });

            migrationBuilder.CreateTable(
                name: "Albums",
                columns: table => new
                {
                    AlbumId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AlbumTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BandName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Band = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Titel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Genre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Format = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StillOwn = table.Column<bool>(type: "bit", nullable: false),
                    Added = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AddedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReasonForUpdating = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Albums", x => x.AlbumId);
                });

            migrationBuilder.CreateTable(
                name: "Bands",
                columns: table => new
                {
                    BandId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BandName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Formed = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Added = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AddedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReasonForUpdating = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bands", x => x.BandId);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    BookId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FNAuthor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ENAuthor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FullNAuthor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Titel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Genre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    ISBN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StillOwn = table.Column<bool>(type: "bit", nullable: false),
                    Added = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AddedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReasonForUpdating = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.BookId);
                });

            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    GameId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Added = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AddedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReasonForUpdating = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.GameId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AcessRights = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Added = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AddedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReasonForUpdating = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    MovieId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MovieTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Genre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Director = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MainStar = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StillOwn = table.Column<bool>(type: "bit", nullable: false),
                    Added = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AddedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReasonForUpdating = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ActorId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.MovieId);
                    table.ForeignKey(
                        name: "FK_Movies_Actors_ActorId",
                        column: x => x.ActorId,
                        principalTable: "Actors",
                        principalColumn: "ActorId");
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "AcessRights", "Added", "AddedBy", "FirstName", "FullName", "LastName", "Password", "ReasonForUpdating", "Updated", "UpdatedBy", "UserName" },
                values: new object[] { 1, "Admin", new DateTime(1989, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "System", "John", "John Doe", "Doe", "SysAdmin1", "Marrige", new DateTime(2019, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "System", "Admin" });

            migrationBuilder.CreateIndex(
                name: "IX_Movies_ActorId",
                table: "Movies",
                column: "ActorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Albums");

            migrationBuilder.DropTable(
                name: "Bands");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Games");

            migrationBuilder.DropTable(
                name: "Movies");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Actors");
        }
    }
}
