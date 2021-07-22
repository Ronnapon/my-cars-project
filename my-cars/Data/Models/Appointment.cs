using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace my_cars.Data.Models
{
    public class Appointment
    {
        public int Id { get; set; }
        public string FlagActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifyDate { get; set; }
        public string Status { get; set; }
        public string Description { get; set; }

        //Navigation Properties
        public int CarId { get; set; }
        public Car car { get; set; }

        public int? CustomerId { get; set; }
        public Customer customer { get; set; }

        public int GarageId { get; set; }
        public Garage garage { get; set; }
    }
}
