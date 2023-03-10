using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Product:BaseEntity
    {   // Ana ürünler, stand ve alandır. Stand tipi (modüler ve özel yapım) ve kiralanacak alan (m2 cinsinden) fiyatlandırılacaktır. 

        
        public decimal ProductPrice { get; set; }// ürün fiyatı
        public double Square { get; set; }// alan
        public string ModulerStand { get; set; }// modüler stand
        public string CustomStand { get; set; }// özel stand
        public int? OrderID { get; set; }

        //relational
        public virtual Order Order  { get; set; }
        public virtual List<ProductDetail> ProductDetails { get; set; }
        public virtual List<ProductPossibleProblem> ProductPossibleProblems { get; set; }
    }
}
