using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace MVC1.ViewModels
{
    public class NewsListItemVM
    {
        [MaxLength(60), NotNull, MinLength(5)]
        public string Title { get; set; }
        [Required]
        [MaxLength(128), NotNull, MinLength(5)]
        public string Description { get; set; }
        [Required]
        [MaxLength(32), NotNull, MinLength(5)]
        public string Author { get; set; }


        public string ImgUrl { get; set; }


    }
}
