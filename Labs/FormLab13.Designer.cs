
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PIB = new System.Windows.Forms.TextBox();
            this.LastNameAndI = new System.Windows.Forms.TextBox();
            this.EName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FirstName
            // 
            this.FirstName.Location = new System.Drawing.Point(127, 5);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(287, 20);
            this.FirstName.TabIndex = 0;
            this.FirstName.Text = "Артем";
            this.FirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.FirstName.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // LastName
            // 
            this.LastName.Location = new System.Drawing.Point(127, 32);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(287, 20);
            this.LastName.TabIndex = 1;
            this.LastName.Text = "Кухарук";
            this.LastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.LastName.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // FatherName
            // 
            this.FatherName.Location = new System.Drawing.Point(127, 59);
            this.FatherName.Name = "FatherName";
            this.FatherName.Size = new System.Drawing.Size(287, 20);
            this.FatherName.TabIndex = 2;
            this.FatherName.Text = "Ігорович";
            this.FatherName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.FatherName.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ім\'я:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Прізвище:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "По батькові:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "ПІБ:";
            // 
            // PIB
            // 
            this.PIB.Location = new System.Drawing.Point(127, 158);
            this.PIB.Name = "PIB";
            this.PIB.ReadOnly = true;
            this.PIB.Size = new System.Drawing.Size(287, 20);
            this.PIB.TabIndex = 7;
            this.PIB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // LastNameAndI
            // 
            this.LastNameAndI.Location = new System.Drawing.Point(127, 184);
            this.LastNameAndI.Name = "LastNameAndI";
            this.LastNameAndI.ReadOnly = true;
            this.LastNameAndI.Size = new System.Drawing.Size(287, 20);
            this.LastNameAndI.TabIndex = 8;
            this.LastNameAndI.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // EName
            // 
            this.EName.Location = new System.Drawing.Point(127, 210);
            this.EName.Name = "EName";
            this.EName.ReadOnly = true;
            this.EName.Size = new System.Drawing.Size(287, 20);
            this.EName.TabIndex = 9;
            this.EName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Прізвище та ініціали:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Підпис:";
            // 
            // buttonClose
            // 
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Location = new System.Drawing.Point(9, 363);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(405, 23);
            this.buttonClose.TabIndex = 12;
            this.buttonClose.Text = "Завершити роботу";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // FormLab13
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 766);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.FatherName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LastNameAndI);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PIB);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLab13";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Лабораторна №13 ";
            this.Load += new System.EventHandler(this.FormLab13_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox EName;
        private System.Windows.Forms.TextBox LastNameAndI;
        private System.Windows.Forms.Button buttonClose;
        public System.Windows.Forms.TextBox PIB;
        public System.Windows.Forms.TextBox FirstName;
        public System.Windows.Forms.TextBox LastName;
        public System.Windows.Forms.TextBox FatherName;
    }
}