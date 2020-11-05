namespace PosSystem
{
    partial class Order
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblSupplierID = new System.Windows.Forms.Label();
            this.BtnEnable = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.LblWorkerID = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblDescriptionDisplay = new System.Windows.Forms.Label();
            this.lblItemIDDisplay = new System.Windows.Forms.Label();
            this.lblItemID = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblFinalPrice = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.pictureBoxItem = new System.Windows.Forms.PictureBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxItem)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.BtnEnable);
            this.panel1.Controls.Add(this.BtnSave);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Location = new System.Drawing.Point(0, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(687, 309);
            this.panel1.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.lblSupplierID);
            this.groupBox1.Enabled = false;
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.groupBox1.Location = new System.Drawing.Point(16, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(654, 202);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create Item";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(75)))), ((int)(((byte)(100)))));
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.textBox1.Location = new System.Drawing.Point(485, 127);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(83, 20);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.label2.Location = new System.Drawing.Point(107, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Quantity:";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(75)))), ((int)(((byte)(100)))));
            this.comboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.comboBox1.Location = new System.Drawing.Point(355, 64);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(213, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // lblSupplierID
            // 
            this.lblSupplierID.AutoSize = true;
            this.lblSupplierID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblSupplierID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.lblSupplierID.Location = new System.Drawing.Point(107, 65);
            this.lblSupplierID.Name = "lblSupplierID";
            this.lblSupplierID.Size = new System.Drawing.Size(91, 25);
            this.lblSupplierID.TabIndex = 5;
            this.lblSupplierID.Text = "Barcode:";
            // 
            // BtnEnable
            // 
            this.BtnEnable.FlatAppearance.BorderSize = 0;
            this.BtnEnable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEnable.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.BtnEnable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.BtnEnable.Location = new System.Drawing.Point(464, 235);
            this.BtnEnable.Name = "BtnEnable";
            this.BtnEnable.Size = new System.Drawing.Size(100, 33);
            this.BtnEnable.TabIndex = 1;
            this.BtnEnable.Text = "Enable";
            this.BtnEnable.UseVisualStyleBackColor = true;
            this.BtnEnable.Click += new System.EventHandler(this.BtnEnable_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.FlatAppearance.BorderSize = 0;
            this.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.BtnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.BtnSave.Location = new System.Drawing.Point(570, 235);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(100, 33);
            this.BtnSave.TabIndex = 1;
            this.BtnSave.Text = "Add";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.btnCancel.Location = new System.Drawing.Point(16, 235);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 33);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(51, 33);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(372, 243);
            this.listView1.TabIndex = 16;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.Click += new System.EventHandler(this.ListView1_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Barcode";
            this.columnHeader1.Width = 92;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Quantity";
            this.columnHeader2.Width = 119;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Total Price";
            this.columnHeader3.Width = 97;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.button1.Location = new System.Drawing.Point(461, 243);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 33);
            this.button1.TabIndex = 1;
            this.button1.Text = "Order";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.checkBox1);
            this.panel2.Controls.Add(this.listView1);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(3, 318);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(592, 309);
            this.panel2.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.label1.Location = new System.Drawing.Point(643, 595);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Final Price:  0 £";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.LblWorkerID);
            this.panel3.Controls.Add(this.lblDate);
            this.panel3.Location = new System.Drawing.Point(622, 337);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(506, 54);
            this.panel3.TabIndex = 18;
            // 
            // LblWorkerID
            // 
            this.LblWorkerID.AutoSize = true;
            this.LblWorkerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.LblWorkerID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.LblWorkerID.Location = new System.Drawing.Point(5, 15);
            this.LblWorkerID.Name = "LblWorkerID";
            this.LblWorkerID.Size = new System.Drawing.Size(106, 25);
            this.LblWorkerID.TabIndex = 2;
            this.LblWorkerID.Text = "Worker ID:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.lblDate.Location = new System.Drawing.Point(272, 15);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(53, 25);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "Date";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblDescriptionDisplay);
            this.groupBox2.Controls.Add(this.lblItemIDDisplay);
            this.groupBox2.Controls.Add(this.lblItemID);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.lblFinalPrice);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.lblDescription);
            this.groupBox2.Controls.Add(this.pictureBoxItem);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.groupBox2.Location = new System.Drawing.Point(16, 633);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(654, 173);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Item Description";
            // 
            // lblDescriptionDisplay
            // 
            this.lblDescriptionDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblDescriptionDisplay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.lblDescriptionDisplay.Location = new System.Drawing.Point(495, 19);
            this.lblDescriptionDisplay.Name = "lblDescriptionDisplay";
            this.lblDescriptionDisplay.Size = new System.Drawing.Size(132, 62);
            this.lblDescriptionDisplay.TabIndex = 32;
            // 
            // lblItemIDDisplay
            // 
            this.lblItemIDDisplay.AutoSize = true;
            this.lblItemIDDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblItemIDDisplay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.lblItemIDDisplay.Location = new System.Drawing.Point(443, 144);
            this.lblItemIDDisplay.Name = "lblItemIDDisplay";
            this.lblItemIDDisplay.Size = new System.Drawing.Size(23, 25);
            this.lblItemIDDisplay.TabIndex = 31;
            this.lblItemIDDisplay.Text = "0";
            // 
            // lblItemID
            // 
            this.lblItemID.AutoSize = true;
            this.lblItemID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblItemID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.lblItemID.Location = new System.Drawing.Point(154, 145);
            this.lblItemID.Name = "lblItemID";
            this.lblItemID.Size = new System.Drawing.Size(91, 25);
            this.lblItemID.TabIndex = 30;
            this.lblItemID.Text = "Barcode:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.label6.Location = new System.Drawing.Point(613, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 25);
            this.label6.TabIndex = 29;
            this.label6.Text = "£";
            // 
            // lblFinalPrice
            // 
            this.lblFinalPrice.AutoSize = true;
            this.lblFinalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblFinalPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.lblFinalPrice.Location = new System.Drawing.Point(490, 94);
            this.lblFinalPrice.Name = "lblFinalPrice";
            this.lblFinalPrice.Size = new System.Drawing.Size(23, 25);
            this.lblFinalPrice.TabIndex = 28;
            this.lblFinalPrice.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.label4.Location = new System.Drawing.Point(154, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 25);
            this.label4.TabIndex = 27;
            this.label4.Text = "Selling Price:";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.lblDescription.Location = new System.Drawing.Point(154, 35);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(162, 25);
            this.lblDescription.TabIndex = 3;
            this.lblDescription.Text = "Item Description :";
            // 
            // pictureBoxItem
            // 
            this.pictureBoxItem.Location = new System.Drawing.Point(20, 19);
            this.pictureBoxItem.Name = "pictureBoxItem";
            this.pictureBoxItem.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxItem.TabIndex = 0;
            this.pictureBoxItem.TabStop = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.checkBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.checkBox1.Location = new System.Drawing.Point(438, 181);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(151, 29);
            this.checkBox1.TabIndex = 17;
            this.checkBox1.Text = "Save to Excel";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(75)))), ((int)(((byte)(100)))));
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Order";
            this.Size = new System.Drawing.Size(1131, 802);
            this.Load += new System.EventHandler(this.Order_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.ComboBox comboBox1;
        public System.Windows.Forms.Label lblSupplierID;
        private System.Windows.Forms.Button BtnEnable;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label LblWorkerID;
        private System.Windows.Forms.Label lblDate;
        public System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.Label lblDescriptionDisplay;
        public System.Windows.Forms.Label lblItemIDDisplay;
        public System.Windows.Forms.Label lblItemID;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label lblFinalPrice;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label lblDescription;
        public System.Windows.Forms.PictureBox pictureBoxItem;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}
