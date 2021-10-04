using Microsoft.AspNetCore.Mvc;
using DoAn.Data;
using DoAn.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DoAn.Controllers
{
    public class StatusControllers : Controller
    {
        private readonly ApplicationDbContext _appDbContext;
        public StatusControllers(ApplicationDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IActionResult Index()
        {
            IEnumerable<Status> categories = _appDbContext.Statuses.Include(p => p.TravelModels);

            return View(categories);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Status category)
        {
            if (ModelState.IsValid)
            {
                _appDbContext.Statuses.Add(category);
                _appDbContext.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(category);
        }

        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var category = _appDbContext.Statuses.Find(id);
            if (category == null) return NotFound();

            return View(category);
        }

        [HttpPost]
        public IActionResult Edit(Status category)
        {
            if (ModelState.IsValid)
            {
                _appDbContext.Statuses.Update(category);
                _appDbContext.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(category);

        }

        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var category = _appDbContext.Statuses.Find(id);
            if (category == null) return NotFound();

            return View(category);
        }

        [HttpPost]
        public IActionResult DeleteCategory(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var category = _appDbContext.Statuses.Find(id);
            if (category == null) return NotFound();

            _appDbContext.Statuses.Remove(category);
            _appDbContext.SaveChanges();

            return RedirectToAction("Index");

        }
    }
}
