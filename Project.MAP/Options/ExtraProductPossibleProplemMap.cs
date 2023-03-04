using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Options
{
    public class ExtraProductPossibleProplemMap : BaseMap<ExtraProductPossibleProblem>
    {
        public ExtraProductPossibleProplemMap()
        {
            Ignore(x => x.ID);
            HasKey(x => new 
            { 
                x.ExtraProductID,
                x.PossibleProblemID 
            });
        }
    }
}
