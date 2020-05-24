using System;
using System.Collections.Generic;

namespace Dbfirstapproach.Models
{
    public partial class Evaluators
    {
        public Evaluators()
        {
            SubAreaFeedbacks = new HashSet<SubAreaFeedbacks>();
            TechAreaRecommendations = new HashSet<TechAreaRecommendations>();
        }

        public int EvaluatorId { get; set; }
        public string EvaluatorEmail { get; set; }
        public bool IsSubmitted { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime LastUpdatedDate { get; set; }
        public int EvaluationId { get; set; }

        public virtual EvaluationProcesses Evaluation { get; set; }
        public virtual ICollection<SubAreaFeedbacks> SubAreaFeedbacks { get; set; }
        public virtual ICollection<TechAreaRecommendations> TechAreaRecommendations { get; set; }
    }
}
