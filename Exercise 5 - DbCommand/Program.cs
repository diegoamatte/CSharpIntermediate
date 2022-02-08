using Exercise_4___DbConnection;
using Exercise_5___DbCommand;

string connectionString = "connectionString";
var dbCommand = new DbCommand(new SqlConnection(connectionString));
var dbCommand2 = new DbCommand(new OracleConnection(connectionString));

dbCommand.Execute();
dbCommand2.Execute();