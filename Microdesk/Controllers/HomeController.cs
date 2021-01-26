using Microdesk.BusinessLogic;
using Microdesk.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Microdesk.Controllers
{
    public class HomeController : Controller
    {
        private IStudentRepository _studentRepository;

        // Inject IStudentRepository using Constructor Injection 
        public HomeController(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

     
        public IActionResult Index()
        {
            return View();
            
        }

        // Retrieve student name and return
        public string StudentName()
        {
            return _studentRepository.GetStudent(1).Name;
        }
    }
}
