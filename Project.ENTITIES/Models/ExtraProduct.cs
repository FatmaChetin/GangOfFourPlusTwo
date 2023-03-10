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
        // 1 extra product n possible problems
        // 1 possible problem n extra product
        //----------------------------------
        // 1 product n extra product
        // 1 extra product n product
        public decimal EkstraProductPrice { get; set; }// ekstra ürün fiyatları
        public string Catering { get; set; }// catering
        public string FoodServiceWorker { get; set; }// garson
        public string FairHostel { get; set; }// fuar hostesi
        public string StorageArea { get; set; }// depolama alanı
        public string InvititationCard { get; set; }// davetiye
        public string Lojistic { get; set; }//nakliye
        public string Assembly { get; set; }//montaj

        //relational
        public virtual List<ProductDetail> ProductDetails { get; set; }
        public virtual List<ExtraProductPossibleProblem> ExtraProductPossibleProblems { get; set; }

    }
}
