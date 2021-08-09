
using System;
 
namespace  mvcwebapp.Models
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        
        //Foreign Key for the Department 
       public int DepartmentID { get; set; }
        
       public Department Department { get; set; }
       //https://www.c-sharpcorner.com/article/crud-operation-with-asp-net-core-mvc-using-visual-studio-code-and-ado-net/
    }
}