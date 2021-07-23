using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace my_cars.Data.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Tel { get; set; }
        public string Address { get; set; }
        public string Position { get; set; }
        public string FlagActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifyDate { get; set; }
        public string Status { get; set; }

        // Navigation Properties
        public int TitleId { get; set; }
        public int GarageId { get; set; }
    }
}
