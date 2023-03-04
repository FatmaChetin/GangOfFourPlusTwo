using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Product:BaseEntity
    {   // Ana ürünler, stand ve alandır. Stand tipi (modüler ve özel yapım) ve kiralanacak alan (m2 cinsinden) fiyatlandırılacaktır. 
        public decimal ProductPrice { get; set; }
        public double Square { get; set; }
        public string ModulerStand { get; set; }
        public string CustomStand { get; set; }
        public int? OrderID { get; set; }

        public virtual Order Order  { get; set; }

        public virtual List<ProductDetail> ProductDetails { get; set; }
        public virtual List<ProductPossibleProblem> ProductPossibleProblems { get; set; }

    }
}
