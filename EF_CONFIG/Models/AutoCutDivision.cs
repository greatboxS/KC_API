using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CONFIG.Models
{
    public class AutoCutDivision
    {
        [Key]
        public int Id { get; set; }
        public string DivisionName { get; set; }

        public virtual List<Building> Buildings { get; set; }
    }
}
