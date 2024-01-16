using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC1.Context;
using MVC1.Models;
using MVC1.ViewModels;
using MVC1.ViewModels.HomeVM;
using MVC1.ViewModels.NewsVM;
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

        public async Task<IActionResult> Index()
        {
            HomeVM vm = new HomeVM
            {
                News = await _dbcontext.News.Select(s => new NewsListItemVM
                {
                    Title = s.Title,
                    Description = s.Description,    
                    ImgUrl = s.ImgUrl,
                    Author = s.Author,
                }).ToListAsync(),
               
            };
            return View(vm);
        }
    }

}
