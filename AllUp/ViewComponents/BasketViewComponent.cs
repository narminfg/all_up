using AllUp.DataAccessLayer;
using Microsoft.AspNetCore.Mvc;

namespace AllUp.ViewComponents
{
    public class BasketViewComponent: ViewComponent
    {
        private readonly AppDbContext _context;
        public BasketViewComponent(AppDbContext context)
        {
            _context = context;
        }
        public async Task <IViewComponentResult>InvokeAsync()
        {
            return View();
        }
    }
}
