using AllUp.Models;
using AllUp.ViewModels.BasketViewModels;

namespace AllUp.interfaces
{
    public interface ILayoutService
    {
        Task<IDictionary<string, string>> GetSettings();
        Task <IEnumerable<Category>> GetCategories();
        Task <IEnumerable<BasketVM>> GetBaskets();

    }
}
