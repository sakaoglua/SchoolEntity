namespace EducationEntity
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
            this.dgwSchool = new System.Windows.Forms.DataGridView();
            this.gbxAdd = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtboxType = new System.Windows.Forms.TextBox();
            this.txtboxDistrict = new System.Windows.Forms.TextBox();
            this.txtboxCity = new System.Windows.Forms.TextBox();
            this.txtboxName = new System.Windows.Forms.TextBox();
            this.lblType = new System.Windows.Forms.Label();
            this.lblDistrict = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.gbxUpdate = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtboxUType = new System.Windows.Forms.TextBox();
            this.txtboxUDistrict = new System.Windows.Forms.TextBox();
            this.lblUType = new System.Windows.Forms.Label();
            this.txtboxUCity = new System.Windows.Forms.TextBox();
            this.lblUDistrict = new System.Windows.Forms.Label();
            this.txtboxUName = new System.Windows.Forms.TextBox();
            this.lblUName = new System.Windows.Forms.Label();
            this.lblUCity = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwSchool)).BeginInit();
            this.gbxAdd.SuspendLayout();
            this.gbxUpdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwSchool
            // 
            this.dgwSchool.BackgroundColor = System.Drawing.SystemColors.MenuHighlight;
            this.dgwSchool.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwSchool.Location = new System.Drawing.Point(12, 12);
            this.dgwSchool.Name = "dgwSchool";
            this.dgwSchool.Size = new System.Drawing.Size(776, 172);
            this.dgwSchool.TabIndex = 0;
            this.dgwSchool.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwSchool_CellClick);
            // 
            // gbxAdd
            // 
            this.gbxAdd.BackColor = System.Drawing.Color.RosyBrown;
            this.gbxAdd.Controls.Add(this.btnAdd);
            this.gbxAdd.Controls.Add(this.txtboxType);
            this.gbxAdd.Controls.Add(this.txtboxDistrict);
            this.gbxAdd.Controls.Add(this.txtboxCity);
            this.gbxAdd.Controls.Add(this.txtboxName);
            this.gbxAdd.Controls.Add(this.lblType);
            this.gbxAdd.Controls.Add(this.lblDistrict);
            this.gbxAdd.Controls.Add(this.lblCity);
            this.gbxAdd.Controls.Add(this.lblName);
            this.gbxAdd.Location = new System.Drawing.Point(12, 190);
            this.gbxAdd.Name = "gbxAdd";
            this.gbxAdd.Size = new System.Drawing.Size(244, 202);
            this.gbxAdd.TabIndex = 1;
            this.gbxAdd.TabStop = false;
            this.gbxAdd.Text = "Add a school";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.LawnGreen;
            this.btnAdd.Location = new System.Drawing.Point(9, 146);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(108, 37);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtboxType
            // 
            this.txtboxType.Location = new System.Drawing.Point(48, 91);
            this.txtboxType.Name = "txtboxType";
            this.txtboxType.Size = new System.Drawing.Size(100, 20);
            this.txtboxType.TabIndex = 7;
            // 
            // txtboxDistrict
            // 
            this.txtboxDistrict.Location = new System.Drawing.Point(48, 65);
            this.txtboxDistrict.Name = "txtboxDistrict";
            this.txtboxDistrict.Size = new System.Drawing.Size(100, 20);
            this.txtboxDistrict.TabIndex = 6;
            // 
            // txtboxCity
            // 
            this.txtboxCity.Location = new System.Drawing.Point(48, 39);
            this.txtboxCity.Name = "txtboxCity";
            this.txtboxCity.Size = new System.Drawing.Size(100, 20);
            this.txtboxCity.TabIndex = 5;
            // 
            // txtboxName
            // 
            this.txtboxName.Location = new System.Drawing.Point(48, 13);
            this.txtboxName.Name = "txtboxName";
            this.txtboxName.Size = new System.Drawing.Size(100, 20);
            this.txtboxName.TabIndex = 4;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(3, 94);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(31, 13);
            this.lblType.TabIndex = 3;
            this.lblType.Text = "Type";
            // 
            // lblDistrict
            // 
            this.lblDistrict.AutoSize = true;
            this.lblDistrict.Location = new System.Drawing.Point(3, 68);
            this.lblDistrict.Name = "lblDistrict";
            this.lblDistrict.Size = new System.Drawing.Size(39, 13);
            this.lblDistrict.TabIndex = 2;
            this.lblDistrict.Text = "District";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(3, 42);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(24, 13);
            this.lblCity.TabIndex = 1;
            this.lblCity.Text = "City";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(3, 16);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // gbxUpdate
            // 
            this.gbxUpdate.BackColor = System.Drawing.Color.RosyBrown;
            this.gbxUpdate.Controls.Add(this.btnUpdate);
            this.gbxUpdate.Controls.Add(this.txtboxUType);
            this.gbxUpdate.Controls.Add(this.txtboxUDistrict);
            this.gbxUpdate.Controls.Add(this.lblUType);
            this.gbxUpdate.Controls.Add(this.txtboxUCity);
            this.gbxUpdate.Controls.Add(this.lblUDistrict);
            this.gbxUpdate.Controls.Add(this.txtboxUName);
            this.gbxUpdate.Controls.Add(this.lblUName);
            this.gbxUpdate.Controls.Add(this.lblUCity);
            this.gbxUpdate.Location = new System.Drawing.Point(346, 190);
            this.gbxUpdate.Name = "gbxUpdate";
            this.gbxUpdate.Size = new System.Drawing.Size(244, 202);
            this.gbxUpdate.TabIndex = 2;
            this.gbxUpdate.TabStop = false;
            this.gbxUpdate.Text = "Update a school";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.LawnGreen;
            this.btnUpdate.Location = new System.Drawing.Point(9, 146);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(108, 37);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtboxUType
            // 
            this.txtboxUType.Location = new System.Drawing.Point(47, 91);
            this.txtboxUType.Name = "txtboxUType";
            this.txtboxUType.Size = new System.Drawing.Size(100, 20);
            this.txtboxUType.TabIndex = 11;
            // 
            // txtboxUDistrict
            // 
            this.txtboxUDistrict.Location = new System.Drawing.Point(47, 65);
            this.txtboxUDistrict.Name = "txtboxUDistrict";
            this.txtboxUDistrict.Size = new System.Drawing.Size(100, 20);
            this.txtboxUDistrict.TabIndex = 10;
            // 
            // lblUType
            // 
            this.lblUType.AutoSize = true;
            this.lblUType.Location = new System.Drawing.Point(6, 94);
            this.lblUType.Name = "lblUType";
            this.lblUType.Size = new System.Drawing.Size(31, 13);
            this.lblUType.TabIndex = 7;
            this.lblUType.Text = "Type";
            // 
            // txtboxUCity
            // 
            this.txtboxUCity.Location = new System.Drawing.Point(47, 39);
            this.txtboxUCity.Name = "txtboxUCity";
            this.txtboxUCity.Size = new System.Drawing.Size(100, 20);
            this.txtboxUCity.TabIndex = 9;
            // 
            // lblUDistrict
            // 
            this.lblUDistrict.AutoSize = true;
            this.lblUDistrict.Location = new System.Drawing.Point(6, 68);
            this.lblUDistrict.Name = "lblUDistrict";
            this.lblUDistrict.Size = new System.Drawing.Size(39, 13);
            this.lblUDistrict.TabIndex = 6;
            this.lblUDistrict.Text = "District";
            // 
            // txtboxUName
            // 
            this.txtboxUName.Location = new System.Drawing.Point(46, 13);
            this.txtboxUName.Name = "txtboxUName";
            this.txtboxUName.Size = new System.Drawing.Size(100, 20);
            this.txtboxUName.TabIndex = 8;
            // 
            // lblUName
            // 
            this.lblUName.AutoSize = true;
            this.lblUName.Location = new System.Drawing.Point(6, 16);
            this.lblUName.Name = "lblUName";
            this.lblUName.Size = new System.Drawing.Size(35, 13);
            this.lblUName.TabIndex = 4;
            this.lblUName.Text = "Name";
            // 
            // lblUCity
            // 
            this.lblUCity.AutoSize = true;
            this.lblUCity.Location = new System.Drawing.Point(6, 42);
            this.lblUCity.Name = "lblUCity";
            this.lblUCity.Size = new System.Drawing.Size(24, 13);
            this.lblUCity.TabIndex = 5;
            this.lblUCity.Text = "City";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.LawnGreen;
            this.btnDelete.Location = new System.Drawing.Point(634, 336);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(108, 37);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.gbxUpdate);
            this.Controls.Add(this.gbxAdd);
            this.Controls.Add(this.dgwSchool);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwSchool)).EndInit();
            this.gbxAdd.ResumeLayout(false);
            this.gbxAdd.PerformLayout();
            this.gbxUpdate.ResumeLayout(false);
            this.gbxUpdate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwSchool;
        private System.Windows.Forms.GroupBox gbxAdd;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblDistrict;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.GroupBox gbxUpdate;
        private System.Windows.Forms.Label lblUType;
        private System.Windows.Forms.Label lblUDistrict;
        private System.Windows.Forms.Label lblUName;
        private System.Windows.Forms.Label lblUCity;
        private System.Windows.Forms.TextBox txtboxType;
        private System.Windows.Forms.TextBox txtboxDistrict;
        private System.Windows.Forms.TextBox txtboxCity;
        private System.Windows.Forms.TextBox txtboxName;
        private System.Windows.Forms.TextBox txtboxUType;
        private System.Windows.Forms.TextBox txtboxUDistrict;
        private System.Windows.Forms.TextBox txtboxUCity;
        private System.Windows.Forms.TextBox txtboxUName;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
    }
}

