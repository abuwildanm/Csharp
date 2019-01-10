using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PercobaanSQL
{
    public partial class FormLogin : Form
    {
        static string connectionInfo = "datasource=localhost; port=3306; username=root; password=root; database=dbcsharp; SslMode = none";
        MySqlConnection connection = new MySqlConnection(connectionInfo);

        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string query = "select * from user where username = '" + tbUsername.Text + "' and password = '" + tbPassword.Text + "';";
            MySqlDataReader reader;

            try
            {
                connection.Open();
                MySqlCommand sqlCommand = new MySqlCommand(query, connection);
                reader = sqlCommand.ExecuteReader();
                int count = 0;
                while (reader.Read())
                {
                    count += 1;
                }
                if (count == 1)
                {
                    MessageBox.Show("Successfully Login");
                } else
                {
                    MessageBox.Show("Login Failed");
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
