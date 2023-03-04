using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Options
{
    public class EmployeeMap:BaseMap<Employee>
    {
        public EmployeeMap()
        {
            ToTable("Çalışanlar");
            Property(x=> x.UserName).HasColumnName("Kullanıcı Adı");
            Property(x=> x.Password).HasColumnName("Şifre");
            HasOptional(x => x.Profile).WithRequired(x => x.Employee);
        }

     
    }
}
