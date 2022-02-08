using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_4___DbConnection
{
    public class OracleConnection : DbConnection
    {
        public OracleConnection(string connectionString) : base(connectionString)
        {

        }

        public override void CloseConnection()
        {
            Console.WriteLine("Oracle connection is closed");
        }

        public override void OpenConnection()
        {
            Console.WriteLine("Oracle connection is open.");
        }
    }
}
