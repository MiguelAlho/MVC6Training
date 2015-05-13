using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVC6Site.Models
{
    public class CellViewModel
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public int Mcc { get; set; }

        [Required]
        public int Mnc { get; set; }

        [Required]
        public int Lac { get; set; }

        [Required]
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
