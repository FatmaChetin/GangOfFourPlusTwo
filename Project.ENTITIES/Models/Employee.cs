using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Employee:BaseEntity
    { // 1 employee n customer
      // 1 customer 1 employee 
        public string UserName { get; set; }// kullanıcı adı
        public string Password { get; set; }// şifre


        //Relational Properties
        public virtual EmployeeProfile EmployeeProfile { get; set; }

        public virtual List<Customer> Customers { get; set; }
        
    }
}
