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
            this.label7 = new System.Windows.Forms.Label();
            this.cbDeve = new System.Windows.Forms.CheckBox();
            this.btnClient = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtClient = new System.Windows.Forms.TextBox();
            this.rdbProduct = new System.Windows.Forms.RadioButton();
            this.rdbClient = new System.Windows.Forms.RadioButton();
            this.dtGridProds = new System.Windows.Forms.DataGridView();
            this.dpbAllProd = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.viewClient = new System.Windows.Forms.RadioButton();
            this.viewProd = new System.Windows.Forms.RadioButton();
            this.gpbAllClients = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
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
            this.txtCódigo.Location = new System.Drawing.Point(105, 38);
            this.txtCódigo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCódigo.Name = "txtCódigo";
            this.txtCódigo.Size = new System.Drawing.Size(132, 22);
            this.txtCódigo.TabIndex = 0;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(105, 75);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(132, 22);
            this.txtName.TabIndex = 1;
            // 
            // txtDetail
            // 
            this.txtDetail.Location = new System.Drawing.Point(105, 111);
            this.txtDetail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDetail.Name = "txtDetail";
            this.txtDetail.Size = new System.Drawing.Size(132, 22);
            this.txtDetail.TabIndex = 2;
            // 
            // nmrQtd
            // 
            this.nmrQtd.Location = new System.Drawing.Point(105, 144);
            this.nmrQtd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nmrQtd.Name = "nmrQtd";
            this.nmrQtd.Size = new System.Drawing.Size(48, 22);
            this.nmrQtd.TabIndex = 3;
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(105, 176);
            this.txtValue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(132, 22);
            this.txtValue.TabIndex = 4;
            // 
            // btnSlava
            // 
            this.btnSlava.Location = new System.Drawing.Point(105, 206);
            this.btnSlava.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSlava.Name = "btnSlava";
            this.btnSlava.Size = new System.Drawing.Size(133, 48);
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
            this.gpbProduct.Location = new System.Drawing.Point(41, 47);
            this.gpbProduct.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpbProduct.Name = "gpbProduct";
            this.gpbProduct.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpbProduct.Size = new System.Drawing.Size(247, 286);
            this.gpbProduct.TabIndex = 6;
            this.gpbProduct.TabStop = false;
            this.gpbProduct.Text = "Adicionar Produto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 181);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Valor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 149);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Quantidade:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 116);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Detalhe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nome:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
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
            this.gpbClient.Location = new System.Drawing.Point(43, 47);
            this.gpbClient.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpbClient.Name = "gpbClient";
            this.gpbClient.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpbClient.Size = new System.Drawing.Size(321, 169);
            this.gpbClient.TabIndex = 7;
            this.gpbClient.TabStop = false;
            this.gpbClient.Text = "Adicionar Cliente";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 76);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 17);
            this.label7.TabIndex = 4;
            this.label7.Text = "Ja pagou";
            // 
            // cbDeve
            // 
            this.cbDeve.AutoSize = true;
            this.cbDeve.Location = new System.Drawing.Point(168, 78);
            this.cbDeve.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbDeve.Name = "cbDeve";
            this.cbDeve.Size = new System.Drawing.Size(18, 17);
            this.cbDeve.TabIndex = 3;
            this.cbDeve.UseVisualStyleBackColor = true;
            // 
            // btnClient
            // 
            this.btnClient.Location = new System.Drawing.Point(44, 100);
            this.btnClient.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClient.Name = "btnClient";
            this.btnClient.Size = new System.Drawing.Size(257, 48);
            this.btnClient.TabIndex = 2;
            this.btnClient.Text = "Salvar";
            this.btnClient.UseVisualStyleBackColor = true;
            this.btnClient.Click += new System.EventHandler(this.btnClient_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 50);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Nome do Cliente:";
            // 
            // txtClient
            // 
            this.txtClient.Location = new System.Drawing.Point(168, 46);
            this.txtClient.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtClient.Name = "txtClient";
            this.txtClient.Size = new System.Drawing.Size(132, 22);
            this.txtClient.TabIndex = 0;
            // 
            // rdbProduct
            // 
            this.rdbProduct.AutoSize = true;
            this.rdbProduct.Location = new System.Drawing.Point(40, 14);
            this.rdbProduct.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbProduct.Name = "rdbProduct";
            this.rdbProduct.Size = new System.Drawing.Size(142, 21);
            this.rdbProduct.TabIndex = 8;
            this.rdbProduct.TabStop = true;
            this.rdbProduct.Text = "Adicionar Produto";
            this.rdbProduct.UseVisualStyleBackColor = true;
            this.rdbProduct.CheckedChanged += new System.EventHandler(this.rdbProduct_CheckedChanged);
            // 
            // rdbClient
            // 
            this.rdbClient.AutoSize = true;
            this.rdbClient.Location = new System.Drawing.Point(193, 14);
            this.rdbClient.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbClient.Name = "rdbClient";
            this.rdbClient.Size = new System.Drawing.Size(135, 21);
            this.rdbClient.TabIndex = 9;
            this.rdbClient.TabStop = true;
            this.rdbClient.Text = "Adicionar Cliente";
            this.rdbClient.UseVisualStyleBackColor = true;
            this.rdbClient.CheckedChanged += new System.EventHandler(this.rdbClient_CheckedChanged);
            // 
            // dtGridProds
            // 
            this.dtGridProds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridProds.Location = new System.Drawing.Point(8, 23);
            this.dtGridProds.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtGridProds.Name = "dtGridProds";
            this.dtGridProds.Size = new System.Drawing.Size(647, 292);
            this.dtGridProds.TabIndex = 11;
            // 
            // dpbAllProd
            // 
            this.dpbAllProd.Controls.Add(this.dtGridProds);
            this.dpbAllProd.Location = new System.Drawing.Point(388, 47);
            this.dpbAllProd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dpbAllProd.Name = "dpbAllProd";
            this.dpbAllProd.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dpbAllProd.Size = new System.Drawing.Size(663, 322);
            this.dpbAllProd.TabIndex = 12;
            this.dpbAllProd.TabStop = false;
            this.dpbAllProd.Text = "Visualizar Produtos";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.viewClient);
            this.groupBox1.Controls.Add(this.viewProd);
            this.groupBox1.Location = new System.Drawing.Point(396, -5);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(304, 62);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // viewClient
            // 
            this.viewClient.AutoSize = true;
            this.viewClient.Location = new System.Drawing.Point(160, 17);
            this.viewClient.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.viewClient.Name = "viewClient";
            this.viewClient.Size = new System.Drawing.Size(144, 21);
            this.viewClient.TabIndex = 1;
            this.viewClient.TabStop = true;
            this.viewClient.Text = "Visualizar Clientes";
            this.viewClient.UseVisualStyleBackColor = true;
            this.viewClient.CheckedChanged += new System.EventHandler(this.viewClient_CheckedChanged);
            // 
            // viewProd
            // 
            this.viewProd.AutoSize = true;
            this.viewProd.Location = new System.Drawing.Point(8, 17);
            this.viewProd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.viewProd.Name = "viewProd";
            this.viewProd.Size = new System.Drawing.Size(151, 21);
            this.viewProd.TabIndex = 0;
            this.viewProd.TabStop = true;
            this.viewProd.Text = "Visualizar Produtos";
            this.viewProd.UseVisualStyleBackColor = true;
            this.viewProd.CheckedChanged += new System.EventHandler(this.viewProd_CheckedChanged);
            // 
            // gpbAllClients
            // 
            this.gpbAllClients.Controls.Add(this.dataGridView1);
            this.gpbAllClients.Location = new System.Drawing.Point(391, 47);
            this.gpbAllClients.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpbAllClients.Name = "gpbAllClients";
            this.gpbAllClients.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpbAllClients.Size = new System.Drawing.Size(663, 322);
            this.gpbAllClients.TabIndex = 13;
            this.gpbAllClients.TabStop = false;
            this.gpbAllClients.Text = "Visualizar Clientes";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 23);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(647, 292);
            this.dataGridView1.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(43, 347);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(321, 71);
            this.button1.TabIndex = 14;
            this.button1.Text = "Nova Compra";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(396, 376);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(287, 45);
            this.button2.TabIndex = 15;
            this.button2.Text = "Alterar Produto";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(720, 376);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(287, 45);
            this.button3.TabIndex = 16;
            this.button3.Text = "Realizar Pagamento";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 433);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gpbAllClients);
            this.Controls.Add(this.dpbAllProd);
            this.Controls.Add(this.rdbClient);
            this.Controls.Add(this.rdbProduct);
            this.Controls.Add(this.gpbClient);
            this.Controls.Add(this.gpbProduct);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

