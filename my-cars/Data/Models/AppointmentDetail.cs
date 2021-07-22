using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace my_cars.Data.Models
{
    public class AppointmentDetail
    {
        public int Id { get; set; }
        public DateTime AppDate { get; set; }
        public DateTime AppTime { get; set; }
        public string Postpone { get; set; }
        public DateTime FinishDate { get; set; }
        public DateTime ConfirmDate { get; set; }
        public DateTime CancelDate { get; set; }
        public string ReasonDesc { get; set; }
        public string FlagActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifyDate { get; set; }
        public string Status { get; set; }
        public string Description { get; set; }

        // Navigation Properties
        public int AppointmentId { get; set; }
        public Appointment Appointment { get; set; }

        public int? EmployeeId { get; set; }
        public Employee Employee { get; set; }

        public int ReasonId { get; set; }
        public Reason Reason { get; set; }

    }
}
