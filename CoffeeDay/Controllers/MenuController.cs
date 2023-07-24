using Microsoft.AspNetCore.Mvc;

namespace LibraryManagement.Controllers
{
    public class MenuController : Controller
    {
        public ActionResult Menu()
        {
            return View();
        }
    }
}
