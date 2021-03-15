
namespace Labs
{
    partial class FormLab10
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
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.textBoxZ = new System.Windows.Forms.TextBox();
            this.labelX = new System.Windows.Forms.Label();
            this.labelY = new System.Windows.Forms.Label();
            this.labelZ = new System.Windows.Forms.Label();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.labelResult = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Button();
            this.labelErrorX = new System.Windows.Forms.Label();
            this.labelErrorY = new System.Windows.Forms.Label();
            this.labelErrorZ = new System.Windows.Forms.Label();
            this.groupBoxMath = new System.Windows.Forms.GroupBox();
            this.radioMath = new System.Windows.Forms.RadioButton();
            this.radioMathWithoutF = new System.Windows.Forms.RadioButton();
            this.groupBoxFormat = new System.Windows.Forms.GroupBox();
            this.radioFormatFree = new System.Windows.Forms.RadioButton();
            this.radioFormatStrong = new System.Windows.Forms.RadioButton();
            this.groupBoxMath.SuspendLayout();
            this.groupBoxFormat.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxX
            // 
            this.textBoxX.Location = new System.Drawing.Point(27, 59);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(151, 20);
            this.textBoxX.TabIndex = 0;
            this.textBoxX.Text = "1,5";
            this.textBoxX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxX.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.textBoxX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Checker_KeyPress);
            // 
            // textBoxY
            // 
            this.textBoxY.Location = new System.Drawing.Point(27, 98);
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.Size = new System.Drawing.Size(151, 20);
            this.textBoxY.TabIndex = 1;
            this.textBoxY.Text = "0,1";
            this.textBoxY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxY.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBoxZ
            // 
            this.textBoxZ.Location = new System.Drawing.Point(27, 137);
            this.textBoxZ.Name = "textBoxZ";
            this.textBoxZ.Size = new System.Drawing.Size(151, 20);
            this.textBoxZ.TabIndex = 2;
            this.textBoxZ.Text = "0,5";
            this.textBoxZ.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxZ.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Location = new System.Drawing.Point(4, 62);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(17, 13);
            this.labelX.TabIndex = 3;
            this.labelX.Text = "X:";
            // 
            // labelY
            // 
            this.labelY.AutoSize = true;
            this.labelY.Location = new System.Drawing.Point(4, 101);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(17, 13);
            this.labelY.TabIndex = 4;
            this.labelY.Text = "Y:";
            // 
            // labelZ
            // 
            this.labelZ.AutoSize = true;
            this.labelZ.Location = new System.Drawing.Point(4, 140);
            this.labelZ.Name = "labelZ";
            this.labelZ.Size = new System.Drawing.Size(17, 13);
            this.labelZ.TabIndex = 5;
            this.labelZ.Text = "Z:";
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(72, 255);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.Size = new System.Drawing.Size(106, 20);
            this.textBoxResult.TabIndex = 8;
            this.textBoxResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(4, 258);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(62, 13);
            this.labelResult.TabIndex = 9;
            this.labelResult.Text = "Результат:";
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(7, 337);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(171, 23);
            this.CloseButton.TabIndex = 10;
            this.CloseButton.Text = "Завершити роботу";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // labelErrorX
            // 
            this.labelErrorX.AutoSize = true;
            this.labelErrorX.ForeColor = System.Drawing.Color.Red;
            this.labelErrorX.Location = new System.Drawing.Point(83, 82);
            this.labelErrorX.Name = "labelErrorX";
            this.labelErrorX.Size = new System.Drawing.Size(95, 13);
            this.labelErrorX.TabIndex = 11;
            this.labelErrorX.Text = "Невірний формат";
            this.labelErrorX.Visible = false;
            // 
            // labelErrorY
            // 
            this.labelErrorY.AutoSize = true;
            this.labelErrorY.ForeColor = System.Drawing.Color.Red;
            this.labelErrorY.Location = new System.Drawing.Point(83, 121);
            this.labelErrorY.Name = "labelErrorY";
            this.labelErrorY.Size = new System.Drawing.Size(95, 13);
            this.labelErrorY.TabIndex = 12;
            this.labelErrorY.Text = "Невірний формат";
            this.labelErrorY.Visible = false;
            // 
            // labelErrorZ
            // 
            this.labelErrorZ.AutoSize = true;
            this.labelErrorZ.ForeColor = System.Drawing.Color.Red;
            this.labelErrorZ.Location = new System.Drawing.Point(83, 160);
            this.labelErrorZ.Name = "labelErrorZ";
            this.labelErrorZ.Size = new System.Drawing.Size(95, 13);
            this.labelErrorZ.TabIndex = 13;
            this.labelErrorZ.Text = "Невірний формат";
            this.labelErrorZ.Visible = false;
            // 
            // groupBoxMath
            // 
            this.groupBoxMath.Controls.Add(this.radioMath);
            this.groupBoxMath.Controls.Add(this.radioMathWithoutF);
            this.groupBoxMath.Location = new System.Drawing.Point(7, 176);
            this.groupBoxMath.Name = "groupBoxMath";
            this.groupBoxMath.Size = new System.Drawing.Size(171, 73);
            this.groupBoxMath.TabIndex = 14;
            this.groupBoxMath.TabStop = false;
            this.groupBoxMath.Text = "Спосіб обчислення:";
            // 
            // radioMath
            // 
            this.radioMath.AutoSize = true;
            this.radioMath.Location = new System.Drawing.Point(44, 43);
            this.radioMath.Name = "radioMath";
            this.radioMath.Size = new System.Drawing.Size(82, 17);
            this.radioMath.TabIndex = 1;
            this.radioMath.Text = "З функіями";
            this.radioMath.UseVisualStyleBackColor = true;
            this.radioMath.CheckedChanged += new System.EventHandler(this.radioMath_CheckedChanged);
            // 
            // radioMathWithoutF
            // 
            this.radioMathWithoutF.AutoSize = true;
            this.radioMathWithoutF.Checked = true;
            this.radioMathWithoutF.Location = new System.Drawing.Point(44, 19);
            this.radioMathWithoutF.Name = "radioMathWithoutF";
            this.radioMathWithoutF.Size = new System.Drawing.Size(86, 17);
            this.radioMathWithoutF.TabIndex = 0;
            this.radioMathWithoutF.TabStop = true;
            this.radioMathWithoutF.Text = "Без функцій";
            this.radioMathWithoutF.UseVisualStyleBackColor = true;
            this.radioMathWithoutF.CheckedChanged += new System.EventHandler(this.radioMathWithoutF_CheckedChanged);
            // 
            // groupBoxFormat
            // 
            this.groupBoxFormat.Controls.Add(this.radioFormatFree);
            this.groupBoxFormat.Controls.Add(this.radioFormatStrong);
            this.groupBoxFormat.Location = new System.Drawing.Point(7, 4);
            this.groupBoxFormat.Name = "groupBoxFormat";
            this.groupBoxFormat.Size = new System.Drawing.Size(171, 49);
            this.groupBoxFormat.TabIndex = 15;
            this.groupBoxFormat.TabStop = false;
            this.groupBoxFormat.Text = "Спосіб перевірки полів";
            // 
            // radioFormatFree
            // 
            this.radioFormatFree.AutoSize = true;
            this.radioFormatFree.Location = new System.Drawing.Point(101, 20);
            this.radioFormatFree.Name = "radioFormatFree";
            this.radioFormatFree.Size = new System.Drawing.Size(64, 17);
            this.radioFormatFree.TabIndex = 1;
            this.radioFormatFree.Text = "Вільний";
            this.radioFormatFree.UseVisualStyleBackColor = true;
            // 
            // radioFormatStrong
            // 
            this.radioFormatStrong.AutoSize = true;
            this.radioFormatStrong.Checked = true;
            this.radioFormatStrong.Location = new System.Drawing.Point(7, 20);
            this.radioFormatStrong.Name = "radioFormatStrong";
            this.radioFormatStrong.Size = new System.Drawing.Size(66, 17);
            this.radioFormatStrong.TabIndex = 0;
            this.radioFormatStrong.TabStop = true;
            this.radioFormatStrong.Text = "Строгий";
            this.radioFormatStrong.UseVisualStyleBackColor = true;
            // 
            // FormLab10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(185, 363);
            this.Controls.Add(this.groupBoxFormat);
            this.Controls.Add(this.groupBoxMath);
            this.Controls.Add(this.labelErrorZ);
            this.Controls.Add(this.labelErrorY);
            this.Controls.Add(this.labelErrorX);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.labelZ);
            this.Controls.Add(this.labelY);
            this.Controls.Add(this.labelX);
            this.Controls.Add(this.textBoxZ);
            this.Controls.Add(this.textBoxY);
            this.Controls.Add(this.textBoxX);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLab10";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Лабораторна Робота №10";
            this.Load += new System.EventHandler(this.FormLab10_Load);
            this.groupBoxMath.ResumeLayout(false);
            this.groupBoxMath.PerformLayout();
            this.groupBoxFormat.ResumeLayout(false);
            this.groupBoxFormat.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.TextBox textBoxY;
        private System.Windows.Forms.TextBox textBoxZ;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.Label labelY;
        private System.Windows.Forms.Label labelZ;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Label labelErrorX;
        private System.Windows.Forms.Label labelErrorY;
        private System.Windows.Forms.Label labelErrorZ;
        private System.Windows.Forms.GroupBox groupBoxMath;
        private System.Windows.Forms.RadioButton radioMath;
        private System.Windows.Forms.RadioButton radioMathWithoutF;
        private System.Windows.Forms.GroupBox groupBoxFormat;
        private System.Windows.Forms.RadioButton radioFormatFree;
        private System.Windows.Forms.RadioButton radioFormatStrong;
    }
}