using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Customer:BaseEntity
    {
        public string CompanyName { get; set; }
        public string CompanySector { get; set; }
        public string ContactNumber { get; set; }
        public string Email { get; set; }
        public int? EmployeeID { get; set; }
        

        //Relational Properties

        public virtual Employee Employee { get; set; }
        public virtual List<Order> Orders { get; set; }


    }
}
