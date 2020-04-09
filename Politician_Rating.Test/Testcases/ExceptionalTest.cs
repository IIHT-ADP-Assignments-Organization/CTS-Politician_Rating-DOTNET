using NSubstitute;
using Politician_Rating.Businesslayer.Services;
using Politician_Rating.DataLayer.NHibernateConfiguration;
using Politician_Rating.Entities;
using Politician_Rating.Test.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Politician_Rating.Test.Testcases
{
  public  class ExceptionalTest
    {
        private readonly AdminServices _AdminServices;
        private readonly PoliticianPartyServices _PoliticianServices;
        private readonly IMapperSession _session = Substitute.For<IMapperSession>();
        public ExceptionalTest()
        {

            _AdminServices = new AdminServices(_session);
            _PoliticianServices = new PoliticianPartyServices(_session);
        }


        [Fact]
        public void ExceptionTestFor_FieldsCannotblankforAddDevelopment()
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
            //Assert
            var ex = Assert.Throws<FieldscannotEmptyException>(() => _PoliticianServices.AddDevelopmentActivity(development));
            Assert.Equal("Fields can not be blank ", ex.Messages);
        }

        [Fact]
        public void ExceptionTestFor_FieldsCannotblankforAddPolititioanLeader()
        {
            Candidate candidate = new Candidate()
            {
                CandidateId = 1,
                CandidateName = "ss",
                CandidateState = "ss",
                PartyId = 1,

            };
            //Assert
            var ex = Assert.Throws<FieldscannotEmptyException>(() => _PoliticianServices.AddPolitiationLeader(candidate));
            Assert.Equal("Fields can not be blank ", ex.Messages);
        }

        [Fact]
        public void ExceptionTestFor_FieldsCannotblankforAddPolititioanParty()
        {

            PartyTable partyTable = new PartyTable()
            {
                PartyId = 1,
                PartyName = "ss",
                PartyPic = "dd"

            };
            //Assert
            var ex = Assert.Throws<FieldscannotEmptyException>(() => _AdminServices.AddPolitiationParty(partyTable));
            Assert.Equal("Fields can not be blank ", ex.Messages);
        }
    }
}
