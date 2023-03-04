using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Options
{
    public class PossibleProblemMap:BaseMap<PossibleProblem>
    {
        public PossibleProblemMap()
        {
            Property(x => x.ProblemsRelatedToTheServicesProvided).HasColumnName(" Ürüne bağlı olan problemler");
            Property(x => x.ExternalFactors).HasColumnName("Dış Etkilere Bağlı Problemler");
            Property(x => x.Description).HasColumnName("Açıklama");
        }
    }
}
