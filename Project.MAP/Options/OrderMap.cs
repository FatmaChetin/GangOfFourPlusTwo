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
        {// daha önce unitprice yazdığımız kısmı entitieste değiştirdiğimiz için burda da düzelttim.
            ToTable("Siparişler");
            Property(x => x.OrderFee).HasParameterName("Ürün Fiyatı");
            Property(x=> x.ShippingAdress).HasColumnName("Gönderim Adresi");
        }
    }
}
