using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC1.Context;
using MVC1.Models;
using System.Diagnostics;

namespace MVC1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ExamDbContext _dbcontext;
        public HomeController(ExamDbContext dbContext)
        {
            dbContext= _dbcontext;
        }
        public IActionResult Index()
        {
            
            return View();
        }
        
    }
}