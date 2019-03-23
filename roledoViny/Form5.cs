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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void addThings()
        {
            conn.Open();
            MySqlCommand sc = new MySqlCommand("select Client_name from clients where deve=1", conn);
            MySqlDataReader reader;

            reader = sc.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Client_name", typeof(string));
            dt.Load(reader);

            cbbNames.ValueMember = "Client_name";
            cbbNames.DisplayMember = "Client_name";
            cbbNames.DataSource = dt;
            conn.Close();
        }

        MySqlConnection conn;

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

        private void Form5_Load(object sender, EventArgs e)
        {


            Initialize();
            addThings();
        }

        private void cbbNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = string.Format("select * from clients where Client_name='{0}'", cbbNames.Text);
            
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {

            }


            MySqlDataReader r = cmd.ExecuteReader();
            DataTable ft = new System.Data.DataTable();

            while (r.Read())
            {
                try
                {
                    txtValue.Text = r["qntDeve"].ToString();

                }
                catch (Exception ex)
                {
                }

            }
            conn.Close();
        }

        private void txtPay_Enter(object sender, EventArgs e)
        {
        }

        double compra, pago, troco;

        private void button1_Click(object sender, EventArgs e)
        {
            if (payment(double.Parse(txtTroco.Text)) == true)
            {
                if (troco < 0)
                {

                    updateUser(cbbNames.Text, true, (troco*-1).ToString());
                    MessageBox.Show("Faltam R$ "+txtTroco.Text.Replace('-','.'));

                }
                else
                {
                   updateUser(cbbNames.Text, false, 00.00.ToString());
                   MessageBox.Show("Troco é de R$ "+txtTroco.Text,"Compra Feita");
                }
            }
            else
            {
                MessageBox.Show("falha no engano");
            }


        }

        private bool updateUser(string clientName, bool deve, string valor)
        {
            string value = valor;
            value = value.Replace(',', '.');
                        
            conn.Open();
            string sql = string.Format("UPDATE clients SET deve={0},qntDeve='{1}' WHERE Client_name='{2}';", deve, value, clientName);

            MessageBox.Show(sql);
            try
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


                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }

        private double soma()
        {
            double result = 0;

            string sql = "SELECT blc_Income from balanco where idBalanco=1";
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {
                    result = double.Parse(r["blc_Income"].ToString());
                }


                conn.Close();
                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return result;
            }




        }


        private bool payment(double troco)
        {
            pago = double.Parse(txtPay.Text);
            troco = pago + soma();

            string value = troco.ToString();
            value = value.Replace(',', '.');

            string sql = string.Format("UPDATE balanco SET blc_Income='{0}' WHERE idBalanco=1;", value);

            MessageBox.Show(sql);
            try
            {
                conn.Open();

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

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }


        private void txtPay_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                compra = double.Parse(txtValue.Text);
                pago = double.Parse(txtPay.Text);
                troco = pago - compra;

                txtTroco.Text = troco.ToString("00.00");
                button1.Enabled = true;
            }
        }
    }
}
