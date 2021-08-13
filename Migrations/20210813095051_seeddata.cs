using Microsoft.EntityFrameworkCore.Migrations;

namespace mvcwebapp.Migrations
{
    public partial class seeddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Insert into Departments (DepartmentName) VALUES('Claimx')");
            migrationBuilder.Sql("Insert into Departments (DepartmentName) VALUES('Gouri')");
            migrationBuilder.Sql("Insert into Departments (DepartmentName) VALUES('Testing')");
            migrationBuilder.Sql("Insert into Employees (Name ,Age,DepartmentId) VALUES('Jyoti',40,(select DepartmentId from Departments where departmentname ='Claimx'))");
            migrationBuilder.Sql("Insert into Employees (Name ,Age,DepartmentId) VALUES('Shrila',28,(select DepartmentId from Departments where departmentname ='Claimx'))");
            migrationBuilder.Sql("Insert into Employees (Name ,Age,DepartmentId) VALUES('Jayanta',38,(select DepartmentId from Departments where departmentname ='Gouri'))");
            migrationBuilder.Sql("Insert into Employees (Name ,Age,DepartmentId) VALUES('SG',50,(select DepartmentId from Departments where departmentname ='Testing'))");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Delete from Departments");
            migrationBuilder.Sql("Delete from Employees");
        }
    }
}
