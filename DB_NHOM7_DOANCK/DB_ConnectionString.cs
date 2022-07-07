using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_NHOM7_DOANCK
{
    public class DB_ConnectionString
    {
        public string connect_string = @"Data Source=localhost;Initial Catalog=Vaccination;Integrated Security=True";
        public string getConnectionString()
        {
            return connect_string;
        }
    }
}
