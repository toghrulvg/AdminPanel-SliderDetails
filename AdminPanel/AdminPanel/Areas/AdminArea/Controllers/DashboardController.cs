using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AdminPanel.Areas.AdminArea.Controllers
{
    public class DashboardController : Controller
    {
        [Area("AdminArea")]
        public IActionResult Index()
        {
            return View();
        }

    }
}
