using System;
using System.Collections.Generic;
using System.Text;

namespace Politician_Rating.Entities
{
    public class Votes
    {
        public virtual int VoteId { get; set; }
        public virtual int DevelopmentId { get; set; }
        public virtual string Upvotes { get; set; }
        public virtual string Downvotes { get; set; }
    }
}
