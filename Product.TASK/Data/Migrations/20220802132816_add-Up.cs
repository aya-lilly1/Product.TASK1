using Microsoft.EntityFrameworkCore.Migrations;

namespace Product.TASK.Data.Migrations
{
    public partial class addUp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "DepartmentId",
                table: "products",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdDepartment",
                table: "products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdEmployee",
                table: "Departments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_products_DepartmentId",
                table: "products",
                column: "DepartmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_products_Departments_DepartmentId",
                table: "products",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_products_Departments_DepartmentId",
                table: "products");

            migrationBuilder.DropIndex(
                name: "IX_products_DepartmentId",
                table: "products");

            migrationBuilder.DropColumn(
                name: "DepartmentId",
                table: "products");

            migrationBuilder.DropColumn(
                name: "IdDepartment",
                table: "products");

            migrationBuilder.DropColumn(
                name: "IdEmployee",
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
    }
}
