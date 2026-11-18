using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WfaBDCliente
{
    internal class ConexaoString
    {
        string serverName = "localhost"; // localhost 
        string port = "5432"; // porta default
        string userName = "postgres"; // nome do administrador
        string password = "1542"; // Senha do SGDB
        string dataBaseName = "DBCliente"; // Nome do Banco de Dados

        public string ConnString() // método que gera a string de conexão
        {
            string connString = "Server =" + serverName + ";Port = " + port + ";Username = " + userName + ";Password=" + password +
                 ";Database=" + dataBaseName + ";";

            return connString; // "Server =localhost;Port = 5432;Username = postgres;Password=admin;Database=bdCliente"
        }
    }
}
