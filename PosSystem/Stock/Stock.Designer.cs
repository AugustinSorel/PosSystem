namespace PosSystem
{
    partial class Stock
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.labelBarcode = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtboxQuantity = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblFinalPrice = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCoef = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtBoxPurchacePrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.textBoxStockMax = new System.Windows.Forms.TextBox();
            this.labelStockMax = new System.Windows.Forms.Label();
            this.textBoxStockMin = new System.Windows.Forms.TextBox();
            this.lblStockMin = new System.Windows.Forms.Label();
            this.lblSupplierID = new System.Windows.Forms.Label();
            this.TxtBoxDescrption = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.BtnBrowse = new System.Windows.Forms.Button();
            this.pictureBoxItem = new System.Windows.Forms.PictureBox();
            this.BtnEnable = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lblNumberOfItems = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.BtnGroupByPrice = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.BtnGroupStockQuantity = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TxtBoxSearchName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.EnableGroupBoxGroupBy = new System.Windows.Forms.Button();
            this.ResetGroupBoxGroupBy = new System.Windows.Forms.Button();
            this.BtnSearchNameReset = new System.Windows.Forms.Button();
            this.BtnSearchNameEnable = new System.Windows.Forms.Button();
            this.BtnSearchNameSearch = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxItem)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(75)))), ((int)(((byte)(100)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(837, 178);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox6);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.BtnEnable);
            this.panel1.Controls.Add(this.BtnSave);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Location = new System.Drawing.Point(34, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1038, 464);
            this.panel1.TabIndex = 3;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.labelBarcode);
            this.groupBox6.Enabled = false;
            this.groupBox6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.groupBox6.Location = new System.Drawing.Point(687, 218);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(339, 162);
            this.groupBox6.TabIndex = 16;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Barcode";
            // 
            // labelBarcode
            // 
            this.labelBarcode.AutoSize = true;
            this.labelBarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.labelBarcode.Location = new System.Drawing.Point(69, 72);
            this.labelBarcode.Name = "labelBarcode";
            this.labelBarcode.Size = new System.Drawing.Size(226, 25);
            this.labelBarcode.TabIndex = 3;
            this.labelBarcode.Text = "Barcode: xxxxxxxxxxxxx";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtboxQuantity);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Enabled = false;
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.groupBox2.Location = new System.Drawing.Point(687, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(339, 162);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add Sotck";
            // 
            // txtboxQuantity
            // 
            this.txtboxQuantity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(75)))), ((int)(((byte)(100)))));
            this.txtboxQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.txtboxQuantity.Location = new System.Drawing.Point(218, 91);
            this.txtboxQuantity.Name = "txtboxQuantity";
            this.txtboxQuantity.Size = new System.Drawing.Size(77, 20);
            this.txtboxQuantity.TabIndex = 4;
            this.txtboxQuantity.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(15, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Quantity:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lblFinalPrice);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtCoef);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.TxtBoxPurchacePrice);
            this.groupBox1.Controls.Add(this.lblPrice);
            this.groupBox1.Controls.Add(this.textBoxStockMax);
            this.groupBox1.Controls.Add(this.labelStockMax);
            this.groupBox1.Controls.Add(this.textBoxStockMin);
            this.groupBox1.Controls.Add(this.lblStockMin);
            this.groupBox1.Controls.Add(this.lblSupplierID);
            this.groupBox1.Controls.Add(this.TxtBoxDescrption);
            this.groupBox1.Controls.Add(this.lblDescription);
            this.groupBox1.Controls.Add(this.BtnBrowse);
            this.groupBox1.Controls.Add(this.pictureBoxItem);
            this.groupBox1.Enabled = false;
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.groupBox1.Location = new System.Drawing.Point(16, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(654, 397);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create Item";
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(75)))), ((int)(((byte)(100)))));
            this.comboBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.comboBox2.Location = new System.Drawing.Point(398, 137);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(213, 21);
            this.comboBox2.TabIndex = 36;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(75)))), ((int)(((byte)(100)))));
            this.comboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.comboBox1.Location = new System.Drawing.Point(398, 92);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(213, 21);
            this.comboBox1.TabIndex = 32;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.label10.Location = new System.Drawing.Point(605, 174);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(23, 25);
            this.label10.TabIndex = 31;
            this.label10.Text = "£";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.label7.Location = new System.Drawing.Point(605, 224);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 25);
            this.label7.TabIndex = 30;
            this.label7.Text = "£";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.label6.Location = new System.Drawing.Point(605, 261);
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
            this.lblFinalPrice.Location = new System.Drawing.Point(482, 261);
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
            this.label4.Location = new System.Drawing.Point(146, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 25);
            this.label4.TabIndex = 27;
            this.label4.Text = "Selling Price";
            // 
            // txtCoef
            // 
            this.txtCoef.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(75)))), ((int)(((byte)(100)))));
            this.txtCoef.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.txtCoef.Location = new System.Drawing.Point(464, 224);
            this.txtCoef.Name = "txtCoef";
            this.txtCoef.Size = new System.Drawing.Size(55, 20);
            this.txtCoef.TabIndex = 26;
            this.txtCoef.TextChanged += new System.EventHandler(this.TxtCoef_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.label3.Location = new System.Drawing.Point(146, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 25);
            this.label3.TabIndex = 25;
            this.label3.Text = "Coefficient Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.label5.Location = new System.Drawing.Point(150, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 25);
            this.label5.TabIndex = 23;
            this.label5.Text = "Category ID";
            // 
            // TxtBoxPurchacePrice
            // 
            this.TxtBoxPurchacePrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(75)))), ((int)(((byte)(100)))));
            this.TxtBoxPurchacePrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.TxtBoxPurchacePrice.Location = new System.Drawing.Point(464, 180);
            this.TxtBoxPurchacePrice.Name = "TxtBoxPurchacePrice";
            this.TxtBoxPurchacePrice.Size = new System.Drawing.Size(55, 20);
            this.TxtBoxPurchacePrice.TabIndex = 22;
            this.TxtBoxPurchacePrice.TextChanged += new System.EventHandler(this.TxtBoxPurchacePrice_TextChanged);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.lblPrice.Location = new System.Drawing.Point(146, 180);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(144, 25);
            this.lblPrice.TabIndex = 21;
            this.lblPrice.Text = "Purchase Price";
            // 
            // textBoxStockMax
            // 
            this.textBoxStockMax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(75)))), ((int)(((byte)(100)))));
            this.textBoxStockMax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.textBoxStockMax.Location = new System.Drawing.Point(471, 346);
            this.textBoxStockMax.Name = "textBoxStockMax";
            this.textBoxStockMax.Size = new System.Drawing.Size(55, 20);
            this.textBoxStockMax.TabIndex = 14;
            // 
            // labelStockMax
            // 
            this.labelStockMax.AutoSize = true;
            this.labelStockMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.labelStockMax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.labelStockMax.Location = new System.Drawing.Point(153, 346);
            this.labelStockMax.Name = "labelStockMax";
            this.labelStockMax.Size = new System.Drawing.Size(105, 25);
            this.labelStockMax.TabIndex = 13;
            this.labelStockMax.Text = "Stock Max";
            // 
            // textBoxStockMin
            // 
            this.textBoxStockMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(75)))), ((int)(((byte)(100)))));
            this.textBoxStockMin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.textBoxStockMin.Location = new System.Drawing.Point(471, 307);
            this.textBoxStockMin.Name = "textBoxStockMin";
            this.textBoxStockMin.Size = new System.Drawing.Size(55, 20);
            this.textBoxStockMin.TabIndex = 12;
            // 
            // lblStockMin
            // 
            this.lblStockMin.AutoSize = true;
            this.lblStockMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblStockMin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.lblStockMin.Location = new System.Drawing.Point(153, 307);
            this.lblStockMin.Name = "lblStockMin";
            this.lblStockMin.Size = new System.Drawing.Size(99, 25);
            this.lblStockMin.TabIndex = 11;
            this.lblStockMin.Text = "Stock Min";
            // 
            // lblSupplierID
            // 
            this.lblSupplierID.AutoSize = true;
            this.lblSupplierID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblSupplierID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.lblSupplierID.Location = new System.Drawing.Point(150, 93);
            this.lblSupplierID.Name = "lblSupplierID";
            this.lblSupplierID.Size = new System.Drawing.Size(108, 25);
            this.lblSupplierID.TabIndex = 5;
            this.lblSupplierID.Text = "Supplier ID";
            // 
            // TxtBoxDescrption
            // 
            this.TxtBoxDescrption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(75)))), ((int)(((byte)(100)))));
            this.TxtBoxDescrption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.TxtBoxDescrption.Location = new System.Drawing.Point(398, 19);
            this.TxtBoxDescrption.Multiline = true;
            this.TxtBoxDescrption.Name = "TxtBoxDescrption";
            this.TxtBoxDescrption.Size = new System.Drawing.Size(213, 50);
            this.TxtBoxDescrption.TabIndex = 4;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.lblDescription.Location = new System.Drawing.Point(150, 44);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(156, 25);
            this.lblDescription.TabIndex = 3;
            this.lblDescription.Text = "Item Description ";
            // 
            // BtnBrowse
            // 
            this.BtnBrowse.FlatAppearance.BorderSize = 0;
            this.BtnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.BtnBrowse.Location = new System.Drawing.Point(20, 137);
            this.BtnBrowse.Name = "BtnBrowse";
            this.BtnBrowse.Size = new System.Drawing.Size(100, 33);
            this.BtnBrowse.TabIndex = 1;
            this.BtnBrowse.Text = "Browse";
            this.BtnBrowse.UseVisualStyleBackColor = true;
            this.BtnBrowse.Click += new System.EventHandler(this.BtnBrowse_Click);
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
            // BtnEnable
            // 
            this.BtnEnable.FlatAppearance.BorderSize = 0;
            this.BtnEnable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEnable.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.BtnEnable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.BtnEnable.Location = new System.Drawing.Point(795, 417);
            this.BtnEnable.Name = "BtnEnable";
            this.BtnEnable.Size = new System.Drawing.Size(100, 33);
            this.BtnEnable.TabIndex = 1;
            this.BtnEnable.Text = "Enable";
            this.BtnEnable.UseVisualStyleBackColor = true;
            this.BtnEnable.Click += new System.EventHandler(this.BtnEnable_Click_1);
            // 
            // BtnSave
            // 
            this.BtnSave.FlatAppearance.BorderSize = 0;
            this.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.BtnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.BtnSave.Location = new System.Drawing.Point(926, 417);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(100, 33);
            this.BtnSave.TabIndex = 1;
            this.BtnSave.Text = "Update";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click_1);
            // 
            // btnCancel
            // 
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.btnCancel.Location = new System.Drawing.Point(36, 417);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 33);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click_1);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox5);
            this.panel2.Controls.Add(this.groupBox4);
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Controls.Add(this.EnableGroupBoxGroupBy);
            this.panel2.Controls.Add(this.ResetGroupBoxGroupBy);
            this.panel2.Controls.Add(this.BtnSearchNameReset);
            this.panel2.Controls.Add(this.BtnSearchNameEnable);
            this.panel2.Controls.Add(this.BtnSearchNameSearch);
            this.panel2.Location = new System.Drawing.Point(190, 488);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(739, 352);
            this.panel2.TabIndex = 6;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lblNumberOfItems);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.groupBox5.Location = new System.Drawing.Point(24, 269);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(681, 70);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Number of items";
            // 
            // lblNumberOfItems
            // 
            this.lblNumberOfItems.AutoSize = true;
            this.lblNumberOfItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblNumberOfItems.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.lblNumberOfItems.Location = new System.Drawing.Point(536, 27);
            this.lblNumberOfItems.Name = "lblNumberOfItems";
            this.lblNumberOfItems.Size = new System.Drawing.Size(23, 25);
            this.lblNumberOfItems.TabIndex = 7;
            this.lblNumberOfItems.Text = "?";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.label9.Location = new System.Drawing.Point(10, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(158, 25);
            this.label9.TabIndex = 7;
            this.label9.Text = "Number of items ";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.BtnGroupByPrice);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.BtnGroupStockQuantity);
            this.groupBox4.Enabled = false;
            this.groupBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.groupBox4.Location = new System.Drawing.Point(24, 139);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(681, 70);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Order by";
            // 
            // BtnGroupByPrice
            // 
            this.BtnGroupByPrice.FlatAppearance.BorderSize = 0;
            this.BtnGroupByPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGroupByPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.BtnGroupByPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.BtnGroupByPrice.Location = new System.Drawing.Point(556, 19);
            this.BtnGroupByPrice.Name = "BtnGroupByPrice";
            this.BtnGroupByPrice.Size = new System.Drawing.Size(100, 38);
            this.BtnGroupByPrice.TabIndex = 6;
            this.BtnGroupByPrice.Text = "Price";
            this.BtnGroupByPrice.UseVisualStyleBackColor = true;
            this.BtnGroupByPrice.Click += new System.EventHandler(this.BtnGroupByPrice_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.label8.Location = new System.Drawing.Point(10, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 25);
            this.label8.TabIndex = 1;
            this.label8.Text = "Order by: ";
            // 
            // BtnGroupStockQuantity
            // 
            this.BtnGroupStockQuantity.FlatAppearance.BorderSize = 0;
            this.BtnGroupStockQuantity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGroupStockQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.BtnGroupStockQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.BtnGroupStockQuantity.Location = new System.Drawing.Point(382, 19);
            this.BtnGroupStockQuantity.Name = "BtnGroupStockQuantity";
            this.BtnGroupStockQuantity.Size = new System.Drawing.Size(159, 38);
            this.BtnGroupStockQuantity.TabIndex = 5;
            this.BtnGroupStockQuantity.Text = "StockQuantity";
            this.BtnGroupStockQuantity.UseVisualStyleBackColor = true;
            this.BtnGroupStockQuantity.Click += new System.EventHandler(this.BtnGroupStockQuantity_Click);
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
            this.groupBox3.Text = "Search Item";
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
            this.label1.Location = new System.Drawing.Point(7, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search by bar code: ";
            // 
            // EnableGroupBoxGroupBy
            // 
            this.EnableGroupBoxGroupBy.FlatAppearance.BorderSize = 0;
            this.EnableGroupBoxGroupBy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EnableGroupBoxGroupBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.EnableGroupBoxGroupBy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.EnableGroupBoxGroupBy.Location = new System.Drawing.Point(456, 215);
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
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.button1.Location = new System.Drawing.Point(862, 109);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 74);
            this.button1.TabIndex = 1;
            this.button1.Text = "Save to Excel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Location = new System.Drawing.Point(50, 848);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(982, 198);
            this.panel3.TabIndex = 7;
            // 
            // Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(75)))), ((int)(((byte)(100)))));
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Stock";
            this.Size = new System.Drawing.Size(1094, 1049);
            this.Load += new System.EventHandler(this.Stock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxItem)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.TextBox txtboxQuantity;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TextBox textBoxStockMax;
        public System.Windows.Forms.Label labelStockMax;
        public System.Windows.Forms.TextBox textBoxStockMin;
        public System.Windows.Forms.Label lblStockMin;
        public System.Windows.Forms.Label lblSupplierID;
        public System.Windows.Forms.TextBox TxtBoxDescrption;
        public System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Button BtnBrowse;
        public System.Windows.Forms.PictureBox pictureBoxItem;
        private System.Windows.Forms.Button BtnEnable;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox5;
        public System.Windows.Forms.Label lblNumberOfItems;
        public System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox4;
        public System.Windows.Forms.Button BtnGroupByPrice;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Button BtnGroupStockQuantity;
        private System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.TextBox TxtBoxSearchName;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button EnableGroupBoxGroupBy;
        public System.Windows.Forms.Button ResetGroupBoxGroupBy;
        public System.Windows.Forms.Button BtnSearchNameReset;
        public System.Windows.Forms.Button BtnSearchNameEnable;
        public System.Windows.Forms.Button BtnSearchNameSearch;
        public System.Windows.Forms.Label lblFinalPrice;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtCoef;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox TxtBoxPurchacePrice;
        public System.Windows.Forms.Label lblPrice;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.ComboBox comboBox1;
        public System.Windows.Forms.ComboBox comboBox2;
        public System.Windows.Forms.GroupBox groupBox6;
        public System.Windows.Forms.Label labelBarcode;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel3;
    }
}
