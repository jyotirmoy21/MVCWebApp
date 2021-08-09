using System.Collections.Generic;
using mvcwebapp.Models;
using System.Linq;
namespace mvcwebapp.DataAccess
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly EmployeeDBContext _context;

        public DepartmentRepository(EmployeeDBContext context)
        {
            _context = context;
        }
        public List<Department> GetAllDepartment()
        {
            return _context.Departments.ToList();
        }
    }
}