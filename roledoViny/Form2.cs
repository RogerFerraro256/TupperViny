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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            setdate.Enabled = true;
            Initialize();
            
            populate();
            
        }

        private void mudaLabel()
        {
            string sql = "select * from balanco where idBalanco=1";
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            
            MySqlDataReader r = cmd.ExecuteReader();
            DataTable ft = new System.Data.DataTable();
            double gst, rnd, luc;
            
            while (r.Read())
            {
                try
                {
                    gst = double.Parse(r["blc_Gasto"].ToString());
                    rnd = double.Parse(r["blc_Income"].ToString());
                    luc = rnd - gst;
                    gasto.Text = "R$ " + gst.ToString("00.00");
                    renda.Text = "R$ " + rnd.ToString("00.00");
                    lucro.Text = "R$ " + luc.ToString("00.00");

                    //conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    //conn.Close();
                }

            }
            conn.Close();

        }

        

        private void setdate_Tick(object sender, EventArgs e)
        {
            String hourMinute;
            String date;

            hourMinute = DateTime.Now.ToString("HH:mm:ss");
            date = DateTime.Now.ToString("dd/MM/yyyy");

            label1.Text = hourMinute;
            label2.Text = date;

            mudaLabel();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

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

        MySqlConnection conn;
        private void populate()
        {

            conn.Open();
            DataSet ds = new DataSet();
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT Client_name from clients where deve=1", conn);
            adapter.Fill(ds);
            this.listBox1.DataSource = ds.Tables[0];
            this.listBox1.DisplayMember = "Client_name";
            conn.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new newBuy().Show();
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            new Form1().Show();
        }
    }
}
