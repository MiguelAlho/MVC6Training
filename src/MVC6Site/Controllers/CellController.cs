using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using MVC6Site.Models;
using MVC6Site.Repositories;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace MVC6Site.Controllers
{
    public class CellController : Controller
    {
        private IRepository<CellViewModel> cellRepo;

        public CellController(IRepository<CellViewModel> repository)
        {
            cellRepo = repository;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            List<CellViewModel> cells = cellRepo.Find();

            return View(cells);
        }

        public IActionResult Edit(string id)
        {
            var cell = cellRepo.FindById(id);
            return View(cell);
        }

        [HttpPost]
        public IActionResult Edit(string id, CellViewModel cell)
        {
            if (ModelState.IsValid)
            {
                cellRepo.Update(cell);
                return RedirectToAction("Index");
            }
            return View(cell);
        }

        public IActionResult Insert()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Insert(CellViewModel viewModel)
        {
            if(ModelState.IsValid)
            {
                cellRepo.Insert(viewModel);
                return RedirectToAction("Index");
            }
            return View(viewModel);
        }
    }
}
