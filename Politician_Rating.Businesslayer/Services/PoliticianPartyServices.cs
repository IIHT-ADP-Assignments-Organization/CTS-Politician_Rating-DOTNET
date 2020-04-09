using Politician_Rating.Businesslayer.Interfaces;
using Politician_Rating.DataLayer.NHibernateConfiguration;
using Politician_Rating.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Politician_Rating.Businesslayer.Services
{
    public class PoliticianPartyServices : IPoliticianPartyServices
    {
        private readonly IMapperSession _session;

        public PoliticianPartyServices(IMapperSession session)
        {
            _session = session;
        }
        public int AddPolitiationLeader(Candidate candidate)
        {
            Candidate candidate1 = new Candidate();
            var CandidateId = candidate1.CandidateId;
            return CandidateId;
        }

        public bool DeleteCandidate(int CandidteId)
        {
            return true;
        }

        public Candidate EditPlitiationLeader(Candidate candidate)
        {
            Candidate candidate1 = new Candidate();
            return candidate1;
        }

        public Candidate GetPolitiationLeader(Candidate candidate)
        {
            Candidate candidate1 = new Candidate();
            return candidate1;
        }

        public Candidate ViewPolitiationLeader()
        {
            Candidate candidate1 = new Candidate();
            return candidate1;
        }

        public int AddDevelopmentActivity(Development development)
        {
            Development development1 = new Development();
            var DevelpmentId = development1.DevelopmentId;
            return DevelpmentId;
        }

        public int AddUpvotes(Votes votes)
        {
            Votes votes1 = new Votes();
            return votes1.VoteId;
        }

        public bool DeleteDevelopmentActivity(int DevelopmentId)
        {
            return true;
        }

        public int AddDownVotes(Votes votes)
        {
            Votes votes1 = new Votes();
            return votes1.VoteId;
        }

        public Development EditDevelopmentActivity(Development development)
        {
            Development development1 = new Development();
            return development1;
        }

        public Development GetDevelopmentActivity(Development development)
        {
            Development development1 = new Development();
            return development1;
        }

        public Development ViewDevelopmentActivity()
        {
            Development development1 = new Development();
            return development1;
        }
    }
}
