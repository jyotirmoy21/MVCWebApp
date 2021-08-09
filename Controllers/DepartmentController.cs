using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using mvcwebapp.Models;
using mvcwebapp.DataAccess;

namespace mvcwebapp.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly IDepartmentRepository _deptRepo;
        public DepartmentController(IDepartmentRepository departmentRepo)
        {
            _deptRepo = departmentRepo;
        }
        //EmployeeDBContext dBContext = new EmployeeDBContext();
        public IActionResult Index()
        {
            var result = _deptRepo.GetAllDepartment();
            return View(result);
        }
    }
}