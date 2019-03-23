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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            
                Initialize();
                addThings();
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

        private bool Open()
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

        private void addThings()
        {
            

            try
            {
                string sql = "select Prod_name from products";
                MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
                
                DataSet ds = new DataSet();
                da.Fill(ds, "Prod_name");
                comboBox1.DisplayMember = "Prod_name";
                comboBox1.ValueMember = "Prod_name";
                comboBox1.DataSource = ds.Tables["Prod_name"];

            }catch(Exception ex)
            {

            }

            conn.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = string.Format("select * from products where Prod_name='{0}'",comboBox1.Text);
            if (Open() == true) { 
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            MySqlDataReader r = cmd.ExecuteReader();
            DataTable ft = new System.Data.DataTable();

            while (r.Read())
            {
                try{
                    txtCod.Text = r["CodProd"].ToString();
                    txtNome.Text = r["Prod_name"].ToString();
                    txtDetail.Text = r["Prod_Detail"].ToString();
                    txtVal.Text = r["Prod_Val"].ToString();
                    nmrQtd.Value = decimal.Parse(r["Prod_qtd"].ToString());

                    conn.Clone();
                }catch(Exception ex)
                {
                    conn.Close();
                }

            }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string value = txtVal.Text;
            value = value.Replace(',', '.');

            string sql = string.Format("UPDATE products SET CodProd='{0}',Prod_name='{1}',Prod_Detail='{2}',Prod_val='{3}',Prod_qtd={4} WHERE Prod_name='{5}';", txtCod.Text, txtNome.Text, txtDetail.Text, value, decimal.Parse(nmrQtd.Value.ToString()),comboBox1.Text);

            if (this.Open() == true)
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
    }
}
