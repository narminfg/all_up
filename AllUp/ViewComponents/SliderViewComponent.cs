using AllUp.DataAccessLayer;
using AllUp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AllUp.ViewComponents
{
    public class SliderViewComponent:ViewComponent
    {
        private readonly AppDbContext _context;
        public SliderViewComponent(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult>InvokeAsync()
        {
            IEnumerable<Slider>sliders= await _context.Sliders.ToListAsync(); 
            return View(sliders);
        }
    }
}
