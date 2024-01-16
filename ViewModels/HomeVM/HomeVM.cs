using MVC1.ViewModels.NewsVM;

namespace MVC1.ViewModels.HomeVM
{
    public class HomeVM
    {
        public IEnumerable<NewsListItemVM> News { get; set; }
    }
}
