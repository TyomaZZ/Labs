
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
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.radioButtonAction2 = new System.Windows.Forms.RadioButton();
            this.radioButtonAction1 = new System.Windows.Forms.RadioButton();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxX
            // 
            this.textBoxX.Location = new System.Drawing.Point(31, 12);
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
            this.textBoxY.Location = new System.Drawing.Point(31, 51);
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.Size = new System.Drawing.Size(151, 20);
            this.textBoxY.TabIndex = 1;
            this.textBoxY.Text = "0,1";
            this.textBoxY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxY.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBoxZ
            // 
            this.textBoxZ.Location = new System.Drawing.Point(31, 90);
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
            this.labelX.Location = new System.Drawing.Point(8, 15);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(17, 13);
            this.labelX.TabIndex = 3;
            this.labelX.Text = "X:";
            // 
            // labelY
            // 
            this.labelY.AutoSize = true;
            this.labelY.Location = new System.Drawing.Point(8, 54);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(17, 13);
            this.labelY.TabIndex = 4;
            this.labelY.Text = "Y:";
            // 
            // labelZ
            // 
            this.labelZ.AutoSize = true;
            this.labelZ.Location = new System.Drawing.Point(8, 93);
            this.labelZ.Name = "labelZ";
            this.labelZ.Size = new System.Drawing.Size(17, 13);
            this.labelZ.TabIndex = 5;
            this.labelZ.Text = "Z:";
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(76, 222);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.Size = new System.Drawing.Size(106, 20);
            this.textBoxResult.TabIndex = 8;
            this.textBoxResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(8, 225);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(62, 13);
            this.labelResult.TabIndex = 9;
            this.labelResult.Text = "Результат:";
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(11, 290);
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
            this.labelErrorX.Location = new System.Drawing.Point(87, 35);
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
            this.labelErrorY.Location = new System.Drawing.Point(87, 74);
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
            this.labelErrorZ.Location = new System.Drawing.Point(87, 113);
            this.labelErrorZ.Name = "labelErrorZ";
            this.labelErrorZ.Size = new System.Drawing.Size(95, 13);
            this.labelErrorZ.TabIndex = 13;
            this.labelErrorZ.Text = "Невірний формат";
            this.labelErrorZ.Visible = false;
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.radioButtonAction2);
            this.groupBox.Controls.Add(this.radioButtonAction1);
            this.groupBox.Location = new System.Drawing.Point(11, 130);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(171, 73);
            this.groupBox.TabIndex = 14;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Спосіб обчислення:";
            // 
            // radioButtonAction2
            // 
            this.radioButtonAction2.AutoSize = true;
            this.radioButtonAction2.Location = new System.Drawing.Point(44, 43);
            this.radioButtonAction2.Name = "radioButtonAction2";
            this.radioButtonAction2.Size = new System.Drawing.Size(82, 17);
            this.radioButtonAction2.TabIndex = 1;
            this.radioButtonAction2.Text = "З функіями";
            this.radioButtonAction2.UseVisualStyleBackColor = true;
            // 
            // radioButtonAction1
            // 
            this.radioButtonAction1.AutoSize = true;
            this.radioButtonAction1.Location = new System.Drawing.Point(44, 19);
            this.radioButtonAction1.Name = "radioButtonAction1";
            this.radioButtonAction1.Size = new System.Drawing.Size(86, 17);
            this.radioButtonAction1.TabIndex = 0;
            this.radioButtonAction1.Text = "Без функцій";
            this.radioButtonAction1.UseVisualStyleBackColor = true;
            this.radioButtonAction1.CheckedChanged += new System.EventHandler(this.radioButtonAction1_CheckedChanged);
            // 
            // FormLab10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(190, 322);
            this.Controls.Add(this.groupBox);
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
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.RadioButton radioButtonAction2;
        private System.Windows.Forms.RadioButton radioButtonAction1;
    }
}