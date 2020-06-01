using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WrenchIt.Models
{
    public class ServiceType
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Hourly Rate")]
        public double Rate { get; set; }
        public string Description { get; set; }
        public Category Category { get; set; }
    }
}
