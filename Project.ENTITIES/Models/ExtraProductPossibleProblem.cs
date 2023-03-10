using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class ExtraProductPossibleProblem:BaseEntity
    {// ekstra productlarla ilgili oluşacak problemleri burada gösterdik 
        // 1 ekstra product n possible problems
        // 1 possible problems n extra product
        public int ExtraProductID { get; set; }
        public int PossibleProblemID { get; set; }

        //relational
        public virtual ExtraProduct ExtraProduct { get; set; }
        public virtual PossibleProblem PossibleProblem { get; set; }
    }
}
