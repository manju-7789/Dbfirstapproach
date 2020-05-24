using System;
using System.Collections.Generic;

namespace Dbfirstapproach.Models
{
    public partial class EvaluationTechnologies
    {
        public int Id { get; set; }
        public int EvaluationId { get; set; }
        public int TechId { get; set; }

        public virtual EvaluationProcesses Evaluation { get; set; }
        public virtual TechnologyAreas Tech { get; set; }
    }
}
