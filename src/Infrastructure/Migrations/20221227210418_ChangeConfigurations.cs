using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class ChangeConfigurations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_parts_sub_groups_name",
                table: "parts_sub_groups");

            migrationBuilder.DropIndex(
                name: "IX_parts_groups_name",
                table: "parts_groups");

            migrationBuilder.DropIndex(
                name: "IX_parts_name",
                table: "parts");

            migrationBuilder.DropIndex(
                name: "IX_parts_name_tree_code_code",
                table: "parts");

            migrationBuilder.DropIndex(
                name: "IX_models_name_code",
                table: "models");

            migrationBuilder.DropIndex(
                name: "IX_manufacturers_name",
                table: "manufacturers");

            migrationBuilder.DropIndex(
                name: "IX_complectations_name",
                table: "complectations");

            migrationBuilder.AlterColumn<string>(
                name: "vehicle_model",
                table: "complectations",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(32)",
                oldMaxLength: 32,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "truck_or_van",
                table: "complectations",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(32)",
                oldMaxLength: 32,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "transmission_model",
                table: "complectations",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(32)",
                oldMaxLength: 32,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "top_back_door",
                table: "complectations",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(32)",
                oldMaxLength: 32,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "side_window",
                table: "complectations",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(32)",
                oldMaxLength: 32,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "seating_capacity",
                table: "complectations",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(32)",
                oldMaxLength: 32,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "seat_type",
                table: "complectations",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(32)",
                oldMaxLength: 32,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "roof",
                table: "complectations",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(32)",
                oldMaxLength: 32,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "rollbar",
                table: "complectations",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(32)",
                oldMaxLength: 32,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "rear_tire",
                table: "complectations",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(32)",
                oldMaxLength: 32,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "rear_suspention",
                table: "complectations",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(32)",
                oldMaxLength: 32,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "product",
                table: "complectations",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(32)",
                oldMaxLength: 32,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "no_of_doors",
                table: "complectations",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(32)",
                oldMaxLength: 32,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "complectations",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(32)",
                oldMaxLength: 32);

            migrationBuilder.AlterColumn<string>(
                name: "model_mark",
                table: "complectations",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(32)",
                oldMaxLength: 32,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "loading_capacity",
                table: "complectations",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(32)",
                oldMaxLength: 32,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "incomplete_vehicles",
                table: "complectations",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(32)",
                oldMaxLength: 32,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "grade_mark",
                table: "complectations",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(32)",
                oldMaxLength: 32,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "grade",
                table: "complectations",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(32)",
                oldMaxLength: 32,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "gear_shift_type",
                table: "complectations",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(32)",
                oldMaxLength: 32,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "fuel_induction",
                table: "complectations",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(32)",
                oldMaxLength: 32,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "engine_2",
                table: "complectations",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(32)",
                oldMaxLength: 32,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "engine_1",
                table: "complectations",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(32)",
                oldMaxLength: 32,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "emission_regulation",
                table: "complectations",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(32)",
                oldMaxLength: 32,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "drivers_position",
                table: "complectations",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(32)",
                oldMaxLength: 32,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "destination_2",
                table: "complectations",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(32)",
                oldMaxLength: 32,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "destination_1",
                table: "complectations",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(32)",
                oldMaxLength: 32,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "destination",
                table: "complectations",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(32)",
                oldMaxLength: 32,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "deck_material",
                table: "complectations",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(32)",
                oldMaxLength: 32,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "deck_cab",
                table: "complectations",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(32)",
                oldMaxLength: 32,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "deck",
                table: "complectations",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(32)",
                oldMaxLength: 32,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "cooler",
                table: "complectations",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(32)",
                oldMaxLength: 32,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "category",
                table: "complectations",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(32)",
                oldMaxLength: 32,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "cab",
                table: "complectations",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(32)",
                oldMaxLength: 32,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "building_condition",
                table: "complectations",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(32)",
                oldMaxLength: 32,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "body_2",
                table: "complectations",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(32)",
                oldMaxLength: 32,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "body_1",
                table: "complectations",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(32)",
                oldMaxLength: 32,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "body",
                table: "complectations",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(32)",
                oldMaxLength: 32,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "back_door",
                table: "complectations",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(32)",
                oldMaxLength: 32,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "atm_mtm",
                table: "complectations",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(32)",
                oldMaxLength: 32,
                oldDefaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_parts_sub_groups_name",
                table: "parts_sub_groups",
                column: "name");

            migrationBuilder.CreateIndex(
                name: "IX_parts_groups_name",
                table: "parts_groups",
                column: "name");

            migrationBuilder.CreateIndex(
                name: "IX_parts_name",
                table: "parts",
                column: "name");

            migrationBuilder.CreateIndex(
                name: "IX_parts_name_tree_code_code",
                table: "parts",
                columns: new[] { "name", "tree_code", "code" });

            migrationBuilder.CreateIndex(
                name: "IX_models_name_code",
                table: "models",
                columns: new[] { "name", "code" });

            migrationBuilder.CreateIndex(
                name: "IX_manufacturers_name",
                table: "manufacturers",
                column: "name");

            migrationBuilder.CreateIndex(
                name: "IX_complectations_name",
                table: "complectations",
                column: "name");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_parts_sub_groups_name",
                table: "parts_sub_groups");

            migrationBuilder.DropIndex(
                name: "IX_parts_groups_name",
                table: "parts_groups");

            migrationBuilder.DropIndex(
                name: "IX_parts_name",
                table: "parts");

            migrationBuilder.DropIndex(
                name: "IX_parts_name_tree_code_code",
                table: "parts");

            migrationBuilder.DropIndex(
                name: "IX_models_name_code",
                table: "models");

            migrationBuilder.DropIndex(
                name: "IX_manufacturers_name",
                table: "manufacturers");

            migrationBuilder.DropIndex(
                name: "IX_complectations_name",
                table: "complectations");

            migrationBuilder.AlterColumn<string>(
                name: "vehicle_model",
                table: "complectations",
                type: "nvarchar(32)",
                maxLength: 32,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "truck_or_van",
                table: "complectations",
                type: "nvarchar(32)",
                maxLength: 32,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "transmission_model",
                table: "complectations",
                type: "nvarchar(32)",
                maxLength: 32,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "top_back_door",
                table: "complectations",
                type: "nvarchar(32)",
                maxLength: 32,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "side_window",
                table: "complectations",
                type: "nvarchar(32)",
                maxLength: 32,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "seating_capacity",
                table: "complectations",
                type: "nvarchar(32)",
                maxLength: 32,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "seat_type",
                table: "complectations",
                type: "nvarchar(32)",
                maxLength: 32,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "roof",
                table: "complectations",
                type: "nvarchar(32)",
                maxLength: 32,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "rollbar",
                table: "complectations",
                type: "nvarchar(32)",
                maxLength: 32,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "rear_tire",
                table: "complectations",
                type: "nvarchar(32)",
                maxLength: 32,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "rear_suspention",
                table: "complectations",
                type: "nvarchar(32)",
                maxLength: 32,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "product",
                table: "complectations",
                type: "nvarchar(32)",
                maxLength: 32,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "no_of_doors",
                table: "complectations",
                type: "nvarchar(32)",
                maxLength: 32,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "complectations",
                type: "nvarchar(32)",
                maxLength: 32,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "model_mark",
                table: "complectations",
                type: "nvarchar(32)",
                maxLength: 32,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "loading_capacity",
                table: "complectations",
                type: "nvarchar(32)",
                maxLength: 32,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "incomplete_vehicles",
                table: "complectations",
                type: "nvarchar(32)",
                maxLength: 32,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "grade_mark",
                table: "complectations",
                type: "nvarchar(32)",
                maxLength: 32,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "grade",
                table: "complectations",
                type: "nvarchar(32)",
                maxLength: 32,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "gear_shift_type",
                table: "complectations",
                type: "nvarchar(32)",
                maxLength: 32,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "fuel_induction",
                table: "complectations",
                type: "nvarchar(32)",
                maxLength: 32,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "engine_2",
                table: "complectations",
                type: "nvarchar(32)",
                maxLength: 32,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "engine_1",
                table: "complectations",
                type: "nvarchar(32)",
                maxLength: 32,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "emission_regulation",
                table: "complectations",
                type: "nvarchar(32)",
                maxLength: 32,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "drivers_position",
                table: "complectations",
                type: "nvarchar(32)",
                maxLength: 32,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "destination_2",
                table: "complectations",
                type: "nvarchar(32)",
                maxLength: 32,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "destination_1",
                table: "complectations",
                type: "nvarchar(32)",
                maxLength: 32,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "destination",
                table: "complectations",
                type: "nvarchar(32)",
                maxLength: 32,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "deck_material",
                table: "complectations",
                type: "nvarchar(32)",
                maxLength: 32,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "deck_cab",
                table: "complectations",
                type: "nvarchar(32)",
                maxLength: 32,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "deck",
                table: "complectations",
                type: "nvarchar(32)",
                maxLength: 32,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "cooler",
                table: "complectations",
                type: "nvarchar(32)",
                maxLength: 32,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "category",
                table: "complectations",
                type: "nvarchar(32)",
                maxLength: 32,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "cab",
                table: "complectations",
                type: "nvarchar(32)",
                maxLength: 32,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "building_condition",
                table: "complectations",
                type: "nvarchar(32)",
                maxLength: 32,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "body_2",
                table: "complectations",
                type: "nvarchar(32)",
                maxLength: 32,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "body_1",
                table: "complectations",
                type: "nvarchar(32)",
                maxLength: 32,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "body",
                table: "complectations",
                type: "nvarchar(32)",
                maxLength: 32,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "back_door",
                table: "complectations",
                type: "nvarchar(32)",
                maxLength: 32,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "atm_mtm",
                table: "complectations",
                type: "nvarchar(32)",
                maxLength: 32,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128,
                oldDefaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_parts_sub_groups_name",
                table: "parts_sub_groups",
                column: "name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_parts_groups_name",
                table: "parts_groups",
                column: "name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_parts_name",
                table: "parts",
                column: "name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_parts_name_tree_code_code",
                table: "parts",
                columns: new[] { "name", "tree_code", "code" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_models_name_code",
                table: "models",
                columns: new[] { "name", "code" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_manufacturers_name",
                table: "manufacturers",
                column: "name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_complectations_name",
                table: "complectations",
                column: "name",
                unique: true);
        }
    }
}
