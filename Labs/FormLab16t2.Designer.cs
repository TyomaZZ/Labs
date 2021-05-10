
namespace Labs
{
    partial class FormLab16t2
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
            this.groupBoxFormat = new System.Windows.Forms.GroupBox();
            this.radioFormatFree = new System.Windows.Forms.RadioButton();
            this.radioFormatStrong = new System.Windows.Forms.RadioButton();
            this.groupBoxMath = new System.Windows.Forms.GroupBox();
            this.radioMath = new System.Windows.Forms.RadioButton();
            this.radioMathWithoutF = new System.Windows.Forms.RadioButton();
            this.labelErrorZ = new System.Windows.Forms.Label();
            this.labelErrorY = new System.Windows.Forms.Label();
            this.labelErrorX = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Button();
            this.labelResult = new System.Windows.Forms.Label();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.labelZ = new System.Windows.Forms.Label();
            this.labelY = new System.Windows.Forms.Label();
            this.labelX = new System.Windows.Forms.Label();
            this.textBoxZ = new System.Windows.Forms.TextBox();
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.groupBoxFormat.SuspendLayout();
            this.groupBoxMath.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxFormat
            // 
            this.groupBoxFormat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxFormat.Controls.Add(this.radioFormatFree);
            this.groupBoxFormat.Controls.Add(this.radioFormatStrong);
            this.groupBoxFormat.Location = new System.Drawing.Point(12, 12);
            this.groupBoxFormat.Name = "groupBoxFormat";
            this.groupBoxFormat.Size = new System.Drawing.Size(256, 49);
            this.groupBoxFormat.TabIndex = 29;
            this.groupBoxFormat.TabStop = false;
            this.groupBoxFormat.Text = "Спосіб перевірки полів";
            // 
            // radioFormatFree
            // 
            this.radioFormatFree.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioFormatFree.AutoSize = true;
            this.radioFormatFree.Location = new System.Drawing.Point(186, 20);
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
            // groupBoxMath
            // 
            this.groupBoxMath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxMath.Controls.Add(this.radioMath);
            this.groupBoxMath.Controls.Add(this.radioMathWithoutF);
            this.groupBoxMath.Location = new System.Drawing.Point(12, 184);
            this.groupBoxMath.Name = "groupBoxMath";
            this.groupBoxMath.Size = new System.Drawing.Size(256, 47);
            this.groupBoxMath.TabIndex = 28;
            this.groupBoxMath.TabStop = false;
            this.groupBoxMath.Text = "Спосіб обчислення:";
            // 
            // radioMath
            // 
            this.radioMath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioMath.AutoSize = true;
            this.radioMath.Location = new System.Drawing.Point(168, 19);
            this.radioMath.Name = "radioMath";
            this.radioMath.Size = new System.Drawing.Size(82, 17);
            this.radioMath.TabIndex = 1;
            this.radioMath.Text = "З функіями";
            this.radioMath.UseVisualStyleBackColor = true;
            // 
            // radioMathWithoutF
            // 
            this.radioMathWithoutF.AutoSize = true;
            this.radioMathWithoutF.Checked = true;
            this.radioMathWithoutF.Location = new System.Drawing.Point(7, 19);
            this.radioMathWithoutF.Name = "radioMathWithoutF";
            this.radioMathWithoutF.Size = new System.Drawing.Size(86, 17);
            this.radioMathWithoutF.TabIndex = 0;
            this.radioMathWithoutF.TabStop = true;
            this.radioMathWithoutF.Text = "Без функцій";
            this.radioMathWithoutF.UseVisualStyleBackColor = true;
            // 
            // labelErrorZ
            // 
            this.labelErrorZ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelErrorZ.AutoSize = true;
            this.labelErrorZ.ForeColor = System.Drawing.Color.Red;
            this.labelErrorZ.Location = new System.Drawing.Point(173, 168);
            this.labelErrorZ.Name = "labelErrorZ";
            this.labelErrorZ.Size = new System.Drawing.Size(95, 13);
            this.labelErrorZ.TabIndex = 27;
            this.labelErrorZ.Text = "Невірний формат";
            this.labelErrorZ.Visible = false;
            // 
            // labelErrorY
            // 
            this.labelErrorY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelErrorY.AutoSize = true;
            this.labelErrorY.ForeColor = System.Drawing.Color.Red;
            this.labelErrorY.Location = new System.Drawing.Point(173, 129);
            this.labelErrorY.Name = "labelErrorY";
            this.labelErrorY.Size = new System.Drawing.Size(95, 13);
            this.labelErrorY.TabIndex = 26;
            this.labelErrorY.Text = "Невірний формат";
            this.labelErrorY.Visible = false;
            // 
            // labelErrorX
            // 
            this.labelErrorX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelErrorX.AutoSize = true;
            this.labelErrorX.ForeColor = System.Drawing.Color.Red;
            this.labelErrorX.Location = new System.Drawing.Point(173, 90);
            this.labelErrorX.Name = "labelErrorX";
            this.labelErrorX.Size = new System.Drawing.Size(95, 13);
            this.labelErrorX.TabIndex = 25;
            this.labelErrorX.Text = "Невірний формат";
            this.labelErrorX.Visible = false;
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Location = new System.Drawing.Point(12, 262);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(256, 23);
            this.CloseButton.TabIndex = 24;
            this.CloseButton.Text = "Завершити роботу";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(9, 240);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(62, 13);
            this.labelResult.TabIndex = 23;
            this.labelResult.Text = "Результат:";
            // 
            // textBoxResult
            // 
            this.textBoxResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxResult.Location = new System.Drawing.Point(77, 237);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.Size = new System.Drawing.Size(191, 20);
            this.textBoxResult.TabIndex = 22;
            this.textBoxResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelZ
            // 
            this.labelZ.AutoSize = true;
            this.labelZ.Location = new System.Drawing.Point(9, 148);
            this.labelZ.Name = "labelZ";
            this.labelZ.Size = new System.Drawing.Size(17, 13);
            this.labelZ.TabIndex = 21;
            this.labelZ.Text = "Z:";
            // 
            // labelY
            // 
            this.labelY.AutoSize = true;
            this.labelY.Location = new System.Drawing.Point(9, 109);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(17, 13);
            this.labelY.TabIndex = 20;
            this.labelY.Text = "Y:";
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Location = new System.Drawing.Point(9, 70);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(17, 13);
            this.labelX.TabIndex = 19;
            this.labelX.Text = "X:";
            // 
            // textBoxZ
            // 
            this.textBoxZ.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxZ.Location = new System.Drawing.Point(32, 145);
            this.textBoxZ.Name = "textBoxZ";
            this.textBoxZ.Size = new System.Drawing.Size(236, 20);
            this.textBoxZ.TabIndex = 18;
            this.textBoxZ.Text = "0,5";
            this.textBoxZ.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxY
            // 
            this.textBoxY.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxY.Location = new System.Drawing.Point(32, 106);
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.Size = new System.Drawing.Size(236, 20);
            this.textBoxY.TabIndex = 17;
            this.textBoxY.Text = "0,1";
            this.textBoxY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxX
            // 
            this.textBoxX.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxX.Location = new System.Drawing.Point(32, 67);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(236, 20);
            this.textBoxX.TabIndex = 16;
            this.textBoxX.Text = "1,5";
            this.textBoxX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // FormLab16t2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 289);
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
            this.MinimumSize = new System.Drawing.Size(293, 328);
            this.Name = "FormLab16t2";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Обчислення виразу";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormLab16t2_FormClosing);
            this.groupBoxFormat.ResumeLayout(false);
            this.groupBoxFormat.PerformLayout();
            this.groupBoxMath.ResumeLayout(false);
            this.groupBoxMath.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxFormat;
        private System.Windows.Forms.RadioButton radioFormatFree;
        private System.Windows.Forms.RadioButton radioFormatStrong;
        private System.Windows.Forms.GroupBox groupBoxMath;
        private System.Windows.Forms.RadioButton radioMath;
        private System.Windows.Forms.RadioButton radioMathWithoutF;
        private System.Windows.Forms.Label labelErrorZ;
        private System.Windows.Forms.Label labelErrorY;
        private System.Windows.Forms.Label labelErrorX;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Label labelZ;
        private System.Windows.Forms.Label labelY;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.TextBox textBoxZ;
        private System.Windows.Forms.TextBox textBoxY;
        private System.Windows.Forms.TextBox textBoxX;
    }
}