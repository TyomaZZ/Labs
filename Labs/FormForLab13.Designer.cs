
namespace Labs
{
    partial class FormForLab13
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
            this.BirthdayDay = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CardPIB
            // 
            this.CardPIB.Size = new System.Drawing.Size(128, 13);
            this.CardPIB.Text = "Кухарук Артем Ігорович";
            // 
            // BirthdayDay
            // 
            this.BirthdayDay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.BirthdayDay.Location = new System.Drawing.Point(6, 19);
            this.BirthdayDay.MaxDate = new System.DateTime(2021, 3, 21, 0, 0, 0, 0);
            this.BirthdayDay.MinDate = new System.DateTime(1921, 1, 1, 0, 0, 0, 0);
            this.BirthdayDay.Name = "BirthdayDay";
            this.BirthdayDay.Size = new System.Drawing.Size(151, 20);
            this.BirthdayDay.TabIndex = 12;
            this.BirthdayDay.Value = new System.DateTime(1998, 5, 12, 0, 0, 0, 0);
            this.BirthdayDay.ValueChanged += new System.EventHandler(this.BirthdayDay_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BirthdayDay);
            this.groupBox1.Location = new System.Drawing.Point(12, 180);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(168, 47);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Дата народження";
            // 
            // FormForLab13
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 242);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormForLab13";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Лабораторна 13 (Породжена форма)";
            this.Load += new System.EventHandler(this.FormForLab13_Load);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.DateTimePicker BirthdayDay;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}