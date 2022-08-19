using berylliumv2.DAL;
using berylliumv2.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace berylliumv2.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class MessageController : Controller
    {
        private readonly AppDbContext db;
        public MessageController(AppDbContext _db)
        {
            db = _db;
        }

        public IActionResult Index()
        {
            return View(db.Messages.ToList());
        }
        public IActionResult Delete(int id)
        {
            Message message = db.Messages.FirstOrDefault(x => x.Id == id);
            if (message == null)
                return NotFound();
            return View(message);
        }
        public IActionResult Deleteconfirmed(int id)
        {
            Message message = db.Messages.FirstOrDefault(x => x.Id == id);
            if (message == null) return NotFound();
            db.Messages.Remove(message);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
