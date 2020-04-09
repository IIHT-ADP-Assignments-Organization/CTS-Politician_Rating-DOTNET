using Politician_Rating.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Politician_Rating.Businesslayer.Interfaces
{
  public  interface IAdminServices
  {
        int AddPolitiationParty(PartyTable partyTable);
       PartyTable GetPoliticalParty(PartyTable partyTable);
       PartyTable EditPoliticalParty(PartyTable partyTable);
       bool DeletePoliticalParty(int PartyId);
       PartyTable ViewPoliticalParty();

  }
}
