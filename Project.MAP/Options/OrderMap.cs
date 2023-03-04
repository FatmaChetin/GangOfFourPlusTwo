using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Options
{
    public class OrderMap:BaseMap<Order>
    {
        public OrderMap()
        {
            Property(x => x.UnitPrice).HasParameterName("Ürün Fiyatı");
            Property(x=> x.ShippingAdress).HasColumnName("Gönderim Adresi");
        }
    }
}
