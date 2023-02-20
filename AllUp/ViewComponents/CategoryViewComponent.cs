using AllUp.DataAccessLayer;
using AllUp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AllUp.ViewComponents
{
    public class CategoryViewComponent:ViewComponent
    {
        private readonly AppDbContext _context;
        public CategoryViewComponent(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult>InvokeAsync()
        {
            IEnumerable<Category>categories=await _context.Categories.ToListAsync();
            return View(categories);
        }
    }
}
