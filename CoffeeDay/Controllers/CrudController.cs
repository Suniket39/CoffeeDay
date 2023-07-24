using Microsoft.AspNetCore.Mvc;
using LibraryManagement.Models;
using System.Data;
using System.Data.SqlClient;

namespace LibraryManagement.Controllers
{
    public class CrudController : Controller
    {
        public IActionResult ViewBookings()
        {
            return View();
        }
    }
    //[HttpPost]
    //public ActionResult ViewBookings(string )
    //{


     //   return View();
    //}
}
