using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using MVC6Site.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace MVC6Site.Controllers
{
    public class CellController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            List<CellViewModel> cells = new List<CellViewModel>()
            {
                new CellViewModel() { Name = "W12345", Mcc=234, Mnc=15, Lac = 123, CellId = 12345 }
                ,new CellViewModel() { Name = "W12346", Mcc=234, Mnc=15, Lac = 123, CellId = 12346 }
            };

            return View(cells);
        }
    }
}
