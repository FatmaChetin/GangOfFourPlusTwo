using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class ExtraProduct:BaseEntity
    {
        // Ekstra ürünler; müşteri  tercihleri doğrultusunda ekstra hizmetlerden yararlanabilir.

        public decimal EkstraProductPrice { get; set; }
        public string Catering { get; set; }
        public string FoodServiceWorker { get; set; }
        public string FairHostel { get; set; }
        public string StorageArea { get; set; }
        public string InvititationCard { get; set; }
        public string Transportation { get; set; }
        public string Assembly { get; set; }

        public virtual List<ProductDetail> ProductDetails { get; set; }
        public virtual List<ExtraProductPossibleProblem> ExtraProductPossibleProblems { get; set; }

    }
}
