using Microsoft.AspNetCore.Mvc;

namespace FlightBooking.Areas.Admin.Components
{
    public class _AdminTopbarComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
