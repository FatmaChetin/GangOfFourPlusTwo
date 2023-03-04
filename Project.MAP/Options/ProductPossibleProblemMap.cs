using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Options
{
    public class ProductPossibleProblemMap:BaseMap<ProductPossibleProblem>
    {
        public ProductPossibleProblemMap()
        {
            ToTable("Olası Ürün Problemleri");
            Ignore(x => x.ID);
            HasKey(x => new
            {
                x.ProductID,
                x.PossibleProblemID
            });
        }
    }
}
