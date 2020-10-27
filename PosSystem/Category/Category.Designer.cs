namespace PosSystem
{
    partial class Category
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.BtnGroupByName = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TxtBoxSearchName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.EnableGroupBoxGroupBy = new System.Windows.Forms.Button();
            this.ResetGroupBoxGroupBy = new System.Windows.Forms.Button();
            this.BtnSearchNameReset = new System.Windows.Forms.Button();
            this.BtnSearchNameEnable = new System.Windows.Forms.Button();
            this.BtnSearchNameSearch = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnWorkerDetailsEnable = new System.Windows.Forms.Button();
            this.BtnWorkerSecurityUpdate = new System.Windows.Forms.Button();
            this.BtnWorkerDetailsUpdate = new System.Windows.Forms.Button();
            this.BtnWorkerDetailsCancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtBoxDescription = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtboxName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(24, 486);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(357, 212);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox4);
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Controls.Add(this.EnableGroupBoxGroupBy);
            this.panel2.Controls.Add(this.ResetGroupBoxGroupBy);
            this.panel2.Controls.Add(this.BtnSearchNameReset);
            this.panel2.Controls.Add(this.BtnSearchNameEnable);
            this.panel2.Controls.Add(this.BtnSearchNameSearch);
            this.panel2.Location = new System.Drawing.Point(189, 441);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(739, 257);
            this.panel2.TabIndex = 7;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.BtnGroupByName);
            this.groupBox4.Enabled = false;
            this.groupBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.groupBox4.Location = new System.Drawing.Point(24, 139);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(681, 70);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Search by";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.label8.Location = new System.Drawing.Point(10, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 25);
            this.label8.TabIndex = 1;
            this.label8.Text = "Group by: ";
            // 
            // BtnGroupByName
            // 
            this.BtnGroupByName.FlatAppearance.BorderSize = 0;
            this.BtnGroupByName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGroupByName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.BtnGroupByName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.BtnGroupByName.Location = new System.Drawing.Point(572, 19);
            this.BtnGroupByName.Name = "BtnGroupByName";
            this.BtnGroupByName.Size = new System.Drawing.Size(83, 38);
            this.BtnGroupByName.TabIndex = 5;
            this.BtnGroupByName.Text = "Name";
            this.BtnGroupByName.UseVisualStyleBackColor = true;
            this.BtnGroupByName.Click += new System.EventHandler(this.BtnGroupByName_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.TxtBoxSearchName);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Enabled = false;
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.groupBox3.Location = new System.Drawing.Point(27, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(681, 70);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Search worker";
            // 
            // TxtBoxSearchName
            // 
            this.TxtBoxSearchName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(75)))), ((int)(((byte)(100)))));
            this.TxtBoxSearchName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.TxtBoxSearchName.Location = new System.Drawing.Point(429, 31);
            this.TxtBoxSearchName.Name = "TxtBoxSearchName";
            this.TxtBoxSearchName.Size = new System.Drawing.Size(213, 20);
            this.TxtBoxSearchName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.label1.Location = new System.Drawing.Point(216, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search by name";
            // 
            // EnableGroupBoxGroupBy
            // 
            this.EnableGroupBoxGroupBy.FlatAppearance.BorderSize = 0;
            this.EnableGroupBoxGroupBy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EnableGroupBoxGroupBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.EnableGroupBoxGroupBy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.EnableGroupBoxGroupBy.Location = new System.Drawing.Point(596, 215);
            this.EnableGroupBoxGroupBy.Name = "EnableGroupBoxGroupBy";
            this.EnableGroupBoxGroupBy.Size = new System.Drawing.Size(83, 38);
            this.EnableGroupBoxGroupBy.TabIndex = 5;
            this.EnableGroupBoxGroupBy.Text = "Enable";
            this.EnableGroupBoxGroupBy.UseVisualStyleBackColor = true;
            this.EnableGroupBoxGroupBy.Click += new System.EventHandler(this.EnableGroupBoxGroupBy_Click);
            // 
            // ResetGroupBoxGroupBy
            // 
            this.ResetGroupBoxGroupBy.FlatAppearance.BorderSize = 0;
            this.ResetGroupBoxGroupBy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResetGroupBoxGroupBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.ResetGroupBoxGroupBy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.ResetGroupBoxGroupBy.Location = new System.Drawing.Point(39, 215);
            this.ResetGroupBoxGroupBy.Name = "ResetGroupBoxGroupBy";
            this.ResetGroupBoxGroupBy.Size = new System.Drawing.Size(83, 38);
            this.ResetGroupBoxGroupBy.TabIndex = 5;
            this.ResetGroupBoxGroupBy.Text = "Reset";
            this.ResetGroupBoxGroupBy.UseVisualStyleBackColor = true;
            this.ResetGroupBoxGroupBy.Click += new System.EventHandler(this.ResetGroupBoxGroupBy_Click);
            // 
            // BtnSearchNameReset
            // 
            this.BtnSearchNameReset.FlatAppearance.BorderSize = 0;
            this.BtnSearchNameReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSearchNameReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.BtnSearchNameReset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.BtnSearchNameReset.Location = new System.Drawing.Point(27, 95);
            this.BtnSearchNameReset.Name = "BtnSearchNameReset";
            this.BtnSearchNameReset.Size = new System.Drawing.Size(83, 38);
            this.BtnSearchNameReset.TabIndex = 5;
            this.BtnSearchNameReset.Text = "Reset";
            this.BtnSearchNameReset.UseVisualStyleBackColor = true;
            this.BtnSearchNameReset.Click += new System.EventHandler(this.BtnSearchNameReset_Click);
            // 
            // BtnSearchNameEnable
            // 
            this.BtnSearchNameEnable.FlatAppearance.BorderSize = 0;
            this.BtnSearchNameEnable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSearchNameEnable.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.BtnSearchNameEnable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.BtnSearchNameEnable.Location = new System.Drawing.Point(456, 95);
            this.BtnSearchNameEnable.Name = "BtnSearchNameEnable";
            this.BtnSearchNameEnable.Size = new System.Drawing.Size(83, 38);
            this.BtnSearchNameEnable.TabIndex = 5;
            this.BtnSearchNameEnable.Text = "Enable";
            this.BtnSearchNameEnable.UseVisualStyleBackColor = true;
            this.BtnSearchNameEnable.Click += new System.EventHandler(this.BtnSearchNameEnable_Click);
            // 
            // BtnSearchNameSearch
            // 
            this.BtnSearchNameSearch.FlatAppearance.BorderSize = 0;
            this.BtnSearchNameSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSearchNameSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.BtnSearchNameSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.BtnSearchNameSearch.Location = new System.Drawing.Point(625, 95);
            this.BtnSearchNameSearch.Name = "BtnSearchNameSearch";
            this.BtnSearchNameSearch.Size = new System.Drawing.Size(83, 38);
            this.BtnSearchNameSearch.TabIndex = 5;
            this.BtnSearchNameSearch.Text = "Search";
            this.BtnSearchNameSearch.UseVisualStyleBackColor = true;
            this.BtnSearchNameSearch.Click += new System.EventHandler(this.BtnSearchNameSearch_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnWorkerDetailsEnable);
            this.panel1.Controls.Add(this.BtnWorkerSecurityUpdate);
            this.panel1.Controls.Add(this.BtnWorkerDetailsUpdate);
            this.panel1.Controls.Add(this.BtnWorkerDetailsCancel);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(798, 368);
            this.panel1.TabIndex = 6;
            // 
            // BtnWorkerDetailsEnable
            // 
            this.BtnWorkerDetailsEnable.FlatAppearance.BorderSize = 0;
            this.BtnWorkerDetailsEnable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnWorkerDetailsEnable.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.BtnWorkerDetailsEnable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.BtnWorkerDetailsEnable.Location = new System.Drawing.Point(437, 310);
            this.BtnWorkerDetailsEnable.Name = "BtnWorkerDetailsEnable";
            this.BtnWorkerDetailsEnable.Size = new System.Drawing.Size(100, 38);
            this.BtnWorkerDetailsEnable.TabIndex = 3;
            this.BtnWorkerDetailsEnable.Text = "Enable";
            this.BtnWorkerDetailsEnable.UseVisualStyleBackColor = true;
            this.BtnWorkerDetailsEnable.Click += new System.EventHandler(this.BtnWorkerDetailsEnable_Click);
            // 
            // BtnWorkerSecurityUpdate
            // 
            this.BtnWorkerSecurityUpdate.FlatAppearance.BorderSize = 0;
            this.BtnWorkerSecurityUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnWorkerSecurityUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.BtnWorkerSecurityUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.BtnWorkerSecurityUpdate.Location = new System.Drawing.Point(919, 356);
            this.BtnWorkerSecurityUpdate.Name = "BtnWorkerSecurityUpdate";
            this.BtnWorkerSecurityUpdate.Size = new System.Drawing.Size(100, 38);
            this.BtnWorkerSecurityUpdate.TabIndex = 3;
            this.BtnWorkerSecurityUpdate.Text = "Update";
            this.BtnWorkerSecurityUpdate.UseVisualStyleBackColor = true;
            // 
            // BtnWorkerDetailsUpdate
            // 
            this.BtnWorkerDetailsUpdate.FlatAppearance.BorderSize = 0;
            this.BtnWorkerDetailsUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnWorkerDetailsUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.BtnWorkerDetailsUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.BtnWorkerDetailsUpdate.Location = new System.Drawing.Point(555, 310);
            this.BtnWorkerDetailsUpdate.Name = "BtnWorkerDetailsUpdate";
            this.BtnWorkerDetailsUpdate.Size = new System.Drawing.Size(100, 38);
            this.BtnWorkerDetailsUpdate.TabIndex = 3;
            this.BtnWorkerDetailsUpdate.Text = "Update";
            this.BtnWorkerDetailsUpdate.UseVisualStyleBackColor = true;
            this.BtnWorkerDetailsUpdate.Click += new System.EventHandler(this.BtnWorkerDetailsUpdate_Click);
            // 
            // BtnWorkerDetailsCancel
            // 
            this.BtnWorkerDetailsCancel.FlatAppearance.BorderSize = 0;
            this.BtnWorkerDetailsCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnWorkerDetailsCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.BtnWorkerDetailsCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.BtnWorkerDetailsCancel.Location = new System.Drawing.Point(128, 310);
            this.BtnWorkerDetailsCancel.Name = "BtnWorkerDetailsCancel";
            this.BtnWorkerDetailsCancel.Size = new System.Drawing.Size(100, 38);
            this.BtnWorkerDetailsCancel.TabIndex = 3;
            this.BtnWorkerDetailsCancel.Text = "Cancel";
            this.BtnWorkerDetailsCancel.UseVisualStyleBackColor = true;
            this.BtnWorkerDetailsCancel.Click += new System.EventHandler(this.BtnWorkerDetailsCancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TxtBoxDescription);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtboxName);
            this.groupBox1.Enabled = false;
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.groupBox1.Location = new System.Drawing.Point(128, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(527, 259);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Category Details";
            // 
            // TxtBoxDescription
            // 
            this.TxtBoxDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(75)))), ((int)(((byte)(100)))));
            this.TxtBoxDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.TxtBoxDescription.Location = new System.Drawing.Point(235, 155);
            this.TxtBoxDescription.Multiline = true;
            this.TxtBoxDescription.Name = "TxtBoxDescription";
            this.TxtBoxDescription.Size = new System.Drawing.Size(213, 70);
            this.TxtBoxDescription.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.label4.Location = new System.Drawing.Point(56, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.label3.Location = new System.Drawing.Point(56, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Description:";
            // 
            // txtboxName
            // 
            this.txtboxName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(75)))), ((int)(((byte)(100)))));
            this.txtboxName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.txtboxName.Location = new System.Drawing.Point(235, 89);
            this.txtboxName.Name = "txtboxName";
            this.txtboxName.Size = new System.Drawing.Size(213, 20);
            this.txtboxName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.label2.Location = new System.Drawing.Point(56, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Id:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.label5.Location = new System.Drawing.Point(313, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "0";
            // 
            // Category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(75)))), ((int)(((byte)(100)))));
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Category";
            this.Size = new System.Drawing.Size(928, 724);
            this.Load += new System.EventHandler(this.Category_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox4;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Button BtnGroupByName;
        private System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.TextBox TxtBoxSearchName;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button EnableGroupBoxGroupBy;
        public System.Windows.Forms.Button ResetGroupBoxGroupBy;
        public System.Windows.Forms.Button BtnSearchNameReset;
        public System.Windows.Forms.Button BtnSearchNameEnable;
        public System.Windows.Forms.Button BtnSearchNameSearch;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button BtnWorkerDetailsEnable;
        public System.Windows.Forms.Button BtnWorkerSecurityUpdate;
        public System.Windows.Forms.Button BtnWorkerDetailsUpdate;
        public System.Windows.Forms.Button BtnWorkerDetailsCancel;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TextBox TxtBoxDescription;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtboxName;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.Label label5;
    }
}
