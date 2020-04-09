using Politician_Rating.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Politician_Rating.Businesslayer.Interfaces
{
   public interface IPoliticianPartyServices
    {
       
        int AddPolitiationLeader(Candidate candidate);
        Candidate GetPolitiationLeader(Candidate candidate);
        Candidate EditPlitiationLeader(Candidate candidate);
        bool DeleteCandidate(int CandidteId);
        Candidate ViewPolitiationLeader();
        Development GetDevelopmentActivity(Development development);
        Development EditDevelopmentActivity(Development development);
        int AddDevelopmentActivity(Development development);
        bool DeleteDevelopmentActivity(int DevelopmentId);
        Development ViewDevelopmentActivity();
        int AddUpvotes(Votes votes);
        int AddDownVotes(Votes votes);
    }
}
