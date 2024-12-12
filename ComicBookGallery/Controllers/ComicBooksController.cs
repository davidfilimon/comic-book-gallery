using Microsoft.AspNetCore.Mvc;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {
        public ActionResult Detail()
        {
            if(DateTime.Today.DayOfWeek == DayOfWeek.Thursday)
            {
                return new RedirectResult("/");
            }
            return new ContentResult()
            {
                Content = "Hello from Content Result"
            };
        }
    }
}
