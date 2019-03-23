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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
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
                string sql = "select Client_name from Clients";
                MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);

                DataSet ds = new DataSet();
                da.Fill(ds, "Client_name");
                comboBox1.DisplayMember = "Client_name";
                comboBox1.ValueMember = "Client_name";
                comboBox1.DataSource = ds.Tables["Client_name"];

            }
            catch (Exception ex)
            {

            }

            conn.Close();
        }

        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = string.Format("select * from clients where Client_name='{0}'", comboBox1.Text);
            if (Open() == true)
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                MySqlDataReader r = cmd.ExecuteReader();
                DataTable ft = new System.Data.DataTable();

                while (r.Read())
                {
                    try
                    {
                        //MessageBox.Show(r["deve"].ToString());
                        txtNome.Text = r["Client_name"].ToString();
                        if(r["deve"].ToString() == true.ToString())
                        {
                            checkBox1.CheckState=CheckState.Checked;
                        }
                        else
                        {
                            checkBox1.CheckState = CheckState.Unchecked;
                        }
                        txtDeve.Text = r["qntDeve"].ToString().Replace('.',',');
                        

                    }
                    catch (Exception ex)
                    {
                        conn.Close();
                    }
                    
                }
                conn.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string value = txtDeve.Text;
            value = value.Replace(',', '.');

            string sql = string.Format("UPDATE Clients SET Client_name='{0}',deve={1},qntDeve='{2}' WHERE Client_name='{3}';", txtNome.Text, checkBox1.Checked.ToString(), value, comboBox1.Text);

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
