using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Customer:BaseEntity
    {// 1 customer n order
    // 1 order 1 customer
        public string CompanyName { get; set; }// şirket adı
        public string CompanySector { get; set; }// sektörü
        public string ContactNumber { get; set; }// iletişim numarası
        public string  CompanyAdress { get; set; }// adres
        public string Email { get; set; }//email
        public int? EmployeeID { get; set; }
        

        //Relational Properties
        public virtual Employee Employee { get; set; }
        public virtual List<Order> Orders { get; set; }


    }
}
