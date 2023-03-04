using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Product:BaseEntity
    {
        public double Square { get; set; }
        public string ModulerStand { get; set; }
        public string CustomStand { get; set; }

        public virtual List<ProductDetail> ProductDetails { get; set; }
        public virtual List<ProductPossibleProblem> ProductPossibleProblems { get; set; }

    }
}
