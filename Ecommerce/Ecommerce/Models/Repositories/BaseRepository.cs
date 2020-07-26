using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Models.Repositories
{
    public class BaseRepository
    {
        protected IDbConnection con;
        public BaseRepository()
        {
            string connectionString = "Data Source=.;Initial Catalog=Ecommerce;Integrated Security=True;";
            con = new SqlConnection(connectionString);
        }
        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
