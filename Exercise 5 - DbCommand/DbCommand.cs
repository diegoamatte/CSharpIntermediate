using Exercise_4___DbConnection;


namespace Exercise_5___DbCommand
{
    public class DbCommand
    {
        private readonly DbConnection _connection;
        public DbCommand(DbConnection dbConnection)
        {
            if (dbConnection == null)
                throw new ArgumentNullException();
            _connection = dbConnection;
        }

        public void Execute()
        {
            _connection.OpenConnection();
            Console.WriteLine("Executing instruction");
            _connection.CloseConnection();
        }
    }
}
