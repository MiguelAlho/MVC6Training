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
        [RegularExpression(@"[A-Z][0-9]{5}", ErrorMessage = "Invalid Name format")]
        public string Name { get; set; }

        [Required]
        [Range(1, 255, ErrorMessage = "Mcc must be within the 8 bit range")]
        public int Mcc { get; set; }

        [Required]
        [Range(1, 255, ErrorMessage = "Mnc id must be within the 8 bit range")]
        public int Mnc { get; set; }

        [Required]
        [Range(1, 65535, ErrorMessage = "Lac must be within the 16 bit range")]
        public int Lac { get; set; }

        [Required]
        [Range(1, 65535, ErrorMessage = "Cell id must be within the 16 bit range")]
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
