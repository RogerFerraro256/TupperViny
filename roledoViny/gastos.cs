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

namespace roledoViny
{
    public partial class gastos : Form
    {
        public gastos()
        {
            InitializeComponent();
        }

        private void gastos_Load(object sender, EventArgs e)
        {
            Initialize();

        }

        private bool OpenConnection()
        {
            try
            {
                conn.Open();
                return true;
            }
            catch (MySqlException)
            {

            }
            return false;
        }

        private bool CloseConnection()
        {
            try
            {
                conn.Close();
                return true;
            }
            catch (MySqlException)
            {
                return false;
            }
        }


        MySqlConnection conn;

        private void Initialize()
        {
            string server = "localhost";
            string database = "tupperviny";
            string username = "root";
            string password = "1234";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + username + ";" + "PASSWORD=" + password + ";";

            conn = new MySqlConnection(connectionString);
        }

        private void update()
        {
            string sql = string.Format("UPDATE balanco SET blc_Gasto='{0}' WHERE idBalanco=1;", textBox1.Text.Replace(',','.'));

            if (OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                //Assign the query using CommandText
                cmd.CommandText = sql;
                //Assign the connection using Connection
                cmd.Connection = conn;

                //Execute query
                cmd.ExecuteNonQuery();

                //close connection
                conn.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            update();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
