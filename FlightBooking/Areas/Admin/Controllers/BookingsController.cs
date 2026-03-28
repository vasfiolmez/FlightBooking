using Microsoft.AspNetCore.Mvc;

namespace FlightBooking.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BookingsController : Controller
    {

        public IActionResult BookingList()
        {
            return View();
        }
        public IActionResult AddBooking()
        {
            return View();
        }
    }
}
