using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace my_cars.Data.Models
{
    public class CarBrand
    {
        public int Id { get; set; }
        public string BrandCode { get; set; }
        public string FlagActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifyDate { get; set; }
        public string BrandName { get; set; }
        public string Status { get; set; }

        // Navigation Properties
        public int AdminId { get; set; }
        public Admin admin {get;set;}

        public List<CarModel> carModels { get; set; }
    }
}
