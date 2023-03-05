using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Options
{
    public class ExtraProductMap : BaseMap<ExtraProduct>
    {
        public ExtraProductMap()
        {
            ToTable("Ekstra Ürünler");
            Property(x => x.FoodServiceWorker).HasColumnName("Servis Elemanı");
            Property(x => x.FairHostel).HasColumnName("Fuar Hostesi");
            Property(x => x.StorageArea).HasColumnName("Depolama Alanı");
            Property(x => x.InvititationCard).HasColumnName("Davetiye");
            Property(x => x.Lojistic).HasColumnName("Nakliye");
            Property(X => X.Assembly).HasColumnName("Montaj");
           
        }
    }
}
