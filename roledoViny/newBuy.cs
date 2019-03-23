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

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        Database db = new Database();

        private void button1_Click(object sender, EventArgs e)
        {
            double total = buy();

            if(MessageBox.Show("o resultado da compra é de " + total.ToString(), "Doris", MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.OK){
                MessageBox.Show(db.updateBuy(total,cbbNames.Text,true));
            }
        }

        private double buy()
        {
            int i;
            string s;

            double total = 0;

            s = "Checked items:\n";
            for (i = 0; i <= (clbProds.Items.Count - 1); i++)
            {
                if (clbProds.GetItemChecked(i))
                {
                    s = s + "Item " + (i + 1).ToString() + " = " + clbProds.Items[i].ToString() + "\n";
                }
            }
            //MessageBox.Show(s);


            foreach (var item in clbProds.CheckedItems)
            {
                var row = (item as DataRowView).Row;
                string a = row["Prod_val"].ToString();
                total = total + double.Parse(a);
                //MessageBox.Show(row["Prod_name"] + ": " + row["Prod_Val"]);

                //MessageBox.Show(total.ToString());
            }

            return total;

        }
    }
}