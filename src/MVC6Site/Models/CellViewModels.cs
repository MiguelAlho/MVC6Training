using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC6Site.Models
{
    public class CellViewModel
    {
        public string Name { get; set; }
        public int Mcc { get; set; }
        public int Mnc { get; set; }
        public int Lac { get; set; }
        public int CellId { get; set; }

        public string Cgi
        {
            get
            {
                //return String.Format("{0}-{1}-{2}-{3}", Mcc, Mnc, Lac, CellId);
                return $"{Mcc}-{Mnc}-{Lac}-{CellId}";
            }
        }
    }
}
