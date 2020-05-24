using System;
using System.Collections.Generic;

namespace Dbfirstapproach.Models
{
    public partial class SubAreaFeedbacks
    {
        public int Id { get; set; }
        public string FeedbackNotes { get; set; }
        public int EvaluatorId { get; set; }
        public int SubTechId { get; set; }

        public virtual Evaluators Evaluator { get; set; }
        public virtual TechSubAreas SubTech { get; set; }
    }
}
