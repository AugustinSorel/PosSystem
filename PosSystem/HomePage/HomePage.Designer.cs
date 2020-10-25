namespace PosSystem
{
    partial class HomePage
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblItemIDDisplay = new System.Windows.Forms.Label();
            this.lblItemID = new System.Windows.Forms.Label();
            this.pictureBoxItem = new System.Windows.Forms.PictureBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxItem)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(75)))), ((int)(((byte)(100)))));
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(118, 75);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(595, 317);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.chart1);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.groupBox1.Location = new System.Drawing.Point(0, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(827, 470);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Graph";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(75)))), ((int)(((byte)(100)))));
            this.comboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Week",
            "Month"});
            this.comboBox1.Location = new System.Drawing.Point(700, 419);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(329, 413);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Total Per Week: 0£";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(329, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "View";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.listView1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.groupBox2.Location = new System.Drawing.Point(10, 494);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(816, 380);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Notification";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button1.Location = new System.Drawing.Point(697, 240);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 38);
            this.button1.TabIndex = 38;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(75)))), ((int)(((byte)(100)))));
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.textBox1.Location = new System.Drawing.Point(557, 240);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(68, 30);
            this.textBox1.TabIndex = 37;
            this.textBox1.Text = "5";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.label8.Location = new System.Drawing.Point(359, 245);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 25);
            this.label8.TabIndex = 36;
            this.label8.Text = "Range Items: ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.lblItemIDDisplay);
            this.groupBox3.Controls.Add(this.lblItemID);
            this.groupBox3.Controls.Add(this.pictureBoxItem);
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.groupBox3.Location = new System.Drawing.Point(371, 49);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(424, 136);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Item Description";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.label6.Location = new System.Drawing.Point(380, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 25);
            this.label6.TabIndex = 35;
            this.label6.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.label7.Location = new System.Drawing.Point(149, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 25);
            this.label7.TabIndex = 34;
            this.label7.Text = "Stock Min:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.label4.Location = new System.Drawing.Point(380, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 25);
            this.label4.TabIndex = 33;
            this.label4.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.label5.Location = new System.Drawing.Point(137, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 25);
            this.label5.TabIndex = 32;
            this.label5.Text = "Current Stock:";
            // 
            // lblItemIDDisplay
            // 
            this.lblItemIDDisplay.AutoSize = true;
            this.lblItemIDDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblItemIDDisplay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.lblItemIDDisplay.Location = new System.Drawing.Point(380, 19);
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
            this.lblItemID.Location = new System.Drawing.Point(169, 19);
            this.lblItemID.Name = "lblItemID";
            this.lblItemID.Size = new System.Drawing.Size(74, 25);
            this.lblItemID.TabIndex = 30;
            this.lblItemID.Text = "ItemID:";
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
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.Window;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.ForeColor = System.Drawing.Color.Black;
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(6, 49);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(324, 221);
            this.listView1.TabIndex = 8;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.Click += new System.EventHandler(this.ListView1_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ItemID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Current Stock";
            this.columnHeader2.Width = 89;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Stock Min";
            this.columnHeader3.Width = 95;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.Location = new System.Drawing.Point(366, 308);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "items";
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(75)))), ((int)(((byte)(100)))));
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "HomePage";
            this.Size = new System.Drawing.Size(847, 877);
            this.Load += new System.EventHandler(this.HomePage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxItem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        public System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label lblItemIDDisplay;
        public System.Windows.Forms.Label lblItemID;
        public System.Windows.Forms.PictureBox pictureBoxItem;
        public System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
    }
}
