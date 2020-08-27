using System.Data.SqlClient;
using System.Configuration;

namespace ConsoleApp1
{
    class ConnectDB
    {
        static string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        SqlConnection connection = new SqlConnection(connectionString);


        public SqlConnection ReturnConnection()
        {

            return connection;
        }

    }
}
