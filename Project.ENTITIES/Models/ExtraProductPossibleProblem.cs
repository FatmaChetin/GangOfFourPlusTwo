using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class ExtraProductPossibleProblem:BaseEntity
    {// ekstra productlarla ilgili oluşacak problemleri burada gösterdik
        public int ExtraProductID { get; set; }
        public int PossibleProblemID { get; set; }

        public virtual ExtraProduct ExtraProduct { get; set; }
        public virtual PossibleProblem PossibleProblem { get; set; }
    }
}
