using Microsoft.AspNetCore.Mvc;

namespace MvcProje.ViewComponents.Comment
{
    public class _AddComment:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
