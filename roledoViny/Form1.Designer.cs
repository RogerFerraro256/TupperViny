namespace roledoViny
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtCódigo = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDetail = new System.Windows.Forms.TextBox();
            this.nmrQtd = new System.Windows.Forms.NumericUpDown();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.btnSlava = new System.Windows.Forms.Button();
            this.gpbProduct = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gpbClient = new System.Windows.Forms.GroupBox();
            this.btnClient = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtClient = new System.Windows.Forms.TextBox();
            this.rdbProduct = new System.Windows.Forms.RadioButton();
            this.rdbClient = new System.Windows.Forms.RadioButton();
            this.dtGridProds = new System.Windows.Forms.DataGridView();
            this.dpbAllProd = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.viewProd = new System.Windows.Forms.RadioButton();
            this.viewClient = new System.Windows.Forms.RadioButton();
            this.gpbAllClients = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cbDeve = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nmrQtd)).BeginInit();
            this.gpbProduct.SuspendLayout();
            this.gpbClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridProds)).BeginInit();
            this.dpbAllProd.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gpbAllClients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCódigo
            // 
            this.txtCódigo.Location = new System.Drawing.Point(79, 31);
            this.txtCódigo.Name = "txtCódigo";
            this.txtCódigo.Size = new System.Drawing.Size(100, 20);
            this.txtCódigo.TabIndex = 0;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(79, 61);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 1;
            // 
            // txtDetail
            // 
            this.txtDetail.Location = new System.Drawing.Point(79, 90);
            this.txtDetail.Name = "txtDetail";
            this.txtDetail.Size = new System.Drawing.Size(100, 20);
            this.txtDetail.TabIndex = 2;
            // 
            // nmrQtd
            // 
            this.nmrQtd.Location = new System.Drawing.Point(79, 117);
            this.nmrQtd.Name = "nmrQtd";
            this.nmrQtd.Size = new System.Drawing.Size(36, 20);
            this.nmrQtd.TabIndex = 3;
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(79, 143);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(100, 20);
            this.txtValue.TabIndex = 4;
            // 
            // btnSlava
            // 
            this.btnSlava.Location = new System.Drawing.Point(79, 167);
            this.btnSlava.Name = "btnSlava";
            this.btnSlava.Size = new System.Drawing.Size(100, 39);
            this.btnSlava.TabIndex = 5;
            this.btnSlava.Text = "Salvar";
            this.btnSlava.UseVisualStyleBackColor = true;
            this.btnSlava.Click += new System.EventHandler(this.btnSlava_Click);
            // 
            // gpbProduct
            // 
            this.gpbProduct.Controls.Add(this.label5);
            this.gpbProduct.Controls.Add(this.btnSlava);
            this.gpbProduct.Controls.Add(this.label4);
            this.gpbProduct.Controls.Add(this.txtCódigo);
            this.gpbProduct.Controls.Add(this.label3);
            this.gpbProduct.Controls.Add(this.txtName);
            this.gpbProduct.Controls.Add(this.label2);
            this.gpbProduct.Controls.Add(this.txtDetail);
            this.gpbProduct.Controls.Add(this.label1);
            this.gpbProduct.Controls.Add(this.nmrQtd);
            this.gpbProduct.Controls.Add(this.txtValue);
            this.gpbProduct.Location = new System.Drawing.Point(31, 38);
            this.gpbProduct.Name = "gpbProduct";
            this.gpbProduct.Size = new System.Drawing.Size(185, 232);
            this.gpbProduct.TabIndex = 6;
            this.gpbProduct.TabStop = false;
            this.gpbProduct.Text = "Adicionar Produto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Valor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Quantidade:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Detalhe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nome:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Código:";
            // 
            // gpbClient
            // 
            this.gpbClient.Controls.Add(this.label7);
            this.gpbClient.Controls.Add(this.cbDeve);
            this.gpbClient.Controls.Add(this.btnClient);
            this.gpbClient.Controls.Add(this.label6);
            this.gpbClient.Controls.Add(this.txtClient);
            this.gpbClient.Location = new System.Drawing.Point(32, 38);
            this.gpbClient.Name = "gpbClient";
            this.gpbClient.Size = new System.Drawing.Size(241, 137);
            this.gpbClient.TabIndex = 7;
            this.gpbClient.TabStop = false;
            this.gpbClient.Text = "Adicionar Cliente";
            // 
            // btnClient
            // 
            this.btnClient.Location = new System.Drawing.Point(33, 81);
            this.btnClient.Name = "btnClient";
            this.btnClient.Size = new System.Drawing.Size(193, 39);
            this.btnClient.TabIndex = 2;
            this.btnClient.Text = "Salvar";
            this.btnClient.UseVisualStyleBackColor = true;
            this.btnClient.Click += new System.EventHandler(this.btnClient_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Nome do Cliente:";
            // 
            // txtClient
            // 
            this.txtClient.Location = new System.Drawing.Point(126, 37);
            this.txtClient.Name = "txtClient";
            this.txtClient.Size = new System.Drawing.Size(100, 20);
            this.txtClient.TabIndex = 0;
            // 
            // rdbProduct
            // 
            this.rdbProduct.AutoSize = true;
            this.rdbProduct.Location = new System.Drawing.Point(30, 11);
            this.rdbProduct.Name = "rdbProduct";
            this.rdbProduct.Size = new System.Drawing.Size(109, 17);
            this.rdbProduct.TabIndex = 8;
            this.rdbProduct.TabStop = true;
            this.rdbProduct.Text = "Adicionar Produto";
            this.rdbProduct.UseVisualStyleBackColor = true;
            this.rdbProduct.CheckedChanged += new System.EventHandler(this.rdbProduct_CheckedChanged);
            // 
            // rdbClient
            // 
            this.rdbClient.AutoSize = true;
            this.rdbClient.Location = new System.Drawing.Point(145, 11);
            this.rdbClient.Name = "rdbClient";
            this.rdbClient.Size = new System.Drawing.Size(104, 17);
            this.rdbClient.TabIndex = 9;
            this.rdbClient.TabStop = true;
            this.rdbClient.Text = "Adicionar Cliente";
            this.rdbClient.UseVisualStyleBackColor = true;
            this.rdbClient.CheckedChanged += new System.EventHandler(this.rdbClient_CheckedChanged);
            // 
            // dtGridProds
            // 
            this.dtGridProds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridProds.Location = new System.Drawing.Point(6, 19);
            this.dtGridProds.Name = "dtGridProds";
            this.dtGridProds.Size = new System.Drawing.Size(485, 237);
            this.dtGridProds.TabIndex = 11;
            // 
            // dpbAllProd
            // 
            this.dpbAllProd.Controls.Add(this.dtGridProds);
            this.dpbAllProd.Location = new System.Drawing.Point(291, 38);
            this.dpbAllProd.Name = "dpbAllProd";
            this.dpbAllProd.Size = new System.Drawing.Size(497, 262);
            this.dpbAllProd.TabIndex = 12;
            this.dpbAllProd.TabStop = false;
            this.dpbAllProd.Text = "Visualizar Produtos";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.viewClient);
            this.groupBox1.Controls.Add(this.viewProd);
            this.groupBox1.Location = new System.Drawing.Point(297, -4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(228, 50);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // viewProd
            // 
            this.viewProd.AutoSize = true;
            this.viewProd.Location = new System.Drawing.Point(6, 14);
            this.viewProd.Name = "viewProd";
            this.viewProd.Size = new System.Drawing.Size(114, 17);
            this.viewProd.TabIndex = 0;
            this.viewProd.TabStop = true;
            this.viewProd.Text = "Visualizar Produtos";
            this.viewProd.UseVisualStyleBackColor = true;
            this.viewProd.CheckedChanged += new System.EventHandler(this.viewProd_CheckedChanged);
            // 
            // viewClient
            // 
            this.viewClient.AutoSize = true;
            this.viewClient.Location = new System.Drawing.Point(120, 14);
            this.viewClient.Name = "viewClient";
            this.viewClient.Size = new System.Drawing.Size(109, 17);
            this.viewClient.TabIndex = 1;
            this.viewClient.TabStop = true;
            this.viewClient.Text = "Visualizar Clientes";
            this.viewClient.UseVisualStyleBackColor = true;
            this.viewClient.CheckedChanged += new System.EventHandler(this.viewClient_CheckedChanged);
            // 
            // gpbAllClients
            // 
            this.gpbAllClients.Controls.Add(this.dataGridView1);
            this.gpbAllClients.Location = new System.Drawing.Point(293, 38);
            this.gpbAllClients.Name = "gpbAllClients";
            this.gpbAllClients.Size = new System.Drawing.Size(497, 262);
            this.gpbAllClients.TabIndex = 13;
            this.gpbAllClients.TabStop = false;
            this.gpbAllClients.Text = "Visualizar Clientes";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(485, 237);
            this.dataGridView1.TabIndex = 11;
            // 
            // cbDeve
            // 
            this.cbDeve.AutoSize = true;
            this.cbDeve.Location = new System.Drawing.Point(126, 63);
            this.cbDeve.Name = "cbDeve";
            this.cbDeve.Size = new System.Drawing.Size(15, 14);
            this.cbDeve.TabIndex = 3;
            this.cbDeve.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Ja pagou";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(32, 282);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(241, 58);
            this.button1.TabIndex = 14;
            this.button1.Text = "Nova Compra";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 352);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gpbAllClients);
            this.Controls.Add(this.dpbAllProd);
            this.Controls.Add(this.rdbClient);
            this.Controls.Add(this.rdbProduct);
            this.Controls.Add(this.gpbClient);
            this.Controls.Add(this.gpbProduct);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "TupperViny";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmrQtd)).EndInit();
            this.gpbProduct.ResumeLayout(false);
            this.gpbProduct.PerformLayout();
            this.gpbClient.ResumeLayout(false);
            this.gpbClient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridProds)).EndInit();
            this.dpbAllProd.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gpbAllClients.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCódigo;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDetail;
        private System.Windows.Forms.NumericUpDown nmrQtd;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.Button btnSlava;
        private System.Windows.Forms.GroupBox gpbProduct;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gpbClient;
        private System.Windows.Forms.Button btnClient;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtClient;
        private System.Windows.Forms.RadioButton rdbProduct;
        private System.Windows.Forms.RadioButton rdbClient;
        private System.Windows.Forms.DataGridView dtGridProds;
        private System.Windows.Forms.GroupBox dpbAllProd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton viewClient;
        private System.Windows.Forms.RadioButton viewProd;
        private System.Windows.Forms.GroupBox gpbAllClients;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox cbDeve;
        private System.Windows.Forms.Button button1;
    }
}

