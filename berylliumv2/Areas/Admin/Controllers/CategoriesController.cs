using Ali.Helpers;
using berylliumv2.DAL;
using berylliumv2.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace berylliumv2.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoriesController : Controller
    {

        private readonly AppDbContext db;
        private readonly IWebHostEnvironment env;
        public CategoriesController(AppDbContext _db, IWebHostEnvironment _env)
        {
            db = _db;
            env = _env;
        }

        public async Task<IActionResult> Index()
        {
            List<Work> works = await db.Works.ToListAsync();
            return View(works);
        }
        public async Task<IActionResult> Delete(int id)
        {
            Work work = await db.Works.FirstOrDefaultAsync(x => x.Id == id);
            if (work == null) return NotFound();

            return View(work);
        }
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            Work work = await db.Works.FindAsync(id);
            string path = env.WebRootPath + @"\images";
            string filename = work.Path;
            string final = Path.Combine(path, filename);

            System.IO.File.Delete(final);

            if (work == null) return NotFound();
            db.Works.Remove(work);
            await db.SaveChangesAsync();

            return RedirectToAction("Index");
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Work work)
        {
            if (!ModelState.IsValid)
            {
                return Content("sehvvvv");
            }
            if (!work.Img.IsImage())
            {
                ModelState.AddModelError("Img", "File is not IMAGE");
                return View();
            }
            if (work.Img.IsSmallerThan(5000))
            {
                ModelState.AddModelError("Img", "File is BIG");
                return View();
            }

            string path = env.WebRootPath + @"\images";
            work.Path = await work.Img.Upload(path);

            db.Add(work);
            await db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Edit(int id)
        {
            Work work = await db.Works.FirstOrDefaultAsync(x => x.Id == id);
            if (work == null) return RedirectToAction("Index");
            return View(work);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, Work work)
        {
            if (!CategoryExists(work.Id)) return View(work);

            if (work.Img != null)
            {
                if (!work.Img.IsImage() || work.Img.IsSmallerThan(400))
                {
                    ModelState.AddModelError("Img", " File is not valid."); return View();
                }
                string path = env.WebRootPath + @"\images";

                if (System.IO.File.Exists(Path.Combine(path, work.Path)))
                {
                    System.IO.File.Delete(Path.Combine(path, work.Path));
                }
                work.Path = await work.Img.Upload(path);
            }

            db.Works.Update(work);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        private bool CategoryExists(int id)
        {
            return db.Works.Any(x => x.Id == id);
        }
    }
}
