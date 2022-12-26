using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "manufacturers",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_manufacturers", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "models",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false),
                    code = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false),
                    start_date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    end_date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    manufacturer_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_models", x => x.id);
                    table.ForeignKey(
                        name: "FK_models_manufacturers_manufacturer_id",
                        column: x => x.manufacturer_id,
                        principalTable: "manufacturers",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "complectations",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false),
                    start_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    end_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    engine = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false, defaultValue: ""),
                    grade = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false, defaultValue: ""),
                    transmission = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false, defaultValue: ""),
                    gear_shift_type = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false, defaultValue: ""),
                    driver_position = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false, defaultValue: ""),
                    destination = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false, defaultValue: ""),
                    fuel_induction = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false, defaultValue: ""),
                    model_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_complectations", x => x.id);
                    table.ForeignKey(
                        name: "FK_complectations_models_model_id",
                        column: x => x.model_id,
                        principalTable: "models",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "parts_groups",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false),
                    complectation_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_parts_groups", x => x.id);
                    table.ForeignKey(
                        name: "FK_parts_groups_complectations_complectation_id",
                        column: x => x.complectation_id,
                        principalTable: "complectations",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "parts_sub_groups",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false),
                    parts_group_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_parts_sub_groups", x => x.id);
                    table.ForeignKey(
                        name: "FK_parts_sub_groups_parts_groups_parts_group_id",
                        column: x => x.parts_group_id,
                        principalTable: "parts_groups",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "parts",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false),
                    code = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false),
                    tree_code = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false),
                    count = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    info = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false, defaultValue: ""),
                    start_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    end_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    image = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false, defaultValue: ""),
                    parts_subgroup_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_parts", x => x.id);
                    table.ForeignKey(
                        name: "FK_parts_parts_sub_groups_parts_subgroup_id",
                        column: x => x.parts_subgroup_id,
                        principalTable: "parts_sub_groups",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_complectations_model_id",
                table: "complectations",
                column: "model_id");

            migrationBuilder.CreateIndex(
                name: "IX_complectations_name",
                table: "complectations",
                column: "name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_complectations_name_start_date_end_date",
                table: "complectations",
                columns: new[] { "name", "start_date", "end_date" });

            migrationBuilder.CreateIndex(
                name: "IX_manufacturers_name",
                table: "manufacturers",
                column: "name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_models_manufacturer_id",
                table: "models",
                column: "manufacturer_id");

            migrationBuilder.CreateIndex(
                name: "IX_models_name",
                table: "models",
                column: "name");

            migrationBuilder.CreateIndex(
                name: "IX_models_name_code",
                table: "models",
                columns: new[] { "name", "code" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_models_name_code_start_date_end_date",
                table: "models",
                columns: new[] { "name", "code", "start_date", "end_date" });

            migrationBuilder.CreateIndex(
                name: "IX_parts_name",
                table: "parts",
                column: "name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_parts_name_start_date_end_date",
                table: "parts",
                columns: new[] { "name", "start_date", "end_date" });

            migrationBuilder.CreateIndex(
                name: "IX_parts_name_tree_code_code",
                table: "parts",
                columns: new[] { "name", "tree_code", "code" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_parts_parts_subgroup_id",
                table: "parts",
                column: "parts_subgroup_id");

            migrationBuilder.CreateIndex(
                name: "IX_parts_groups_complectation_id",
                table: "parts_groups",
                column: "complectation_id");

            migrationBuilder.CreateIndex(
                name: "IX_parts_groups_name",
                table: "parts_groups",
                column: "name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_parts_sub_groups_name",
                table: "parts_sub_groups",
                column: "name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_parts_sub_groups_parts_group_id",
                table: "parts_sub_groups",
                column: "parts_group_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "parts");

            migrationBuilder.DropTable(
                name: "parts_sub_groups");

            migrationBuilder.DropTable(
                name: "parts_groups");

            migrationBuilder.DropTable(
                name: "complectations");

            migrationBuilder.DropTable(
                name: "models");

            migrationBuilder.DropTable(
                name: "manufacturers");
        }
    }
}
