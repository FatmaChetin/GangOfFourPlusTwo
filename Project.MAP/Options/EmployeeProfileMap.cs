using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Options
{
    public class EmployeeProfileMap:BaseMap<EmployeeProfile>
    {
        public EmployeeProfileMap()
        {
            ToTable("Çalışan Profili");
            Property(x=> x.FirstName).HasColumnName("Adı");
            Property(x => x.LastName).HasColumnName("Soyadı");
            Property(x => x.ContactNumber).HasColumnName("Telefon Numarası");
        }
    }
}
