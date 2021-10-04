using Microsoft.EntityFrameworkCore.Migrations;

namespace DoAn.Migrations
{
    public partial class AddCategoryToDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Statuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Statuss = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Statuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tags",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tags", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TravelModels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameTravel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AuthorTravel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Infomation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Infomation1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Infomation2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DisplayTravel = table.Column<int>(type: "int", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl4 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StatusId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TravelModels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TravelModels_Statuses_StatusId",
                        column: x => x.StatusId,
                        principalTable: "Statuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TravelTags",
                columns: table => new
                {
                    TravelModelId = table.Column<int>(type: "int", nullable: false),
                    TagId = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TravelTags", x => new { x.TravelModelId, x.TagId });
                    table.ForeignKey(
                        name: "FK_TravelTags_Tags_TagId",
                        column: x => x.TagId,
                        principalTable: "Tags",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TravelTags_TravelModels_TravelModelId",
                        column: x => x.TravelModelId,
                        principalTable: "TravelModels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { 1, null, "Rẻ" });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { 2, null, "Ngon" });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { 3, null, "Bổ Khỏe" });

            migrationBuilder.CreateIndex(
                name: "IX_TravelModels_StatusId",
                table: "TravelModels",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_TravelTags_TagId",
                table: "TravelTags",
                column: "TagId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TravelTags");

            migrationBuilder.DropTable(
                name: "Tags");

            migrationBuilder.DropTable(
                name: "TravelModels");

            migrationBuilder.DropTable(
                name: "Statuses");
        }
    }
}
