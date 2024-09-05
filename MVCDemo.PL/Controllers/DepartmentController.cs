using Microsoft.AspNetCore.Mvc;
using MVCDemo.BLL.Interfaces;
using MVCDemo.BLL.Repositories;

namespace MVCDemo.PL.Controllers
{
    public class DepartmentController : Controller
    {
        // DepartmentController is a Controller 
        // DepartmentController has a DepartmentRepository ==> Association ==> Composition  
        // private DepartmentRepository _departmetRepository; عشان ده ميكونش ب null  
        private readonly IDepartmentRepository _departmentRepository;
        public DepartmentController(IDepartmentRepository departmentRepository)
        {
            _departmentRepository = departmentRepository;
        }

        public IActionResult Index() // GetAll
        {
           _departmentRepository.GetAll();
            return View();
        }
    }
}
