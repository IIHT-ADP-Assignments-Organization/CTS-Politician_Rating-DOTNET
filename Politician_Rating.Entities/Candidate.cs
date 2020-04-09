using System;
using System.Collections.Generic;
using System.Text;

namespace Politician_Rating.Entities
{
  public  class Candidate
    {
        public virtual int CandidateId { get; set; }
        public virtual int PartyId { get; set; }
        public virtual string CandidateName { get; set; }
        public virtual string CandidateState { get; set; }
        public virtual string PhoneNumber { get; set; }

    }
}
