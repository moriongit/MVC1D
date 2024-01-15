using Microsoft.EntityFrameworkCore;
using MVC1.Models;
using System.Reflection;

namespace MVC1.Context
{
    public class ExamDbContext: DbContext
    {
        public DbSet<NewsDb> News { get; set; }
        public ExamDbContext(DbContextOptions<ExamDbContext> options) : base(options)
        {
        }
       
       
      


    }
}

