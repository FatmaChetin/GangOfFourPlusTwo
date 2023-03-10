using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class PossibleProblem:BaseEntity 
    {
        public string ProblemsRelatedToTheServicesProvided { get; set; }// servis kaynaklı problemler
        public string ExternalFactors { get; set; }// dış etkenler
        public string Description { get; set; }// açıklama

        //relational
        public virtual List<ExtraProductPossibleProblem> ExtraProductPossibleProblems { get; set; }
        public virtual List<ProductPossibleProblem> ProductPossibleProblems { get; set; }

    }
}
