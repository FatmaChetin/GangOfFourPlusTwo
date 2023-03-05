using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Options
{
    public class CustomerMap:BaseMap<Customer>
    {
        public CustomerMap()
        {
            ToTable("Müşteriler");
            Property(x => x.CompanyName).HasColumnName("Şirket Adı");
            Property(x => x.CompanySector).HasColumnName("Şirket Sektörü");
            Property(x => x.ContactNumber).HasColumnName("Telefon Numarası");
            Property(x => x.CompanyAdress).HasColumnName("Şirket Adresi");
            Property(x=> x.Email).HasColumnName("E-mail adresi");

        }
    }
}
