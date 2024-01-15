using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC1.Context;
using MVC1.Models;
using MVC1.ViewModels;
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
        
        public async Task<ActionResult> Index()
        {
            if (ModelState.IsValid)
            {
                var homevm = new HomeVM();
                {
                    Title = model.Title,
                    Description = model.Description,
                    Authors = model.Authors,
                };

                

    }
}