using Microsoft.AspNetCore.Mvc;

namespace FlightBooking.Areas.Admin.Components
{
    public class _AdminSidebarComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
