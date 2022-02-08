using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_4___DbConnection
{
    public abstract class DbConnection
    {
        public string ConnectionString { get; private set; }
        public TimeSpan TimeOut { get; set; }

        public DbConnection(string connectionString)
        {
            if(connectionString is null)
                throw new ArgumentNullException(nameof(connectionString));
            ConnectionString = connectionString;
        }

        public abstract void OpenConnection();
        public abstract void CloseConnection();
    }
}
