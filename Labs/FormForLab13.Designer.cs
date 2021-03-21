
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
            this.label7 = new System.Windows.Forms.Label();
            this.Years = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BirthdayDay
            // 
            this.BirthdayDay.Location = new System.Drawing.Point(180, 118);
            this.BirthdayDay.MaxDate = new System.DateTime(2021, 3, 21, 0, 0, 0, 0);
            this.BirthdayDay.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.BirthdayDay.Name = "BirthdayDay";
            this.BirthdayDay.Size = new System.Drawing.Size(191, 20);
            this.BirthdayDay.TabIndex = 12;
            this.BirthdayDay.Value = new System.DateTime(1998, 5, 12, 0, 0, 0, 0);
            this.BirthdayDay.ValueChanged += new System.EventHandler(this.BirthdayDay_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(59, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Дата народження:";
            // 
            // Years
            // 
            this.Years.Location = new System.Drawing.Point(180, 145);
            this.Years.Name = "Years";
            this.Years.ReadOnly = true;
            this.Years.Size = new System.Drawing.Size(190, 20);
            this.Years.TabIndex = 14;
            this.Years.Text = "0";
            this.Years.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Years.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(59, 148);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Вік:";
            // 
            // FormForLab13
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 310);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Years);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.BirthdayDay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormForLab13";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Лабораторна 13 (Породжена форма)";
            this.Load += new System.EventHandler(this.FormForLab13_Load);
            this.Controls.SetChildIndex(this.BirthdayDay, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.Years, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker BirthdayDay;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Years;
        private System.Windows.Forms.Label label8;
    }
}