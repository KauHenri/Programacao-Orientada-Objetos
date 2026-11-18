using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoFinal
{
    internal class ConexaoString
    {
        string serverName = "localhost";

        string port = "5432";

        string userName = "postgres";

        string password = "1542";

        string dataBaseName = "postgres";

        public string ConnString()
        {
            string connString = "Server =" + serverName + ";Port = " + port + ";Username = " + userName + ";Password=" + password + ";Database=" + dataBaseName + ";";
            return connString;
        }
    }
}
