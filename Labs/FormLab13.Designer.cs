
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
            this.Inits = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CardPIB = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelFatherName = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
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
            this.ENamer.Location = new System.Drawing.Point(4, 22);
            this.ENamer.Name = "ENamer";
            this.ENamer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ENamer.Size = new System.Drawing.Size(47, 13);
            this.ENamer.TabIndex = 2;
            this.ENamer.Text = "Підпис: ";
            this.ENamer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ENamer.UseMnemonic = false;
            // 
            // YearCount
            // 
            this.YearCount.AutoSize = true;
            this.YearCount.BackColor = System.Drawing.SystemColors.Control;
            this.YearCount.Location = new System.Drawing.Point(4, 72);
            this.YearCount.Name = "YearCount";
            this.YearCount.Size = new System.Drawing.Size(28, 13);
            this.YearCount.TabIndex = 5;
            this.YearCount.Text = "Вік: ";
            // 
            // Inits
            // 
            this.Inits.AutoSize = true;
            this.Inits.BackColor = System.Drawing.SystemColors.Control;
            this.Inits.Location = new System.Drawing.Point(4, 0);
            this.Inits.Name = "Inits";
            this.Inits.Size = new System.Drawing.Size(115, 13);
            this.Inits.TabIndex = 3;
            this.Inits.Text = "Прізвище та ініціали: ";
            this.Inits.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Info;
            this.pictureBox1.Image = global::Labs.Properties.Resources.iconfinder_Pinterest_UI_18_2540590;
            this.pictureBox1.Location = new System.Drawing.Point(10, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(78, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // CardPIB
            // 
            this.CardPIB.AutoSize = true;
            this.CardPIB.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.CardPIB.Location = new System.Drawing.Point(4, 54);
            this.CardPIB.Name = "CardPIB";
            this.CardPIB.Size = new System.Drawing.Size(28, 13);
            this.CardPIB.TabIndex = 1;
            this.CardPIB.Text = "ПІБ:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.46483F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.53517F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(186, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 64.09091F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.90909F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(402, 192);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.YearCount);
            this.panel1.Controls.Add(this.CardPIB);
            this.panel1.Controls.Add(this.labelFatherName);
            this.panel1.Controls.Add(this.labelLastName);
            this.panel1.Controls.Add(this.labelName);
            this.panel1.Location = new System.Drawing.Point(101, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(298, 117);
            this.panel1.TabIndex = 1;
            // 
            // labelFatherName
            // 
            this.labelFatherName.AutoSize = true;
            this.labelFatherName.BackColor = System.Drawing.SystemColors.Control;
            this.labelFatherName.Location = new System.Drawing.Point(4, 33);
            this.labelFatherName.Name = "labelFatherName";
            this.labelFatherName.Size = new System.Drawing.Size(73, 13);
            this.labelFatherName.TabIndex = 5;
            this.labelFatherName.Text = "По батькові: ";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.BackColor = System.Drawing.SystemColors.Control;
            this.labelLastName.Location = new System.Drawing.Point(4, 18);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(62, 13);
            this.labelLastName.TabIndex = 4;
            this.labelLastName.Text = "Прізвище: ";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.SystemColors.Control;
            this.labelName.Location = new System.Drawing.Point(4, 3);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(32, 13);
            this.labelName.TabIndex = 3;
            this.labelName.Text = "Ім\'я: ";
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(3, 126);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(92, 63);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.ENamer);
            this.panel3.Controls.Add(this.Inits);
            this.panel3.Location = new System.Drawing.Point(101, 126);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(298, 63);
            this.panel3.TabIndex = 3;
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
            this.ClientSize = new System.Drawing.Size(742, 343);
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
        private System.Windows.Forms.Label Inits;
        public System.Windows.Forms.Label YearCount;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Label CardPIB;
        private System.Windows.Forms.Label labelFatherName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}