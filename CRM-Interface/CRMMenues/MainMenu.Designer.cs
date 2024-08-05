namespace CRMMenues
{
    partial class frmMain
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
            this.lbCostumers = new System.Windows.Forms.Label();
            this.lbDetails = new System.Windows.Forms.Label();
            this.lbDetails2 = new System.Windows.Forms.Label();
            this.csbtnCustomerDetails = new CRM_Interface.Custom_Controls.CustomButton();
            this.csbtnCostumers = new CRM_Interface.Custom_Controls.CustomButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(86)))), ((int)(((byte)(98)))));
            this.panel1.Controls.Add(this.csbtnCustomerDetails);
            this.panel1.Controls.Add(this.lbDetails2);
            this.panel1.Controls.Add(this.lbDetails);
            this.panel1.Controls.Add(this.lbCostumers);
            this.panel1.Controls.Add(this.csbtnCostumers);
            this.panel1.Location = new System.Drawing.Point(1, 363);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1007, 248);
            this.panel1.TabIndex = 0;
            // 
            // lbCostumers
            // 
            this.lbCostumers.AutoSize = true;
            this.lbCostumers.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCostumers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(136)))), ((int)(((byte)(63)))));
            this.lbCostumers.Location = new System.Drawing.Point(194, 99);
            this.lbCostumers.Name = "lbCostumers";
            this.lbCostumers.Size = new System.Drawing.Size(82, 21);
            this.lbCostumers.TabIndex = 1;
            this.lbCostumers.Text = "Müşteriler";
            // 
            // lbDetails
            // 
            this.lbDetails.AutoSize = true;
            this.lbDetails.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(136)))), ((int)(((byte)(63)))));
            this.lbDetails.Location = new System.Drawing.Point(320, 100);
            this.lbDetails.Name = "lbDetails";
            this.lbDetails.Size = new System.Drawing.Size(64, 21);
            this.lbDetails.TabIndex = 1;
            this.lbDetails.Text = "Müşteri";
            // 
            // lbDetails2
            // 
            this.lbDetails2.AutoSize = true;
            this.lbDetails2.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDetails2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(136)))), ((int)(((byte)(63)))));
            this.lbDetails2.Location = new System.Drawing.Point(314, 121);
            this.lbDetails2.Name = "lbDetails2";
            this.lbDetails2.Size = new System.Drawing.Size(73, 21);
            this.lbDetails2.TabIndex = 1;
            this.lbDetails2.Text = "Detayları";
            // 
            // csbtnCustomerDetails
            // 
            this.csbtnCustomerDetails.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.csbtnCustomerDetails.BackgroundColor1 = System.Drawing.Color.BlueViolet;
            this.csbtnCustomerDetails.BorderColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(56)))), ((int)(((byte)(64)))));
            this.csbtnCustomerDetails.BorderRadius1 = 40;
            this.csbtnCustomerDetails.BorderSize1 = 4;
            this.csbtnCustomerDetails.FlatAppearance.BorderSize = 0;
            this.csbtnCustomerDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.csbtnCustomerDetails.ForeColor = System.Drawing.Color.White;
            this.csbtnCustomerDetails.ForeColor1 = System.Drawing.Color.White;
            this.csbtnCustomerDetails.Image = global::CRMMenues.Properties.Resources.Note_resized;
            this.csbtnCustomerDetails.Location = new System.Drawing.Point(318, 26);
            this.csbtnCustomerDetails.Name = "csbtnCustomerDetails";
            this.csbtnCustomerDetails.Size = new System.Drawing.Size(70, 70);
            this.csbtnCustomerDetails.TabIndex = 2;
            this.csbtnCustomerDetails.UseVisualStyleBackColor = false;
            this.csbtnCustomerDetails.Click += new System.EventHandler(this.csbtnCustomerDetails_Click);
            // 
            // csbtnCostumers
            // 
            this.csbtnCostumers.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.csbtnCostumers.BackgroundColor1 = System.Drawing.Color.BlueViolet;
            this.csbtnCostumers.BorderColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(56)))), ((int)(((byte)(64)))));
            this.csbtnCostumers.BorderRadius1 = 40;
            this.csbtnCostumers.BorderSize1 = 4;
            this.csbtnCostumers.FlatAppearance.BorderSize = 0;
            this.csbtnCostumers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.csbtnCostumers.ForeColor = System.Drawing.Color.White;
            this.csbtnCostumers.ForeColor1 = System.Drawing.Color.White;
            this.csbtnCostumers.Image = global::CRMMenues.Properties.Resources.contact_Re;
            this.csbtnCostumers.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.csbtnCostumers.Location = new System.Drawing.Point(198, 26);
            this.csbtnCostumers.Name = "csbtnCostumers";
            this.csbtnCostumers.Size = new System.Drawing.Size(70, 70);
            this.csbtnCostumers.TabIndex = 0;
            this.csbtnCostumers.UseVisualStyleBackColor = false;
            this.csbtnCostumers.Click += new System.EventHandler(this.csbtnCostumer_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(998, 597);
            this.Controls.Add(this.panel1);
            this.Name = "frmMain";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private CRM_Interface.Custom_Controls.CustomButton csbtnCostumers;
        private System.Windows.Forms.Label lbCostumers;
        private System.Windows.Forms.Label lbDetails;
        private CRM_Interface.Custom_Controls.CustomButton csbtnCustomerDetails;
        private System.Windows.Forms.Label lbDetails2;
    }
}

