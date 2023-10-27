using Microsoft.AspNetCore.Mvc;

namespace MvcProje.ViewComponents.Default
{
    public class _Testimonial: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
