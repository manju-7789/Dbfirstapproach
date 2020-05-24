using System;
using System.Collections.Generic;

namespace Dbfirstapproach.Models
{
    public partial class TechAreaRecommendations
    {
        public int Id { get; set; }
        public string RecommendationNotes { get; set; }
        public int EvaluatorId { get; set; }
        public int TechId { get; set; }

        public virtual Evaluators Evaluator { get; set; }
        public virtual TechnologyAreas Tech { get; set; }
    }
}
