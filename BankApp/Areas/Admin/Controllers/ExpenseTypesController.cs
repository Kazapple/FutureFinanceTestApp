using DAL.Data;
using BankApp.Models;
using BLL;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ExpenseTypesController : Controller
    {
        private ApplicationDbContext _db;

        public ExpenseTypesController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View(_db.ExpenseTypes.ToList());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ExpenseTypeDM expenseTypes)
        {
            if (ModelState.IsValid)
            {
                _db.ExpenseTypes.Add(expenseTypes);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View();
        }

        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var expenseType = _db.ExpenseTypes.Find(id);
            if (expenseType == null)
            {
                return NotFound();
            }
            return View(expenseType);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(ExpenseTypeDM expenseTypes)
        {
            if (ModelState.IsValid)
            {
                _db.Update(expenseTypes);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View();
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var expenseType = _db.ExpenseTypes.Find(id);
            if (expenseType == null)
            {
                return NotFound();
            }
            return View(expenseType);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Details(ExpenseTypeDM expenseTypes)
        {
                return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var expenseType = _db.ExpenseTypes.Find(id);
            if (expenseType == null)
            {
                return NotFound();
            }
            return View(expenseType);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int? id,ExpenseTypeDM expenseTypes)
        {
            if(id == null)
            {
                return NotFound();
            }
            if(id != expenseTypes.Id)
            {
                return NotFound();
            }
            var expenseType = _db.ExpenseTypes.Find(id);
            if(expenseType == null)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                _db.Remove(expenseType);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View();
        }

        public IActionResult Calc(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var expenseType = _db.ExpenseTypes.Find(id);
            if (expenseType == null)
            {
                return NotFound();
            }
            return View(expenseType);
        }

/*        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Calc(ExpenseTypeDM expenseTypes)
        {
            if (ModelState.IsValid)
            {
                _db.Update(expenseTypes);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View();
        }*/
    }
}
