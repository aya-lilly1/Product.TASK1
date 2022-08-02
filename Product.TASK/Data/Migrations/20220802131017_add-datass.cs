using Microsoft.EntityFrameworkCore.Migrations;

namespace Product.TASK.Data.Migrations
{
    public partial class adddatass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Departments_Departments_departmentId",
                table: "Departments");

            migrationBuilder.DropIndex(
                name: "IX_Departments_departmentId",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "departmentId",
                table: "Departments");

            migrationBuilder.AddColumn<int>(
                name: "departmentId",
                table: "Employees",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Employees_departmentId",
                table: "Employees",
                column: "departmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Departments_departmentId",
                table: "Employees",
                column: "departmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Departments_departmentId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_departmentId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "departmentId",
                table: "Employees");

            migrationBuilder.AddColumn<int>(
                name: "departmentId",
                table: "Departments",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Departments_departmentId",
                table: "Departments",
                column: "departmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_Departments_departmentId",
                table: "Departments",
                column: "departmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
