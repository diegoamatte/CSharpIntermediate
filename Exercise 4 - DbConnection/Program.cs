using Exercise_4___DbConnection;


var connectionString = "dummy string";
var sqlConnection = new SqlConnection(connectionString);
var oracleConnection = new OracleConnection(connectionString);

sqlConnection.OpenConnection();
sqlConnection.CloseConnection();

oracleConnection.OpenConnection();
oracleConnection.CloseConnection();
