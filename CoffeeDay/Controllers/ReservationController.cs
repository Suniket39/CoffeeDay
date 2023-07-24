using CoffeeDay.Data;
using LibraryManagement.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagement.Controllers
{
    public class ReservationController : Controller
    {
        private readonly ApplicationDbContext _db;

        public ReservationController(ApplicationDbContext db)
        {
            _db = db;
        }

        public ActionResult Reservation()
        {
            var objReservationList = _db.Reservations.ToList();
            return View();
        }

        public ActionResult ViewReservations()
        {
            IEnumerable<ReservationModel> allReservations = _db.Reservations;
            return View(allReservations);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Reservation(ReservationModel reservObj)
        {
            if (ModelState.IsValid)
            {
                _db.Reservations.Add(reservObj);
                _db.SaveChanges();
                return View();
            }
            return View(reservObj);
        }

        public IActionResult EditReservation(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var reserFromDb = _db.Reservations.Find(id);
            if (reserFromDb == null)
            {
                return NotFound();
            }
            return View(reserFromDb);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditReservation(ReservationModel reservObj)
        {
            if (ModelState.IsValid)
            {
                _db.Reservations.Update(reservObj);
                _db.SaveChanges();
            }
            return RedirectToAction("ViewReservations");
        }

        public IActionResult DeleteReservation(int? id)
        {
            if(id == null || id == 0)
            {
                return NotFound();
            }
            var reservFromDb = _db.Reservations.Find(id);
            if(reservFromDb == null)
            {
                return NotFound();
            }
            return View(reservFromDb);
        }

        [HttpPost]

        public IActionResult DeleteReservation(ReservationModel reservObj)
        {
            _db.Reservations.Remove(reservObj);
            _db.SaveChanges();
            return RedirectToAction("ViewReservations");
        }
    }
}
