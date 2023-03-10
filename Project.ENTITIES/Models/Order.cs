using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Order:BaseEntity
    {// 1 order n product
     // 1 product 1 order
        public decimal OrderFee { get; set; }// sipariş ücreti
        public string ShippingAdress { get; set; }// gönderim adresi
        public int? CustomerID { get; set; }

        //relational
        public virtual Customer Customer { get; set; }
        public virtual List<Product> Products { get; set; }
    }
}
