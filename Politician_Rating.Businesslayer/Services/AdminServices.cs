using Politician_Rating.Businesslayer.Interfaces;
using Politician_Rating.DataLayer.NHibernateConfiguration;
using Politician_Rating.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Politician_Rating.Businesslayer.Services
{
    public class AdminServices : IAdminServices
    {

        private readonly IMapperSession _session;

        public AdminServices(IMapperSession session)
        {
            _session = session;
        }

        public int AddPolitiationParty(PartyTable partyTable)
        {
            PartyTable partyTable1 = new PartyTable();
            var PartyId = partyTable1.PartyId;
            return PartyId;
        }

        public bool DeletePoliticalParty(int PartyId)
        {
            return true;
        }

        public PartyTable EditPoliticalParty(PartyTable partyTable)
        {
            PartyTable PTable = new PartyTable();
            return PTable;
        }

        public PartyTable GetPoliticalParty(PartyTable partyTable)
        {
            PartyTable PTable = new PartyTable();
            return PTable;
        }

        public PartyTable ViewPoliticalParty()
        {
            PartyTable PTable = new PartyTable();
            return PTable;
        }
    }
}
