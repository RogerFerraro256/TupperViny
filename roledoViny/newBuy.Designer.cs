﻿namespace roledoViny
{
    partial class newBuy
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
            this.cbbNames = new System.Windows.Forms.ComboBox();
            this.clbProds = new System.Windows.Forms.CheckedListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbbNames
            // 
            this.cbbNames.FormattingEnabled = true;
            this.cbbNames.Location = new System.Drawing.Point(16, 15);
            this.cbbNames.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbbNames.Name = "cbbNames";
            this.cbbNames.Size = new System.Drawing.Size(160, 24);
            this.cbbNames.TabIndex = 0;
            // 
            // clbProds
            // 
            this.clbProds.FormattingEnabled = true;
            this.clbProds.Location = new System.Drawing.Point(195, 13);
            this.clbProds.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.clbProds.Name = "clbProds";
            this.clbProds.Size = new System.Drawing.Size(159, 106);
            this.clbProds.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(195, 137);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 106);
            this.button1.TabIndex = 3;
            this.button1.Text = "Confirmar Compra";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(17, 137);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(159, 106);
            this.button2.TabIndex = 4;
            this.button2.Text = "Cancelar compra";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // newBuy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 266);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.clbProds);
            this.Controls.Add(this.cbbNames);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "newBuy";
            this.Text = "newBuy";
            this.Load += new System.EventHandler(this.newBuy_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbNames;
        private System.Windows.Forms.CheckedListBox clbProds;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}