using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace my_cars.Data.Models
{
    public class Car
    {
        public int Id { get; set; }
        public int LicenseId { get; set; }
        public string Province { get; set; }
        public string FlagActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifyDate { get; set; }
        public string Status { get; set; }

        // Navigation Properties
        public int CarBrandId { get; set; }
        public int CarModelId { get; set; }
        public int CustomerId { get; set; }
    }
}
