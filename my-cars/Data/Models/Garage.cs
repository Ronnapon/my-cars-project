using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace my_cars.Data.Models
{
    public class Garage
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string District { get; set; }
        public string Subdistrict { get; set; }
        public string Province { get; set; }
        public string PostCode { get; set; }
        public string Tel { get; set; }
        public string PackageCode { get; set; }
        public string Mail { get; set; }
        public string TimeAvaliable { get; set; }
        public string FlagActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifyDate { get; set; }
        public string Status { get; set; }
    }
}
