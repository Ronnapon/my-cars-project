using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace my_cars.Data.Models
{
    public class CustLogin
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string UserPass { get; set; }
        public string ExpirePass { get; set; }
        public string FlagActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifyDate { get; set; }
        public string Status { get; set; }

        // Navigation Properties
        public int CustomerId { get; set; }
    }
}
