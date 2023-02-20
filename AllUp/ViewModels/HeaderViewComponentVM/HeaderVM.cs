using AllUp.Models;
using AllUp.ViewModels.BasketViewModels;

namespace AllUp.ViewModels.HeaderViewComponentVM
{
    public class HeaderVM
    {
        public IDictionary<string,string> Settings { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public IEnumerable<BasketVM> BasketVMs { get; set; }
    }
}
