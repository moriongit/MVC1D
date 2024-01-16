using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace MVC1.ViewModels.NewsVM
{
    public class NewsListItemVM
    {
        public int Id { get; set; }
        public string Title { get; set; }
       
        public string Description { get; set; }
       
        public string Author { get; set; }


        public string ImgUrl { get; set; }


    }
}
