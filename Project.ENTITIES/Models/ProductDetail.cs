using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class ProductDetail:BaseEntity
    {    
        // Product ve ExtraProduct Tabloları ÇokaÇok oldugundan ProductDetail Junction Tablosu açıldı
        public int ProductID { get; set; }
        public int ExtraProductID { get; set; }

        public virtual Product Product { get; set; }
        public virtual ExtraProduct ExtraProduct { get; set; }
    }
}
