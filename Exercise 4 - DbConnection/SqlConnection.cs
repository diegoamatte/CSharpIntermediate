using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_4___DbConnection
{
    public class SqlConnection : DbConnection
    {
        public SqlConnection(string connectionString):base(connectionString)
        {

        }

        public override void CloseConnection()
        {
            Console.WriteLine("Sql connection is closed.");
        }

        public override void OpenConnection()
        {
            Console.WriteLine("Sql connection is open.");
        }
    }
}
