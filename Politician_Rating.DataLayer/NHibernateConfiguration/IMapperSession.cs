using Politician_Rating.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Politician_Rating.DataLayer.NHibernateConfiguration
{
    public interface IMapperSession
    {
        void BeginTransaction();
        System.Threading.Tasks.Task Commit();
        System.Threading.Tasks.Task Rollback();
        void CloseTransaction();
        System.Threading.Tasks.Task Save(Candidate entity);
        System.Threading.Tasks.Task Delete(Candidate entity);
        IQueryable<Candidate> candidate { get; }
    }
}
