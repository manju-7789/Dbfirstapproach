using System;
using System.Collections.Generic;

namespace Dbfirstapproach.Models
{
    public partial class EvaluationProcesses
    {
        public EvaluationProcesses()
        {
            EvaluationTechnologies = new HashSet<EvaluationTechnologies>();
            Evaluators = new HashSet<Evaluators>();
        }

        public int EvaluationId { get; set; }
        public string Title { get; set; }
        public string Owner { get; set; }
        public string Consultant { get; set; }
        public string Status { get; set; }
        public string CreateBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime LastUpdatedDate { get; set; }
        public string LastUpdatedBy { get; set; }

        public virtual ICollection<EvaluationTechnologies> EvaluationTechnologies { get; set; }
        public virtual ICollection<Evaluators> Evaluators { get; set; }
    }
}
