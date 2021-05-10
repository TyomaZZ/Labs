
namespace Labs
{
    partial class FormLab16t1
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
            this.groupBoxRadioSwitch = new System.Windows.Forms.GroupBox();
            this.radioButtonAction3 = new System.Windows.Forms.RadioButton();
            this.textBoxCell2 = new System.Windows.Forms.TextBox();
            this.textBoxCell1 = new System.Windows.Forms.TextBox();
            this.radioButtonAction2 = new System.Windows.Forms.RadioButton();
            this.radioButtonAction1 = new System.Windows.Forms.RadioButton();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.labelResult = new System.Windows.Forms.Label();
            this.labelInput = new System.Windows.Forms.Label();
            this.buttonCloseAction = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxRadioSwitch.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxRadioSwitch
            // 
            this.groupBoxRadioSwitch.Controls.Add(this.radioButtonAction3);
            this.groupBoxRadioSwitch.Controls.Add(this.textBoxCell2);
            this.groupBoxRadioSwitch.Controls.Add(this.textBoxCell1);
            this.groupBoxRadioSwitch.Controls.Add(this.radioButtonAction2);
            this.groupBoxRadioSwitch.Controls.Add(this.radioButtonAction1);
            this.groupBoxRadioSwitch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxRadioSwitch.Location = new System.Drawing.Point(3, 36);
            this.groupBoxRadioSwitch.MinimumSize = new System.Drawing.Size(0, 100);
            this.groupBoxRadioSwitch.Name = "groupBoxRadioSwitch";
            this.groupBoxRadioSwitch.Size = new System.Drawing.Size(315, 120);
            this.groupBoxRadioSwitch.TabIndex = 13;
            this.groupBoxRadioSwitch.TabStop = false;
            this.groupBoxRadioSwitch.Text = "Виберіть дію:";
            // 
            // radioButtonAction3
            // 
            this.radioButtonAction3.AutoSize = true;
            this.radioButtonAction3.Location = new System.Drawing.Point(6, 79);
            this.radioButtonAction3.MinimumSize = new System.Drawing.Size(240, 27);
            this.radioButtonAction3.Name = "radioButtonAction3";
            this.radioButtonAction3.Size = new System.Drawing.Size(240, 27);
            this.radioButtonAction3.TabIndex = 12;
            this.radioButtonAction3.TabStop = true;
            this.radioButtonAction3.Text = "Слово з максимальною часткою голосних";
            this.radioButtonAction3.UseVisualStyleBackColor = true;
            // 
            // textBoxCell2
            // 
            this.textBoxCell2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCell2.Location = new System.Drawing.Point(234, 56);
            this.textBoxCell2.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.textBoxCell2.MinimumSize = new System.Drawing.Size(4, 20);
            this.textBoxCell2.Name = "textBoxCell2";
            this.textBoxCell2.Size = new System.Drawing.Size(75, 20);
            this.textBoxCell2.TabIndex = 11;
            this.textBoxCell2.Text = "?";
            this.textBoxCell2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxCell1
            // 
            this.textBoxCell1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCell1.Location = new System.Drawing.Point(226, 23);
            this.textBoxCell1.MaxLength = 1;
            this.textBoxCell1.MinimumSize = new System.Drawing.Size(52, 20);
            this.textBoxCell1.Name = "textBoxCell1";
            this.textBoxCell1.Size = new System.Drawing.Size(83, 20);
            this.textBoxCell1.TabIndex = 10;
            this.textBoxCell1.Text = "к";
            this.textBoxCell1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // radioButtonAction2
            // 
            this.radioButtonAction2.AutoSize = true;
            this.radioButtonAction2.Location = new System.Drawing.Point(6, 52);
            this.radioButtonAction2.MinimumSize = new System.Drawing.Size(227, 27);
            this.radioButtonAction2.Name = "radioButtonAction2";
            this.radioButtonAction2.Size = new System.Drawing.Size(227, 27);
            this.radioButtonAction2.TabIndex = 9;
            this.radioButtonAction2.TabStop = true;
            this.radioButtonAction2.Text = "Повторити кожен символ відмінний від:";
            this.radioButtonAction2.UseVisualStyleBackColor = true;
            // 
            // radioButtonAction1
            // 
            this.radioButtonAction1.AutoSize = true;
            this.radioButtonAction1.Location = new System.Drawing.Point(6, 19);
            this.radioButtonAction1.MinimumSize = new System.Drawing.Size(222, 27);
            this.radioButtonAction1.Name = "radioButtonAction1";
            this.radioButtonAction1.Size = new System.Drawing.Size(222, 27);
            this.radioButtonAction1.TabIndex = 8;
            this.radioButtonAction1.TabStop = true;
            this.radioButtonAction1.Text = "Видалити з текстового рядка символ:";
            this.radioButtonAction1.UseVisualStyleBackColor = true;
            // 
            // textBoxResult
            // 
            this.textBoxResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxResult.Location = new System.Drawing.Point(71, 3);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.Size = new System.Drawing.Size(238, 20);
            this.textBoxResult.TabIndex = 12;
            // 
            // textBoxInput
            // 
            this.textBoxInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxInput.Location = new System.Drawing.Point(109, 3);
            this.textBoxInput.MinimumSize = new System.Drawing.Size(200, 20);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(203, 20);
            this.textBoxInput.TabIndex = 11;
            this.textBoxInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelResult.Location = new System.Drawing.Point(3, 0);
            this.labelResult.MinimumSize = new System.Drawing.Size(62, 27);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(62, 27);
            this.labelResult.TabIndex = 10;
            this.labelResult.Text = "Результат:";
            this.labelResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelInput
            // 
            this.labelInput.AutoSize = true;
            this.labelInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelInput.Location = new System.Drawing.Point(3, 0);
            this.labelInput.MinimumSize = new System.Drawing.Size(100, 27);
            this.labelInput.Name = "labelInput";
            this.labelInput.Size = new System.Drawing.Size(100, 27);
            this.labelInput.TabIndex = 9;
            this.labelInput.Text = "Рядок для вводу:";
            this.labelInput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonCloseAction
            // 
            this.buttonCloseAction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonCloseAction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCloseAction.Location = new System.Drawing.Point(3, 195);
            this.buttonCloseAction.MinimumSize = new System.Drawing.Size(0, 24);
            this.buttonCloseAction.Name = "buttonCloseAction";
            this.buttonCloseAction.Size = new System.Drawing.Size(315, 48);
            this.buttonCloseAction.TabIndex = 8;
            this.buttonCloseAction.Text = "Завершення роботи";
            this.buttonCloseAction.UseVisualStyleBackColor = true;
            this.buttonCloseAction.Click += new System.EventHandler(this.buttonCloseAction_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.buttonCloseAction, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBoxRadioSwitch, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel6, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(321, 246);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.textBoxInput, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelInput, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.MinimumSize = new System.Drawing.Size(300, 27);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(315, 27);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Controls.Add(this.labelResult, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.textBoxResult, 1, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 162);
            this.tableLayoutPanel6.MinimumSize = new System.Drawing.Size(0, 27);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(315, 27);
            this.tableLayoutPanel6.TabIndex = 14;
            // 
            // FormLab16t1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 246);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(337, 285);
            this.Name = "FormLab16t1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Обробка рядка";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormLab16t1_FormClosing);
            this.groupBoxRadioSwitch.ResumeLayout(false);
            this.groupBoxRadioSwitch.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxRadioSwitch;
        private System.Windows.Forms.RadioButton radioButtonAction3;
        private System.Windows.Forms.TextBox textBoxCell2;
        private System.Windows.Forms.TextBox textBoxCell1;
        private System.Windows.Forms.RadioButton radioButtonAction2;
        private System.Windows.Forms.RadioButton radioButtonAction1;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Label labelInput;
        private System.Windows.Forms.Button buttonCloseAction;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
    }
}