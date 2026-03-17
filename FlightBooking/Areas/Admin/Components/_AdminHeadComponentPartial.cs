
using Microsoft.AspNetCore.Mvc;

namespace FlightBooking.Areas.Admin.Components
{
    public class _AdminHeadComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
