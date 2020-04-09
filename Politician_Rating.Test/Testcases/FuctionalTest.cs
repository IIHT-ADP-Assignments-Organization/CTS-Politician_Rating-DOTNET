using NSubstitute;
using Politician_Rating.Businesslayer.Services;
using Politician_Rating.DataLayer.NHibernateConfiguration;
using Politician_Rating.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Politician_Rating.Test.Testcases
{
   public class FuctionalTest
    {
      
        private readonly AdminServices _AdminServices;
        private readonly PoliticianPartyServices _PoliticianServices;
        private readonly IMapperSession _session = Substitute.For<IMapperSession>();
        public FuctionalTest()
        {

            _AdminServices = new AdminServices(_session);
            _PoliticianServices = new PoliticianPartyServices(_session);
        }

        [Fact]
        public void Test_for_EditDevelopmentActivity()
        {
            Development development = new Development()
            {
                DevelopmentId = 1,
                Activity = "ss",
                State = "ss",
                Budget = 11,
                CandidateId = 1,
                Month = "april",
                Title = "dd",
                Year = "2019",
            };

            var Result = _PoliticianServices.EditDevelopmentActivity(development);
            var GetDevelopment = _PoliticianServices.GetDevelopmentActivity(development);

            Assert.Equal(GetDevelopment, Result);
        }

        [Fact]
        public void Test_for_AddDevelopmentActivity()
        {
            Development development = new Development()
            {
                DevelopmentId = 1,
                Activity = "ss",
                State = "ss",
                Budget = 11,
                CandidateId = 1,
                Month = "april",
                Title = "dd",
                Year = "2019",
            };

            var Result = _PoliticianServices.AddDevelopmentActivity(development);
            var AddDevelopment = Result.ToString();

            Assert.NotNull(AddDevelopment);
        }

        [Fact]
        public void Test_for_DeleteDevelopmentActivity()
        {
            Development development = new Development()
            {
                DevelopmentId = 1,
                
            };

            var Result = _PoliticianServices.DeleteDevelopmentActivity(development.DevelopmentId);
            

            Assert.True(Result);
        }

        [Fact]
        public void Test_for_AddUpvotes()
        {
            Votes votes = new Votes()
            {
                DevelopmentId = 1,
                Upvotes = "1",
                Downvotes = "1",
            };

            var Result = _PoliticianServices.AddUpvotes(votes);
            var GetVotes = Result.ToString();

            Assert.NotNull(GetVotes);
        }

        [Fact]
        public void Test_for_AddDownVotes()
        {
            Votes votes = new Votes()
            {
                DevelopmentId = 1,
                Upvotes = "1",
                Downvotes = "1",
            };

            var Result = _PoliticianServices.AddDownVotes(votes);
            var GetVotes = Result.ToString();

            Assert.NotNull(GetVotes);
        }


        [Fact]
        public void Test_for_EditPoliticalParty()
        {
            PartyTable partyTable = new PartyTable()
            {
               PartyId=1,
               PartyName="ss",
               PartyPic="dd"

            };

            var Result = _AdminServices.EditPoliticalParty(partyTable);
            var GetDevelopment = _AdminServices.GetPoliticalParty(partyTable);

            Assert.Equal(GetDevelopment, Result);
        }

        [Fact]
        public void Test_for_DeletePoliticalParty()
        {
            PartyTable partyTable = new PartyTable()
            {
                PartyId = 1,
                

            };

            var Result = _AdminServices.DeletePoliticalParty(partyTable.PartyId);


            Assert.True(Result);
        }


        [Fact]
        public void Test_for_AddPolitiationParty()
        {
            PartyTable partyTable = new PartyTable()
            {
                PartyId = 1,
                PartyName = "ss",
                PartyPic = "dd"

            };

            var Result = _AdminServices.AddPolitiationParty(partyTable);
            var AddPartyTable = Result.ToString();

            Assert.NotNull(AddPartyTable);
        }

        [Fact]
        public void Test_for_AddPolitiationLeader()
        {
            Candidate candidate = new Candidate()
            {
               CandidateId=1,
               CandidateName="ss",
               CandidateState="ss",
               PartyId=1,

            };

            var Result = _PoliticianServices.AddPolitiationLeader(candidate);
            var AddPoliticiationLeader = Result.ToString();

            Assert.NotNull(AddPoliticiationLeader);
        }

        [Fact]
        public void Test_for_EditPlitiationLeader()
        {
            Candidate candidate = new Candidate()
            {
                CandidateId = 1,
                CandidateName = "ss",
                CandidateState = "ss",
                PartyId = 1,

            };


            var Result = _PoliticianServices.EditPlitiationLeader(candidate);
            var GetPolitition = _PoliticianServices.GetPolitiationLeader(candidate);

            Assert.Equal(GetPolitition, Result);
        }


        [Fact]
        public void Test_for_DeleteCandidate()
        {
            Candidate candidate = new Candidate()
            {
                CandidateId = 1,
                

            };

            var Result = _AdminServices.DeletePoliticalParty(candidate.CandidateId);


            Assert.True(Result);
        }
    }
}
