
namespace Labs
{
    partial class FormLab13
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
            this.FirstName = new System.Windows.Forms.TextBox();
            this.LastName = new System.Windows.Forms.TextBox();
            this.FatherName = new System.Windows.Forms.TextBox();
            this.ENamer = new System.Windows.Forms.Label();
            this.YearCount = new System.Windows.Forms.Label();
            this.Year = new System.Windows.Forms.Label();
            this.Inits = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CardPIB = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.labelFatherName = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // FirstName
            // 
            this.FirstName.Location = new System.Drawing.Point(6, 19);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(151, 20);
            this.FirstName.TabIndex = 0;
            this.FirstName.Text = "Артем";
            this.FirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FirstName.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // LastName
            // 
            this.LastName.Location = new System.Drawing.Point(6, 19);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(151, 20);
            this.LastName.TabIndex = 1;
            this.LastName.Text = "Кухарук";
            this.LastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.LastName.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // FatherName
            // 
            this.FatherName.Location = new System.Drawing.Point(6, 19);
            this.FatherName.Name = "FatherName";
            this.FatherName.Size = new System.Drawing.Size(151, 20);
            this.FatherName.TabIndex = 2;
            this.FatherName.Text = "Ігорович";
            this.FatherName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FatherName.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // ENamer
            // 
            this.ENamer.AutoSize = true;
            this.ENamer.BackColor = System.Drawing.SystemColors.Control;
            this.ENamer.Location = new System.Drawing.Point(121, 18);
            this.ENamer.Name = "ENamer";
            this.ENamer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ENamer.Size = new System.Drawing.Size(41, 13);
            this.ENamer.TabIndex = 2;
            this.ENamer.Text = "Підпис";
            this.ENamer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ENamer.UseMnemonic = false;
            // 
            // YearCount
            // 
            this.YearCount.AutoSize = true;
            this.YearCount.BackColor = System.Drawing.SystemColors.Control;
            this.YearCount.Location = new System.Drawing.Point(87, 67);
            this.YearCount.Name = "YearCount";
            this.YearCount.Size = new System.Drawing.Size(13, 13);
            this.YearCount.TabIndex = 5;
            this.YearCount.Text = "0";
            // 
            // Year
            // 
            this.Year.AutoSize = true;
            this.Year.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Year.Location = new System.Drawing.Point(4, 67);
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(25, 13);
            this.Year.TabIndex = 4;
            this.Year.Text = "Вік:";
            // 
            // Inits
            // 
            this.Inits.AutoSize = true;
            this.Inits.BackColor = System.Drawing.SystemColors.Control;
            this.Inits.Location = new System.Drawing.Point(121, 0);
            this.Inits.Name = "Inits";
            this.Inits.Size = new System.Drawing.Size(109, 13);
            this.Inits.TabIndex = 3;
            this.Inits.Text = "Прізвище та ініціали";
            this.Inits.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Info;
            this.pictureBox1.Image = global::Labs.Properties.Resources.iconfinder_Pinterest_UI_18_2540590;
            this.pictureBox1.Location = new System.Drawing.Point(10, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // CardPIB
            // 
            this.CardPIB.AutoSize = true;
            this.CardPIB.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.CardPIB.Location = new System.Drawing.Point(87, 54);
            this.CardPIB.Name = "CardPIB";
            this.CardPIB.Size = new System.Drawing.Size(25, 13);
            this.CardPIB.TabIndex = 1;
            this.CardPIB.Text = "ПІБ";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.46483F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.53517F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(186, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 64.09091F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.90909F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(402, 220);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Year);
            this.panel1.Controls.Add(this.YearCount);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.CardPIB);
            this.panel1.Controls.Add(this.labelFatherName);
            this.panel1.Controls.Add(this.labelLastName);
            this.panel1.Controls.Add(this.labelName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(101, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(298, 135);
            this.panel1.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "ПІБ: ";
            // 
            // labelFatherName
            // 
            this.labelFatherName.AutoSize = true;
            this.labelFatherName.Location = new System.Drawing.Point(87, 33);
            this.labelFatherName.Name = "labelFatherName";
            this.labelFatherName.Size = new System.Drawing.Size(65, 13);
            this.labelFatherName.TabIndex = 5;
            this.labelFatherName.Text = "по батькові";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(87, 20);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(54, 13);
            this.labelLastName.TabIndex = 4;
            this.labelLastName.Text = "прізвище";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(87, 7);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(25, 13);
            this.labelName.TabIndex = 3;
            this.labelName.Text = "ім\'я";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "По батькові: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Прізвище: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ім\'я: ";
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(3, 144);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(92, 73);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.ENamer);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.Inits);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Location = new System.Drawing.Point(101, 144);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(298, 73);
            this.panel3.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Підпис: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Прізвище та ініціали: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FirstName);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(168, 50);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ім\'я";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LastName);
            this.groupBox2.Location = new System.Drawing.Point(12, 68);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(168, 50);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Прізвище";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.FatherName);
            this.groupBox3.Location = new System.Drawing.Point(12, 124);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(168, 50);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "По батькові";
            // 
            // FormLab13
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 409);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLab13";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Лабораторна №13 ";
            this.Load += new System.EventHandler(this.FormLab13_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.TextBox FirstName;
        public System.Windows.Forms.TextBox LastName;
        public System.Windows.Forms.TextBox FatherName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label ENamer;
        private System.Windows.Forms.Label Year;
        private System.Windows.Forms.Label Inits;
        public System.Windows.Forms.Label YearCount;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Label CardPIB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelFatherName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}