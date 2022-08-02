using Microsoft.EntityFrameworkCore.Migrations;

namespace Product.TASK.Data.Migrations
{
    public partial class adddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
