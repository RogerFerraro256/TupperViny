namespace roledoViny
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
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbbNames
            // 
            this.cbbNames.FormattingEnabled = true;
            this.cbbNames.Location = new System.Drawing.Point(12, 12);
            this.cbbNames.Name = "cbbNames";
            this.cbbNames.Size = new System.Drawing.Size(121, 21);
            this.cbbNames.TabIndex = 0;
            // 
            // clbProds
            // 
            this.clbProds.FormattingEnabled = true;
            this.clbProds.Location = new System.Drawing.Point(229, 12);
            this.clbProds.Name = "clbProds";
            this.clbProds.Size = new System.Drawing.Size(120, 94);
            this.clbProds.TabIndex = 1;
            this.clbProds.SelectedIndexChanged += new System.EventHandler(this.clbProds_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(242, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // newBuy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clbProds);
            this.Controls.Add(this.cbbNames);
            this.Name = "newBuy";
            this.Text = "newBuy";
            this.Load += new System.EventHandler(this.newBuy_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbNames;
        private System.Windows.Forms.CheckedListBox clbProds;
        private System.Windows.Forms.Label label1;
    }
}