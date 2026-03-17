using Microsoft.AspNetCore.Mvc;

namespace FlightBooking.ViewComponents.DefaultViewComponents
{
    public class _DefaultBookingComponentPartial:ViewComponent      
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
