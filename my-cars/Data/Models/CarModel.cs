using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace my_cars.Data.Models
{
    public class CarModel
    {
        public int Id { get; set; }
        public string ModelCode { get; set; }
        public string BrandCode { get; set;}
        public string ModelName { get; set; }
        public string ModelYear { get; set; }
        public string SubModelName { get; set; }
        public string FlagActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifyDate { get; set; }
        public string Status { get; set; }

        // Navigation Properties
        public int CarBrandId { get; set; }
        public int AdminId { get; set; }
    }
}
