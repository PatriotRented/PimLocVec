using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pim.Patriot.DataAccess
{
     public class ConnectionFactory
    {
       public static DbConnection getConnection(string _providerName, string _connectionString)
        {
            //Assume failure
            DbConnection connection = null;

            //Cria o DbProviderFactory and DbConnection
            if(_connectionString != null)
            {
                try
                {
                    DbProviderFactory factory = DbProviderFactories.GetFactory(_providerName);
                    connection.ConnectionString = _connectionString;
                }catch (Exception ex){
                    //Set the connection to null if was created.
                    if (connection != null)
                    {
                        connection = null;
                    }
                    Console.WriteLine(ex.Message);
                }
            }
            return connection;
        }
    }
}
