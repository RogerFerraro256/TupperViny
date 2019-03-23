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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

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

        Database db = new Database();

        private void btnSlava_Click(object sender, EventArgs e)
        {
            bool added = db.newProduct(txtName.Text, txtDetail.Text, txtCódigo.Text, (int)nmrQtd.Value, double.Parse(txtValue.Text));

            string value = txtValue.Text;
            value = value.Replace(',', '.');

            string sql = string.Format("INSERT INTO products(CodProd,Prod_name,Prod_Detail,Prod_val,Prod_qtd) VALUES('{0}','{1}','{2}','{3}',{4});", txtCódigo.Text, txtName.Text, txtDetail.Text, value, (int)nmrQtd.Value);

            if (added) {
                CloseConnection();
                MessageBox.Show(sql);
                dtGridProds.Refresh();
                updating();
            }
            else
            {
                MessageBox.Show(sql);
            }

        }

        MySqlConnection conn;
        private bool conectionAndView()
        {
            string server = "localhost";
            string database = "tupperviny";
            string uid = "root";
            string password = "1234";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            try { 
            conn = new MySqlConnection(connectionString);
                return true;
            }catch(MySqlException me)
            {
                MessageBox.Show(me.ToString());
                return false;
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            rdbClient.Checked = false;
            rdbProduct.Checked = false;

            gpbAllClients.Visible = false;
            dpbAllProd.Visible = true;

            gpbClient.Visible = false;
            gpbProduct.Visible = false;

            

        }

        public void updating()
        {
            OpenConnection();
            MySqlDataAdapter da = new MySqlDataAdapter("select * from products", conn);
            DataSet DS = new DataSet();
            da.Fill(DS);
            dtGridProds.DataSource = DS.Tables[0];

            MySqlDataAdapter da2 = new MySqlDataAdapter("select * from clients", conn);
            DataSet DS2 = new DataSet();
            da2.Fill(DS2);
            dataGridView1.DataSource = DS2.Tables[0];



            //close connection
            CloseConnection();
        }

        private void rdbClient_CheckedChanged(object sender, EventArgs e)
        {
            gpbProduct.Visible = false;
            gpbClient.Visible = true;
        }

        private void rdbProduct_CheckedChanged(object sender, EventArgs e)
        {
            gpbProduct.Visible = true;
            gpbClient.Visible = false;
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            if (db.newClient(txtClient.Text,cbDeve.Checked,txtDeve.Text) =="foi")
            {
                MessageBox.Show("Cliente adicionado");
                dataGridView1.Refresh();
                
                updating();
            }
            else
            {
                
                MessageBox.Show(db.newClient(txtClient.Text, cbDeve.Checked, txtDeve.Text));
            }
        }

        private void viewProd_CheckedChanged(object sender, EventArgs e)
        {
            dpbAllProd.Visible = true;
            gpbAllClients.Visible = false;
        }

        private void viewClient_CheckedChanged(object sender, EventArgs e)
        {
            dpbAllProd.Visible = false;
            gpbAllClients.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new newBuy().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Form4().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Form5().Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (conectionAndView() == true)
            {
                updating();
                //conn.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Form6().Show();
        }

        private void cbDeve_CheckedChanged(object sender, EventArgs e)
        {
            if (cbDeve.CheckState == CheckState.Checked)
            {
                txtDeve.Enabled = true;
            }
            else
            {
                txtDeve.Text = "";
                txtDeve.Enabled = false;
            }
        }
    }
}
