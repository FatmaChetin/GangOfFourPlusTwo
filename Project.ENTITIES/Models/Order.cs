using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Order:BaseEntity
    {
        public decimal OrderFee { get; set; }
        public string ShippingAdress { get; set; }
        public int? CustomerID { get; set; }


        public virtual Customer Customer { get; set; }
        public virtual List<Product> Products { get; set; }
    }
}
