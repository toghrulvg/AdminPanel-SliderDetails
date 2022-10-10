using EntityFrameworkProject.Data;
using EntityFrameworkProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EntityFrameworkProject.Areas.AdminArea.Controllers
{
    [Area("AdminArea")]
    public class SliderDetailsController : Controller
    {
        private readonly AppDbContext _context;

        public SliderDetailsController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            IEnumerable<SliderDetail> sliderDetails = await _context.SliderDetails.ToListAsync();
            return View(sliderDetails);
        }
    }
}
