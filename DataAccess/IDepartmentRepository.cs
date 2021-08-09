using System.Collections.Generic;
using mvcwebapp.Models;

namespace mvcwebapp.DataAccess
{
    public interface IDepartmentRepository
    {
        List<Department> GetAllDepartment();
    }
}