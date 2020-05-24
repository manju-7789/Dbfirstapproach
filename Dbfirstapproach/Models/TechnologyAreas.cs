using System;
using System.Collections.Generic;

namespace Dbfirstapproach.Models
{
    public partial class TechnologyAreas
    {
        public TechnologyAreas()
        {
            EvaluationTechnologies = new HashSet<EvaluationTechnologies>();
            TechAreaRecommendations = new HashSet<TechAreaRecommendations>();
            TechSubAreas = new HashSet<TechSubAreas>();
        }

        public int TechId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<EvaluationTechnologies> EvaluationTechnologies { get; set; }
        public virtual ICollection<TechAreaRecommendations> TechAreaRecommendations { get; set; }
        public virtual ICollection<TechSubAreas> TechSubAreas { get; set; }
    }
}
