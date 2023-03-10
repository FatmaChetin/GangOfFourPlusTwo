using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class ProductPossibleProblem:BaseEntity   
    {
        // product possible problem junction tablelarımızı burada burada birleştirdik.
        public int ProductID { get; set; }
        public int PossibleProblemID { get; set; }

        //relational
        public virtual Product Product { get; set; }
        public virtual PossibleProblem PossibleProblem { get; set; }
    }
}
