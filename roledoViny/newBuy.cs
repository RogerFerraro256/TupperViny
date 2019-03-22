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
    public partial class newBuy : Form
    {
        public newBuy()
        {
            InitializeComponent();
            
        }


        private MySqlConnection conn;
        private string server;
        private string database;
        private string username;
        private string password;
                
        private void Initialize()
        {
            server = "localhost";
            database = "tupperviny";
            username = "root";
            password = "1234";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + username + ";" + "PASSWORD=" + password + ";";

            conn = new MySqlConnection(connectionString);
        }

        private void newBuy_Load(object sender, EventArgs e)
        {
            Initialize();
            addThings();

        }

        private void addThings()
        {

            conn.Open();
            MySqlCommand sc = new MySqlCommand("select Client_name from clients", conn);
            MySqlDataReader reader;

            reader = sc.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Client_name", typeof(string));
            dt.Load(reader);

            cbbNames.ValueMember = "Client_name";
            cbbNames.DisplayMember = "Client_name";
            cbbNames.DataSource = dt;


            MySqlDataAdapter sda = new MySqlDataAdapter("SELECT Prod_name,Prod_Val FROM products", conn);
                
                    //Fill the DataTable with records from Table.
                    DataTable table = new DataTable();
                    sda.Fill(table);

                    //Assign DataTable as DataSource.
                    clbProds.DataSource = table;
                    clbProds.DisplayMember = "Prod_name";
                    clbProds.ValueMember = "Prod_Val";


            

            conn.Close();


        }

        private void clbProds_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            string a = clbProds.SelectedValue.ToString();
            try
            {
                decimal account = decimal.Parse(clbProds.SelectedValue.ToString());
                account = decimal.Parse(a);
                decimal total = 0;
                total += account;

                label1.Text = total.ToString();
            }catch(Exception ex)
            {

            }
        }
    }
}
