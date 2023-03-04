using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class EmployeeProfile:BaseEntity
    {// çalışan kendi profili üzerinden giriş yapabilsin diye bire bir ilişki oluşturduk.
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ContactNumber { get; set; }

        public virtual Employee Employee { get; set; }
    }
}
