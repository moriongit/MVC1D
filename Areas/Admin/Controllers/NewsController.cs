using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC1.Context;
using MVC1.Models;
using MVC1.ViewModels.NewsVM;

namespace MVC1.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class NewsController : Controller
    {
        ExamDbContext _dbcontext;

        public NewsController(ExamDbContext dbContext)
        {
            _dbcontext = dbContext;
        }
        public async Task<IActionResult> Index()
        {

            var items = await _dbcontext.News.Select(s => new NewsListItemVM
            {
                Title = s.Title,
                Description = s.Description,
                ImgUrl = s.ImgUrl,
                Author = s.Author,
                Id = s.Id
            }).ToListAsync();
            return View(items);


        }

        public IActionResult Create()
        {

            return View();

        }

        [HttpPost]

        public async Task<IActionResult> Create(NewsListItemVM vm)
        {


            if (!ModelState.IsValid)
            {
                return View(vm);
            }

            NewsDb news = new NewsDb
            {
                Title = vm.Title,
                Description = vm.Description,
                ImgUrl = vm.ImgUrl,
                Author = vm.Author


            };
            await _dbcontext.News.AddAsync(news);
            await _dbcontext.SaveChangesAsync();
            return RedirectToAction("Index");


        }
    }
}
