using Microsoft.AspNetCore.Mvc;

namespace MvcProje.ViewComponents.Comment
{
    public class _CommentList:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
