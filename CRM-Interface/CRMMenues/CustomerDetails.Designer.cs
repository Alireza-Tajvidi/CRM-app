namespace CRMMenues
{
    partial class frmCustomerDetails
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panBack = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbTitle = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbCustomerHistory = new System.Windows.Forms.Label();
            this.cstxtCustomerID = new CRM_Interface.Custom_Controls.CustomTextBox();
            this.lbCustomerID = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panBack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(141)))), ((int)(((byte)(75)))));
            this.panel1.Controls.Add(this.lbTitle);
            this.panel1.Controls.Add(this.panBack);
            this.panel1.Location = new System.Drawing.Point(0, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1001, 50);
            this.panel1.TabIndex = 0;
            // 
            // panBack
            // 
            this.panBack.Controls.Add(this.panel5);
            this.panBack.Controls.Add(this.panel4);
            this.panBack.Controls.Add(this.panel3);
            this.panBack.Location = new System.Drawing.Point(12, 10);
            this.panBack.Name = "panBack";
            this.panBack.Size = new System.Drawing.Size(30, 30);
            this.panBack.TabIndex = 2;
            this.panBack.Click += new System.EventHandler(this.panBack_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(163)))));
            this.panel5.Location = new System.Drawing.Point(4, 22);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(21, 5);
            this.panel5.TabIndex = 0;
            this.panel5.Click += new System.EventHandler(this.panel5_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(163)))));
            this.panel4.Location = new System.Drawing.Point(4, 14);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(21, 5);
            this.panel4.TabIndex = 0;
            this.panel4.Click += new System.EventHandler(this.panel4_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(163)))));
            this.panel3.Location = new System.Drawing.Point(4, 7);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(21, 5);
            this.panel3.TabIndex = 0;
            this.panel3.Click += new System.EventHandler(this.panel3_Click);
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Franklin Gothic Heavy", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.lbTitle.Location = new System.Drawing.Point(393, 10);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(243, 30);
            this.lbTitle.TabIndex = 1;
            this.lbTitle.Text = "MÜŞTERİ DETAYLARI";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 435);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(974, 150);
            this.dataGridView1.TabIndex = 1;
            // 
            // lbCustomerHistory
            // 
            this.lbCustomerHistory.AutoSize = true;
            this.lbCustomerHistory.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCustomerHistory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(27)))), ((int)(((byte)(76)))));
            this.lbCustomerHistory.Location = new System.Drawing.Point(12, 408);
            this.lbCustomerHistory.Name = "lbCustomerHistory";
            this.lbCustomerHistory.Size = new System.Drawing.Size(104, 24);
            this.lbCustomerHistory.TabIndex = 2;
            this.lbCustomerHistory.Text = "Müşteri Tarihi";
            // 
            // cstxtCustomerID
            // 
            this.cstxtCustomerID.BackColor = System.Drawing.Color.LightSlateGray;
            this.cstxtCustomerID.BackColor1 = System.Drawing.Color.LightSlateGray;
            this.cstxtCustomerID.borderColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(163)))));
            this.cstxtCustomerID.borderSize1 = 2;
            this.cstxtCustomerID.FocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.cstxtCustomerID.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cstxtCustomerID.font1 = null;
            this.cstxtCustomerID.ForeColor = System.Drawing.Color.DimGray;
            this.cstxtCustomerID.ForeColor1 = System.Drawing.Color.White;
            this.cstxtCustomerID.Location = new System.Drawing.Point(100, 60);
            this.cstxtCustomerID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cstxtCustomerID.Name = "cstxtCustomerID";
            this.cstxtCustomerID.Padding = new System.Windows.Forms.Padding(7);
            this.cstxtCustomerID.Size = new System.Drawing.Size(256, 35);
            this.cstxtCustomerID.TabIndex = 4;
            this.cstxtCustomerID.texts1 = "";
            this.cstxtCustomerID.Underlined = true;
            // 
            // lbCustomerID
            // 
            this.lbCustomerID.AutoSize = true;
            this.lbCustomerID.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCustomerID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(27)))), ((int)(((byte)(76)))));
            this.lbCustomerID.Location = new System.Drawing.Point(11, 73);
            this.lbCustomerID.Name = "lbCustomerID";
            this.lbCustomerID.Size = new System.Drawing.Size(82, 24);
            this.lbCustomerID.TabIndex = 3;
            this.lbCustomerID.Text = "Müşteri ID";
            // 
            // frmCustomerDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(998, 597);
            this.Controls.Add(this.cstxtCustomerID);
            this.Controls.Add(this.lbCustomerID);
            this.Controls.Add(this.lbCustomerHistory);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "frmCustomerDetails";
            this.Text = "CustomerDetails";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panBack.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panBack;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbCustomerHistory;
        private CRM_Interface.Custom_Controls.CustomTextBox cstxtCustomerID;
        private System.Windows.Forms.Label lbCustomerID;
    }
}