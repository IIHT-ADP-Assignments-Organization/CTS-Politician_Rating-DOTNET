using FluentNHibernate.Mapping;
using Politician_Rating.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Politician_Rating.DataLayer.Mapping
{
    class CandidateMap:ClassMap<Candidate>
    {
        public CandidateMap()
        {
            Id(x => x.CandidateId);

            Map(x => x.PartyId);

            Map(x => x.CandidateName);
            Map(x => x.CandidateState);
           
            Table("candidate");

        }
    }
}
