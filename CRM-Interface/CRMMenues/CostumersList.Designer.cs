namespace CRMMenues
{
    partial class frmCostumersList
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
            this.panTop = new System.Windows.Forms.Panel();
            this.panBack = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panInputs = new System.Windows.Forms.Panel();
            this.csbtnDelete = new CRM_Interface.Custom_Controls.CustomButton();
            this.csbtnAdd = new CRM_Interface.Custom_Controls.CustomButton();
            this.cstxtCustomerID = new CRM_Interface.Custom_Controls.CustomTextBox();
            this.cstxtPhone = new CRM_Interface.Custom_Controls.CustomTextBox();
            this.lbCustomerID = new System.Windows.Forms.Label();
            this.cstxtSurname = new CRM_Interface.Custom_Controls.CustomTextBox();
            this.lbPhone = new System.Windows.Forms.Label();
            this.lbSurname = new System.Windows.Forms.Label();
            this.cstxtName = new CRM_Interface.Custom_Controls.CustomTextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.dtgrdCostumers = new System.Windows.Forms.DataGridView();
            this.panTop.SuspendLayout();
            this.panBack.SuspendLayout();
            this.panInputs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdCostumers)).BeginInit();
            this.SuspendLayout();
            // 
            // panTop
            // 
            this.panTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(141)))), ((int)(((byte)(75)))));
            this.panTop.Controls.Add(this.panBack);
            this.panTop.Controls.Add(this.label1);
            this.panTop.Location = new System.Drawing.Point(1, 2);
            this.panTop.Name = "panTop";
            this.panTop.Size = new System.Drawing.Size(1001, 50);
            this.panTop.TabIndex = 1;
            // 
            // panBack
            // 
            this.panBack.Controls.Add(this.panel5);
            this.panBack.Controls.Add(this.panel4);
            this.panBack.Controls.Add(this.panel3);
            this.panBack.Location = new System.Drawing.Point(11, 10);
            this.panBack.Name = "panBack";
            this.panBack.Size = new System.Drawing.Size(30, 30);
            this.panBack.TabIndex = 1;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Heavy", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.label1.Location = new System.Drawing.Point(428, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "MÜŞTERİLER";
            // 
            // panInputs
            // 
            this.panInputs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(156)))), ((int)(((byte)(89)))));
            this.panInputs.Controls.Add(this.csbtnDelete);
            this.panInputs.Controls.Add(this.csbtnAdd);
            this.panInputs.Controls.Add(this.cstxtCustomerID);
            this.panInputs.Controls.Add(this.cstxtPhone);
            this.panInputs.Controls.Add(this.lbCustomerID);
            this.panInputs.Controls.Add(this.cstxtSurname);
            this.panInputs.Controls.Add(this.lbPhone);
            this.panInputs.Controls.Add(this.lbSurname);
            this.panInputs.Controls.Add(this.cstxtName);
            this.panInputs.Controls.Add(this.lbName);
            this.panInputs.Location = new System.Drawing.Point(1, 2);
            this.panInputs.Name = "panInputs";
            this.panInputs.Size = new System.Drawing.Size(1004, 183);
            this.panInputs.TabIndex = 0;
            // 
            // csbtnDelete
            // 
            this.csbtnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(163)))));
            this.csbtnDelete.BackgroundColor1 = System.Drawing.Color.BlueViolet;
            this.csbtnDelete.BorderColor1 = System.Drawing.Color.PaleVioletRed;
            this.csbtnDelete.BorderRadius1 = 25;
            this.csbtnDelete.BorderSize1 = 0;
            this.csbtnDelete.FlatAppearance.BorderSize = 0;
            this.csbtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.csbtnDelete.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.csbtnDelete.ForeColor = System.Drawing.Color.White;
            this.csbtnDelete.ForeColor1 = System.Drawing.Color.White;
            this.csbtnDelete.Location = new System.Drawing.Point(684, 113);
            this.csbtnDelete.Name = "csbtnDelete";
            this.csbtnDelete.Size = new System.Drawing.Size(301, 40);
            this.csbtnDelete.TabIndex = 2;
            this.csbtnDelete.Text = "Sil";
            this.csbtnDelete.UseVisualStyleBackColor = false;
            this.csbtnDelete.Click += new System.EventHandler(this.csbtnDelete_Click);
            // 
            // csbtnAdd
            // 
            this.csbtnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(163)))));
            this.csbtnAdd.BackgroundColor1 = System.Drawing.Color.BlueViolet;
            this.csbtnAdd.BorderColor1 = System.Drawing.Color.PaleVioletRed;
            this.csbtnAdd.BorderRadius1 = 25;
            this.csbtnAdd.BorderSize1 = 0;
            this.csbtnAdd.FlatAppearance.BorderSize = 0;
            this.csbtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.csbtnAdd.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.csbtnAdd.ForeColor = System.Drawing.Color.White;
            this.csbtnAdd.ForeColor1 = System.Drawing.Color.White;
            this.csbtnAdd.Location = new System.Drawing.Point(893, 60);
            this.csbtnAdd.Name = "csbtnAdd";
            this.csbtnAdd.Size = new System.Drawing.Size(92, 40);
            this.csbtnAdd.TabIndex = 2;
            this.csbtnAdd.Text = "Ekle";
            this.csbtnAdd.UseVisualStyleBackColor = false;
            this.csbtnAdd.Click += new System.EventHandler(this.csbtnAdd_Click);
            // 
            // cstxtCustomerID
            // 
            this.cstxtCustomerID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(156)))), ((int)(((byte)(89)))));
            this.cstxtCustomerID.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(156)))), ((int)(((byte)(89)))));
            this.cstxtCustomerID.borderColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(163)))));
            this.cstxtCustomerID.borderSize1 = 2;
            this.cstxtCustomerID.FocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.cstxtCustomerID.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cstxtCustomerID.font1 = null;
            this.cstxtCustomerID.ForeColor = System.Drawing.Color.DimGray;
            this.cstxtCustomerID.ForeColor1 = System.Drawing.Color.White;
            this.cstxtCustomerID.Location = new System.Drawing.Point(117, 116);
            this.cstxtCustomerID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cstxtCustomerID.Name = "cstxtCustomerID";
            this.cstxtCustomerID.Padding = new System.Windows.Forms.Padding(7);
            this.cstxtCustomerID.Size = new System.Drawing.Size(536, 35);
            this.cstxtCustomerID.TabIndex = 1;
            this.cstxtCustomerID.texts1 = "";
            this.cstxtCustomerID.Underlined = true;
            // 
            // cstxtPhone
            // 
            this.cstxtPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(156)))), ((int)(((byte)(89)))));
            this.cstxtPhone.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(156)))), ((int)(((byte)(89)))));
            this.cstxtPhone.borderColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(163)))));
            this.cstxtPhone.borderSize1 = 2;
            this.cstxtPhone.FocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.cstxtPhone.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cstxtPhone.font1 = null;
            this.cstxtPhone.ForeColor = System.Drawing.Color.DimGray;
            this.cstxtPhone.ForeColor1 = System.Drawing.Color.White;
            this.cstxtPhone.Location = new System.Drawing.Point(676, 58);
            this.cstxtPhone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cstxtPhone.Name = "cstxtPhone";
            this.cstxtPhone.Padding = new System.Windows.Forms.Padding(7);
            this.cstxtPhone.Size = new System.Drawing.Size(210, 35);
            this.cstxtPhone.TabIndex = 1;
            this.cstxtPhone.texts1 = "";
            this.cstxtPhone.Underlined = true;
            // 
            // lbCustomerID
            // 
            this.lbCustomerID.AutoSize = true;
            this.lbCustomerID.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCustomerID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(27)))), ((int)(((byte)(76)))));
            this.lbCustomerID.Location = new System.Drawing.Point(28, 129);
            this.lbCustomerID.Name = "lbCustomerID";
            this.lbCustomerID.Size = new System.Drawing.Size(82, 24);
            this.lbCustomerID.TabIndex = 0;
            this.lbCustomerID.Text = "Müşteri ID";
            // 
            // cstxtSurname
            // 
            this.cstxtSurname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(156)))), ((int)(((byte)(89)))));
            this.cstxtSurname.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(156)))), ((int)(((byte)(89)))));
            this.cstxtSurname.borderColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(163)))));
            this.cstxtSurname.borderSize1 = 2;
            this.cstxtSurname.FocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.cstxtSurname.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cstxtSurname.font1 = null;
            this.cstxtSurname.ForeColor = System.Drawing.Color.DimGray;
            this.cstxtSurname.ForeColor1 = System.Drawing.Color.White;
            this.cstxtSurname.Location = new System.Drawing.Point(348, 58);
            this.cstxtSurname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cstxtSurname.Name = "cstxtSurname";
            this.cstxtSurname.Padding = new System.Windows.Forms.Padding(7);
            this.cstxtSurname.Size = new System.Drawing.Size(238, 35);
            this.cstxtSurname.TabIndex = 1;
            this.cstxtSurname.texts1 = "";
            this.cstxtSurname.Underlined = true;
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(27)))), ((int)(((byte)(76)))));
            this.lbPhone.Location = new System.Drawing.Point(609, 69);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(60, 24);
            this.lbPhone.TabIndex = 0;
            this.lbPhone.Text = "Telefon";
            // 
            // lbSurname
            // 
            this.lbSurname.AutoSize = true;
            this.lbSurname.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSurname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(27)))), ((int)(((byte)(76)))));
            this.lbSurname.Location = new System.Drawing.Point(287, 69);
            this.lbSurname.Name = "lbSurname";
            this.lbSurname.Size = new System.Drawing.Size(54, 24);
            this.lbSurname.TabIndex = 0;
            this.lbSurname.Text = "Soyad";
            // 
            // cstxtName
            // 
            this.cstxtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(156)))), ((int)(((byte)(89)))));
            this.cstxtName.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(156)))), ((int)(((byte)(89)))));
            this.cstxtName.borderColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(163)))));
            this.cstxtName.borderSize1 = 2;
            this.cstxtName.FocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.cstxtName.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cstxtName.font1 = null;
            this.cstxtName.ForeColor = System.Drawing.Color.DimGray;
            this.cstxtName.ForeColor1 = System.Drawing.Color.White;
            this.cstxtName.Location = new System.Drawing.Point(63, 58);
            this.cstxtName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cstxtName.Name = "cstxtName";
            this.cstxtName.Padding = new System.Windows.Forms.Padding(7);
            this.cstxtName.Size = new System.Drawing.Size(205, 35);
            this.cstxtName.TabIndex = 1;
            this.cstxtName.texts1 = "";
            this.cstxtName.Underlined = true;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(27)))), ((int)(((byte)(76)))));
            this.lbName.Location = new System.Drawing.Point(28, 69);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(28, 24);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "Ad";
            // 
            // dtgrdCostumers
            // 
            this.dtgrdCostumers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgrdCostumers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrdCostumers.Location = new System.Drawing.Point(12, 204);
            this.dtgrdCostumers.Name = "dtgrdCostumers";
            this.dtgrdCostumers.Size = new System.Drawing.Size(974, 381);
            this.dtgrdCostumers.TabIndex = 2;
            this.dtgrdCostumers.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrdCostumers_CellDoubleClick);
            // 
            // frmCostumersList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(998, 597);
            this.Controls.Add(this.dtgrdCostumers);
            this.Controls.Add(this.panTop);
            this.Controls.Add(this.panInputs);
            this.Name = "frmCostumersList";
            this.Text = "Costumers List";
            this.Load += new System.EventHandler(this.frmCostumersList_Load);
            this.panTop.ResumeLayout(false);
            this.panTop.PerformLayout();
            this.panBack.ResumeLayout(false);
            this.panInputs.ResumeLayout(false);
            this.panInputs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdCostumers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panTop;
        private System.Windows.Forms.Panel panInputs;
        private System.Windows.Forms.DataGridView dtgrdCostumers;
        private CRM_Interface.Custom_Controls.CustomTextBox cstxtName;
        private System.Windows.Forms.Label lbName;
        private CRM_Interface.Custom_Controls.CustomTextBox cstxtSurname;
        private System.Windows.Forms.Label lbSurname;
        private CRM_Interface.Custom_Controls.CustomTextBox cstxtPhone;
        private System.Windows.Forms.Label lbPhone;
        private CRM_Interface.Custom_Controls.CustomButton csbtnAdd;
        private CRM_Interface.Custom_Controls.CustomButton csbtnDelete;
        private CRM_Interface.Custom_Controls.CustomTextBox cstxtCustomerID;
        private System.Windows.Forms.Label lbCustomerID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panBack;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
    }
}