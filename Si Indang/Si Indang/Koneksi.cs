using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Si_Indang
{
    class Koneksi
    {
        public string connectionInfo;
        public MySqlConnection connection;

        public Koneksi()
        {
            connectionInfo = "datasource=localhost; port=3306; username=root; password=root; database=siindang; SslMode = none";
            connection = new MySqlConnection(connectionInfo);
        }
    }
}
