using MVC6Site.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC6Site.Repositories
{
    public class CellRepository : IRepository<CellViewModel>
    {
        List<CellViewModel> cells = new List<CellViewModel>()
        {
            new CellViewModel() { Name = "W12345", Mcc=234, Mnc=15, Lac = 123, CellId = 12345 }
            ,new CellViewModel() { Name = "W12346", Mcc=234, Mnc=15, Lac = 123, CellId = 12346 }
        };

        public List<CellViewModel> Find()
        {
            return cells;
        }

        public void Insert(CellViewModel viewModel)
        {
            cells.Add(viewModel);
        }
    }
    // lets template
    public interface IRepository<T> 
    {
        List<T> Find();
        void Insert(CellViewModel viewModel);
    }
}
