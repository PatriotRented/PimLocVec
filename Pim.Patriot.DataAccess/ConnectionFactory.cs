using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pim.Patriot.DataAccess
{
    public class ConnectionFactory
    {
        public string pegaConexao(String _nome)
        {
            string connect = null;

            ConnectionStringSettings settings =
                ConfigurationManager.ConnectionStrings[_nome];

            if (settings != null)
                connect = settings.ConnectionString;

            return connect;
        }
    }
}
