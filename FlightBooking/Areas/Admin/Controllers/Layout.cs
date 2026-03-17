using Microsoft.AspNetCore.Mvc;

namespace FlightBooking.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class Layout : Controller
    {
        public IActionResult AdminLayout()
        {
            return View();
        }
    }
}
