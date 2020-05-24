using System;
using System.Collections.Generic;

namespace Dbfirstapproach.Models
{
    public partial class TechSubAreas
    {
        public TechSubAreas()
        {
            SubAreaFeedbacks = new HashSet<SubAreaFeedbacks>();
        }

        public int SubTechId { get; set; }
        public string Name { get; set; }
        public int TechId { get; set; }

        public virtual TechnologyAreas Tech { get; set; }
        public virtual ICollection<SubAreaFeedbacks> SubAreaFeedbacks { get; set; }
    }
}
