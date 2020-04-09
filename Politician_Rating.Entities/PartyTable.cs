using System;
using System.Collections.Generic;
using System.Text;

namespace Politician_Rating.Entities
{
   public class PartyTable
    {
        public virtual int PartyId { get; set; }
        public virtual string PartyName { get; set; }
        public virtual string PartyPic { get; set; }
    }
}
