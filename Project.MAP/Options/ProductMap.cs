using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Options
{
    public class ProductMap:BaseMap<Product>
    {
        public ProductMap()
        {
            ToTable("Ürünler");
            Property(x => x.Square).HasColumnName("Alan metrekaresi");
            Property(x => x.ModulerStand).HasColumnName("Modüler Stand");
            Property(x => x.CustomStand).HasColumnName("Özelleştirilmiş Stand");
            Property(X=> X.ProductPrice).HasParameterName("Ürün Fiyatı");
        }
    }
}
