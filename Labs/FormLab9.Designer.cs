
namespace Labs
{
    partial class FormLab9
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
            this.buttonCloseAction = new System.Windows.Forms.Button();
            this.labelInput = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.groupBoxRadioSwitch = new System.Windows.Forms.GroupBox();
            this.radioButtonAction3 = new System.Windows.Forms.RadioButton();
            this.textBoxCell2 = new System.Windows.Forms.TextBox();
            this.textBoxCell1 = new System.Windows.Forms.TextBox();
            this.radioButtonAction2 = new System.Windows.Forms.RadioButton();
            this.radioButtonAction1 = new System.Windows.Forms.RadioButton();
            this.groupBoxRadioSwitch.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCloseAction
            // 
            this.buttonCloseAction.Location = new System.Drawing.Point(12, 153);
            this.buttonCloseAction.Name = "buttonCloseAction";
            this.buttonCloseAction.Size = new System.Drawing.Size(267, 23);
            this.buttonCloseAction.TabIndex = 1;
            this.buttonCloseAction.Text = "Завершення роботи";
            this.buttonCloseAction.UseVisualStyleBackColor = true;
            this.buttonCloseAction.Click += new System.EventHandler(this.buttonCloseAction_Click);
            // 
            // labelInput
            // 
            this.labelInput.AutoSize = true;
            this.labelInput.Location = new System.Drawing.Point(12, 9);
            this.labelInput.Name = "labelInput";
            this.labelInput.Size = new System.Drawing.Size(94, 13);
            this.labelInput.TabIndex = 2;
            this.labelInput.Text = "Рядок для вводу:";
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(12, 130);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(62, 13);
            this.labelResult.TabIndex = 3;
            this.labelResult.Text = "Результат:";
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(112, 6);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(167, 20);
            this.textBoxInput.TabIndex = 4;
            this.textBoxInput.TextChanged += new System.EventHandler(this.textBoxInput_TextChanged);
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(80, 127);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.Size = new System.Drawing.Size(199, 20);
            this.textBoxResult.TabIndex = 5;
            // 
            // groupBoxRadioSwitch
            // 
            this.groupBoxRadioSwitch.Controls.Add(this.radioButtonAction3);
            this.groupBoxRadioSwitch.Controls.Add(this.textBoxCell2);
            this.groupBoxRadioSwitch.Controls.Add(this.textBoxCell1);
            this.groupBoxRadioSwitch.Controls.Add(this.radioButtonAction2);
            this.groupBoxRadioSwitch.Controls.Add(this.radioButtonAction1);
            this.groupBoxRadioSwitch.Location = new System.Drawing.Point(15, 32);
            this.groupBoxRadioSwitch.Name = "groupBoxRadioSwitch";
            this.groupBoxRadioSwitch.Size = new System.Drawing.Size(264, 89);
            this.groupBoxRadioSwitch.TabIndex = 7;
            this.groupBoxRadioSwitch.TabStop = false;
            this.groupBoxRadioSwitch.Text = "Виберіть дію:";
            // 
            // radioButtonAction3
            // 
            this.radioButtonAction3.AutoSize = true;
            this.radioButtonAction3.Location = new System.Drawing.Point(6, 66);
            this.radioButtonAction3.Name = "radioButtonAction3";
            this.radioButtonAction3.Size = new System.Drawing.Size(240, 17);
            this.radioButtonAction3.TabIndex = 12;
            this.radioButtonAction3.TabStop = true;
            this.radioButtonAction3.Text = "Слово з максимальною часткою голосних";
            this.radioButtonAction3.UseVisualStyleBackColor = true;
            this.radioButtonAction3.CheckedChanged += new System.EventHandler(this.radioButtonAction3_CheckedChanged);
            // 
            // textBoxCell2
            // 
            this.textBoxCell2.Location = new System.Drawing.Point(238, 41);
            this.textBoxCell2.Name = "textBoxCell2";
            this.textBoxCell2.Size = new System.Drawing.Size(26, 20);
            this.textBoxCell2.TabIndex = 11;
            this.textBoxCell2.Text = "?";
            this.textBoxCell2.Click += new System.EventHandler(this.textBoxCell2_Click);
            this.textBoxCell2.TextChanged += new System.EventHandler(this.textBoxCell2_TextChanged);
            // 
            // textBoxCell1
            // 
            this.textBoxCell1.Location = new System.Drawing.Point(231, 18);
            this.textBoxCell1.Name = "textBoxCell1";
            this.textBoxCell1.Size = new System.Drawing.Size(33, 20);
            this.textBoxCell1.TabIndex = 10;
            this.textBoxCell1.Text = "к";
            this.textBoxCell1.Click += new System.EventHandler(this.textBoxCell1_Click);
            this.textBoxCell1.TextChanged += new System.EventHandler(this.textBoxCell1_TextChanged);
            // 
            // radioButtonAction2
            // 
            this.radioButtonAction2.AutoSize = true;
            this.radioButtonAction2.Location = new System.Drawing.Point(6, 42);
            this.radioButtonAction2.Name = "radioButtonAction2";
            this.radioButtonAction2.Size = new System.Drawing.Size(226, 17);
            this.radioButtonAction2.TabIndex = 9;
            this.radioButtonAction2.TabStop = true;
            this.radioButtonAction2.Text = "Повторити кожен символ відмінний від:";
            this.radioButtonAction2.UseVisualStyleBackColor = true;
            this.radioButtonAction2.CheckedChanged += new System.EventHandler(this.radioButtonAction2_CheckedChanged);
            // 
            // radioButtonAction1
            // 
            this.radioButtonAction1.AutoSize = true;
            this.radioButtonAction1.Location = new System.Drawing.Point(6, 19);
            this.radioButtonAction1.Name = "radioButtonAction1";
            this.radioButtonAction1.Size = new System.Drawing.Size(219, 17);
            this.radioButtonAction1.TabIndex = 8;
            this.radioButtonAction1.TabStop = true;
            this.radioButtonAction1.Text = "Видалити з текстового рядка символ:";
            this.radioButtonAction1.UseVisualStyleBackColor = true;
            this.radioButtonAction1.CheckedChanged += new System.EventHandler(this.radioButtonAction1_CheckedChanged);
            // 
            // FormLab9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 181);
            this.Controls.Add(this.groupBoxRadioSwitch);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.labelInput);
            this.Controls.Add(this.buttonCloseAction);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLab9";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Лабораторна робота 9";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormLab9_FormClosed);
            this.groupBoxRadioSwitch.ResumeLayout(false);
            this.groupBoxRadioSwitch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonCloseAction;
        private System.Windows.Forms.Label labelInput;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.GroupBox groupBoxRadioSwitch;
        private System.Windows.Forms.RadioButton radioButtonAction2;
        private System.Windows.Forms.RadioButton radioButtonAction1;
        private System.Windows.Forms.TextBox textBoxCell2;
        private System.Windows.Forms.TextBox textBoxCell1;
        private System.Windows.Forms.RadioButton radioButtonAction3;
    }
}