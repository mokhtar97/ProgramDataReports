using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Models.Repositories
{
    public class ReportData : BaseRepository, IStore<ViewapplicationData>
    {
        public void ADD(ViewapplicationData Model)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public ViewapplicationData Find(int? id)
        {
            throw new NotImplementedException();
        }

        public List<ViewapplicationData> List()
        {
            var query = @"select * from ApplicationData";
            var data = con.Query<ViewapplicationData>(query).ToList();
            return data ;
        }

        public void Update(int id, ViewapplicationData Model)
        {
            throw new NotImplementedException();
        }
    }
}
