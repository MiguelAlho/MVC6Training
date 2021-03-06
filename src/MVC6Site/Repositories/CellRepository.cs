﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVC6Site.Models;

namespace MVC6Site.Repositories
{
    public class InMemoryCellRepository : IRepository<CellViewModel>
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

        public CellViewModel FindById(object id)
        {
            string name = (string)id;
            return cells.FirstOrDefault(o => o.Name == name);
        }

        public void Update(CellViewModel editedModel)
        {
            string name = editedModel.Name;
            int index = cells.FindIndex(o => o.Name == name);
            cells[index] = editedModel;
        }

        public void Insert(CellViewModel viewModel)
        {
            cells.Add(viewModel);
        }
    }

    public interface IRepository<T>
    {
        List<T> Find();
        T FindById(object id);
        void Update(T editedModel);
        void Insert(T insertModel);
    }
}
