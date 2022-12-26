using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class ComplectationTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "driver_position",
                table: "complectations");

            migrationBuilder.DropColumn(
                name: "engine",
                table: "complectations");

            migrationBuilder.DropColumn(
                name: "transmission",
                table: "complectations");

            migrationBuilder.AlterColumn<string>(
                name: "grade",
                table: "complectations",
                type: "nvarchar(16)",
                maxLength: 16,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(8)",
                oldMaxLength: 8,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "gear_shift_type",
                table: "complectations",
                type: "nvarchar(16)",
                maxLength: 16,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(8)",
                oldMaxLength: 8,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "fuel_induction",
                table: "complectations",
                type: "nvarchar(16)",
                maxLength: 16,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(8)",
                oldMaxLength: 8,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "destination",
                table: "complectations",
                type: "nvarchar(16)",
                maxLength: 16,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(8)",
                oldMaxLength: 8,
                oldDefaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "atm_mtm",
                table: "complectations",
                type: "nvarchar(16)",
                maxLength: 16,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "back_door",
                table: "complectations",
                type: "nvarchar(16)",
                maxLength: 16,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "body",
                table: "complectations",
                type: "nvarchar(16)",
                maxLength: 16,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "body_1",
                table: "complectations",
                type: "nvarchar(16)",
                maxLength: 16,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "body_2",
                table: "complectations",
                type: "nvarchar(16)",
                maxLength: 16,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "building_condition",
                table: "complectations",
                type: "nvarchar(16)",
                maxLength: 16,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "cab",
                table: "complectations",
                type: "nvarchar(16)",
                maxLength: 16,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "category",
                table: "complectations",
                type: "nvarchar(16)",
                maxLength: 16,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "cooler",
                table: "complectations",
                type: "nvarchar(16)",
                maxLength: 16,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "deck",
                table: "complectations",
                type: "nvarchar(16)",
                maxLength: 16,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "deck_cab",
                table: "complectations",
                type: "nvarchar(16)",
                maxLength: 16,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "deck_material",
                table: "complectations",
                type: "nvarchar(16)",
                maxLength: 16,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "destination_1",
                table: "complectations",
                type: "nvarchar(16)",
                maxLength: 16,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "destination_2",
                table: "complectations",
                type: "nvarchar(16)",
                maxLength: 16,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "drivers_position",
                table: "complectations",
                type: "nvarchar(16)",
                maxLength: 16,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "emission_regulation",
                table: "complectations",
                type: "nvarchar(16)",
                maxLength: 16,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "engine_1",
                table: "complectations",
                type: "nvarchar(16)",
                maxLength: 16,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "engine_2",
                table: "complectations",
                type: "nvarchar(16)",
                maxLength: 16,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "grade_mark",
                table: "complectations",
                type: "nvarchar(16)",
                maxLength: 16,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "incomplete_vehicles",
                table: "complectations",
                type: "nvarchar(16)",
                maxLength: 16,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "loading_capacity",
                table: "complectations",
                type: "nvarchar(16)",
                maxLength: 16,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "model_mark",
                table: "complectations",
                type: "nvarchar(16)",
                maxLength: 16,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "no_of_doors",
                table: "complectations",
                type: "nvarchar(16)",
                maxLength: 16,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "product",
                table: "complectations",
                type: "nvarchar(16)",
                maxLength: 16,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "rear_suspention",
                table: "complectations",
                type: "nvarchar(16)",
                maxLength: 16,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "rear_tire",
                table: "complectations",
                type: "nvarchar(16)",
                maxLength: 16,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "rollbar",
                table: "complectations",
                type: "nvarchar(16)",
                maxLength: 16,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "roof",
                table: "complectations",
                type: "nvarchar(16)",
                maxLength: 16,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "seat_type",
                table: "complectations",
                type: "nvarchar(16)",
                maxLength: 16,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "seating_capacity",
                table: "complectations",
                type: "nvarchar(16)",
                maxLength: 16,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "side_window",
                table: "complectations",
                type: "nvarchar(16)",
                maxLength: 16,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "top_back_door",
                table: "complectations",
                type: "nvarchar(16)",
                maxLength: 16,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "transmission_model",
                table: "complectations",
                type: "nvarchar(16)",
                maxLength: 16,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "truck_or_van",
                table: "complectations",
                type: "nvarchar(16)",
                maxLength: 16,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "vehicle_model",
                table: "complectations",
                type: "nvarchar(16)",
                maxLength: 16,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "atm_mtm",
                table: "complectations");

            migrationBuilder.DropColumn(
                name: "back_door",
                table: "complectations");

            migrationBuilder.DropColumn(
                name: "body",
                table: "complectations");

            migrationBuilder.DropColumn(
                name: "body_1",
                table: "complectations");

            migrationBuilder.DropColumn(
                name: "body_2",
                table: "complectations");

            migrationBuilder.DropColumn(
                name: "building_condition",
                table: "complectations");

            migrationBuilder.DropColumn(
                name: "cab",
                table: "complectations");

            migrationBuilder.DropColumn(
                name: "category",
                table: "complectations");

            migrationBuilder.DropColumn(
                name: "cooler",
                table: "complectations");

            migrationBuilder.DropColumn(
                name: "deck",
                table: "complectations");

            migrationBuilder.DropColumn(
                name: "deck_cab",
                table: "complectations");

            migrationBuilder.DropColumn(
                name: "deck_material",
                table: "complectations");

            migrationBuilder.DropColumn(
                name: "destination_1",
                table: "complectations");

            migrationBuilder.DropColumn(
                name: "destination_2",
                table: "complectations");

            migrationBuilder.DropColumn(
                name: "drivers_position",
                table: "complectations");

            migrationBuilder.DropColumn(
                name: "emission_regulation",
                table: "complectations");

            migrationBuilder.DropColumn(
                name: "engine_1",
                table: "complectations");

            migrationBuilder.DropColumn(
                name: "engine_2",
                table: "complectations");

            migrationBuilder.DropColumn(
                name: "grade_mark",
                table: "complectations");

            migrationBuilder.DropColumn(
                name: "incomplete_vehicles",
                table: "complectations");

            migrationBuilder.DropColumn(
                name: "loading_capacity",
                table: "complectations");

            migrationBuilder.DropColumn(
                name: "model_mark",
                table: "complectations");

            migrationBuilder.DropColumn(
                name: "no_of_doors",
                table: "complectations");

            migrationBuilder.DropColumn(
                name: "product",
                table: "complectations");

            migrationBuilder.DropColumn(
                name: "rear_suspention",
                table: "complectations");

            migrationBuilder.DropColumn(
                name: "rear_tire",
                table: "complectations");

            migrationBuilder.DropColumn(
                name: "rollbar",
                table: "complectations");

            migrationBuilder.DropColumn(
                name: "roof",
                table: "complectations");

            migrationBuilder.DropColumn(
                name: "seat_type",
                table: "complectations");

            migrationBuilder.DropColumn(
                name: "seating_capacity",
                table: "complectations");

            migrationBuilder.DropColumn(
                name: "side_window",
                table: "complectations");

            migrationBuilder.DropColumn(
                name: "top_back_door",
                table: "complectations");

            migrationBuilder.DropColumn(
                name: "transmission_model",
                table: "complectations");

            migrationBuilder.DropColumn(
                name: "truck_or_van",
                table: "complectations");

            migrationBuilder.DropColumn(
                name: "vehicle_model",
                table: "complectations");

            migrationBuilder.AlterColumn<string>(
                name: "grade",
                table: "complectations",
                type: "nvarchar(8)",
                maxLength: 8,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(16)",
                oldMaxLength: 16,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "gear_shift_type",
                table: "complectations",
                type: "nvarchar(8)",
                maxLength: 8,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(16)",
                oldMaxLength: 16,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "fuel_induction",
                table: "complectations",
                type: "nvarchar(8)",
                maxLength: 8,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(16)",
                oldMaxLength: 16,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "destination",
                table: "complectations",
                type: "nvarchar(8)",
                maxLength: 8,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(16)",
                oldMaxLength: 16,
                oldDefaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "driver_position",
                table: "complectations",
                type: "nvarchar(8)",
                maxLength: 8,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "engine",
                table: "complectations",
                type: "nvarchar(8)",
                maxLength: 8,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "transmission",
                table: "complectations",
                type: "nvarchar(8)",
                maxLength: 8,
                nullable: false,
                defaultValue: "");
        }
    }
}
