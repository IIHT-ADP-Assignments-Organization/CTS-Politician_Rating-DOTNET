using System;
using System.Collections.Generic;
using System.Text;

namespace Politician_Rating.Entities
{
    public class Development
    {
       
        public virtual int CandidateId { get; set; }
        public virtual int DevelopmentId { get; set; }
        public virtual string Title { get; set; }
        public virtual string Activity { get; set; }
        public virtual string State { get; set; }
        public virtual double Budget { get; set; }
        public virtual string Year { get; set; }
        public virtual string Month { get; set; }

    }
}
