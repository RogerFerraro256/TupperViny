namespace roledoViny
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.setdate = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnCadastro = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblGasto = new System.Windows.Forms.Label();
            this.lblRenda = new System.Windows.Forms.Label();
            this.lblLucro = new System.Windows.Forms.Label();
            this.gasto = new System.Windows.Forms.Label();
            this.renda = new System.Windows.Forms.Label();
            this.lucro = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(518, 467);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 70);
            this.label1.TabIndex = 0;
            this.label1.Text = "14:51:00";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(605, 537);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "20/03/2019";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // setdate
            // 
            this.setdate.Interval = 1;
            this.setdate.Tick += new System.EventHandler(this.setdate_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(375, 70);
            this.label3.TabIndex = 2;
            this.label3.Text = "Olá Vinicius";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(420, 88);
            this.label4.TabIndex = 3;
            this.label4.Text = "Essas pessoas ainda \r\nnão pagaram:";
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.Control;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(457, 120);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(201, 179);
            this.listBox1.TabIndex = 4;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btnCadastro
            // 
            this.btnCadastro.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastro.Location = new System.Drawing.Point(20, 467);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(167, 109);
            this.btnCadastro.TabIndex = 5;
            this.btnCadastro.Text = "Cadastrar clientes ou produtos";
            this.btnCadastro.UseVisualStyleBackColor = true;
            this.btnCadastro.Click += new System.EventHandler(this.btnCadastro_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(220, 467);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 109);
            this.button1.TabIndex = 6;
            this.button1.Text = "Nova Compra";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lucro);
            this.groupBox1.Controls.Add(this.renda);
            this.groupBox1.Controls.Add(this.gasto);
            this.groupBox1.Controls.Add(this.lblLucro);
            this.groupBox1.Controls.Add(this.lblRenda);
            this.groupBox1.Controls.Add(this.lblGasto);
            this.groupBox1.Location = new System.Drawing.Point(24, 242);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(393, 186);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // lblGasto
            // 
            this.lblGasto.AutoSize = true;
            this.lblGasto.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGasto.Location = new System.Drawing.Point(10, 19);
            this.lblGasto.Name = "lblGasto";
            this.lblGasto.Size = new System.Drawing.Size(144, 39);
            this.lblGasto.TabIndex = 8;
            this.lblGasto.Text = "Gastos:";
            this.lblGasto.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblRenda
            // 
            this.lblRenda.AutoSize = true;
            this.lblRenda.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRenda.Location = new System.Drawing.Point(10, 74);
            this.lblRenda.Name = "lblRenda";
            this.lblRenda.Size = new System.Drawing.Size(134, 39);
            this.lblRenda.TabIndex = 9;
            this.lblRenda.Text = "Renda:";
            this.lblRenda.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblLucro
            // 
            this.lblLucro.AutoSize = true;
            this.lblLucro.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLucro.Location = new System.Drawing.Point(10, 135);
            this.lblLucro.Name = "lblLucro";
            this.lblLucro.Size = new System.Drawing.Size(144, 39);
            this.lblLucro.TabIndex = 10;
            this.lblLucro.Text = "Lucros:";
            this.lblLucro.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // gasto
            // 
            this.gasto.AutoSize = true;
            this.gasto.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gasto.Location = new System.Drawing.Point(171, 19);
            this.gasto.Name = "gasto";
            this.gasto.Size = new System.Drawing.Size(161, 39);
            this.gasto.TabIndex = 11;
            this.gasto.Text = "R$ 00,00";
            this.gasto.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // renda
            // 
            this.renda.AutoSize = true;
            this.renda.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.renda.Location = new System.Drawing.Point(171, 74);
            this.renda.Name = "renda";
            this.renda.Size = new System.Drawing.Size(161, 39);
            this.renda.TabIndex = 12;
            this.renda.Text = "R$ 00,00";
            this.renda.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lucro
            // 
            this.lucro.AutoSize = true;
            this.lucro.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lucro.Location = new System.Drawing.Point(171, 135);
            this.lucro.Name = "lucro";
            this.lucro.Size = new System.Drawing.Size(161, 39);
            this.lucro.TabIndex = 13;
            this.lucro.Text = "R$ 00,00";
            this.lucro.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 604);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCadastro);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer setdate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnCadastro;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lucro;
        private System.Windows.Forms.Label renda;
        private System.Windows.Forms.Label gasto;
        private System.Windows.Forms.Label lblLucro;
        private System.Windows.Forms.Label lblRenda;
        private System.Windows.Forms.Label lblGasto;
    }
}