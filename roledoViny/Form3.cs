using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace roledoViny
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (progressBar1.Value != 100)
            {
                progressBar1.Value = progressBar1.Value+1;
            }
            else
            {
                this.Hide();
                var form2 = new Form2();
                form2.Closed += (s, args) => this.Close();
                form2.Show();

                timer1.Stop();
            }


        }



        private void Form3_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer1.Interval = 10;
            progressBar1.Maximum = 100;
        }

        
    }
}
