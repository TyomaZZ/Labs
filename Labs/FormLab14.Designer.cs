
namespace Labs
{
    partial class FormLab14
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
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonSaveDefault = new System.Windows.Forms.Button();
            this.buttonRead = new System.Windows.Forms.Button();
            this.buttonReadDefault = new System.Windows.Forms.Button();
            this.buttonSaveInBase = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // YearCount
            // 
            this.YearCount.Size = new System.Drawing.Size(19, 13);
            this.YearCount.Text = "22";
            // 
            // CardPIB
            // 
            this.CardPIB.Size = new System.Drawing.Size(152, 13);
            this.CardPIB.Text = "ПІБ: Кухарук Артем Ігорович";
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.SystemColors.Window;
            this.buttonSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.ForeColor = System.Drawing.Color.Black;
            this.buttonSave.Location = new System.Drawing.Point(6, 65);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(272, 40);
            this.buttonSave.TabIndex = 16;
            this.buttonSave.Text = "Зберегти у інший файл";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonSaveDefault
            // 
            this.buttonSaveDefault.BackColor = System.Drawing.SystemColors.Window;
            this.buttonSaveDefault.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSaveDefault.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveDefault.ForeColor = System.Drawing.Color.Black;
            this.buttonSaveDefault.Location = new System.Drawing.Point(6, 19);
            this.buttonSaveDefault.Name = "buttonSaveDefault";
            this.buttonSaveDefault.Size = new System.Drawing.Size(272, 40);
            this.buttonSaveDefault.TabIndex = 17;
            this.buttonSaveDefault.Text = "Зберегти у файл по замовчуванню";
            this.buttonSaveDefault.UseVisualStyleBackColor = false;
            this.buttonSaveDefault.Click += new System.EventHandler(this.buttonSaveDefault_Click);
            // 
            // buttonRead
            // 
            this.buttonRead.BackColor = System.Drawing.SystemColors.Window;
            this.buttonRead.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRead.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRead.Location = new System.Drawing.Point(6, 61);
            this.buttonRead.Name = "buttonRead";
            this.buttonRead.Size = new System.Drawing.Size(274, 40);
            this.buttonRead.TabIndex = 18;
            this.buttonRead.Text = "Зчитати з іншого файла";
            this.buttonRead.UseVisualStyleBackColor = false;
            this.buttonRead.Click += new System.EventHandler(this.buttonRead_Click);
            // 
            // buttonReadDefault
            // 
            this.buttonReadDefault.BackColor = System.Drawing.SystemColors.Window;
            this.buttonReadDefault.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonReadDefault.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReadDefault.Location = new System.Drawing.Point(6, 15);
            this.buttonReadDefault.Name = "buttonReadDefault";
            this.buttonReadDefault.Size = new System.Drawing.Size(274, 40);
            this.buttonReadDefault.TabIndex = 19;
            this.buttonReadDefault.Text = "Зчитати з файла по замовчуванню";
            this.buttonReadDefault.UseVisualStyleBackColor = false;
            this.buttonReadDefault.Click += new System.EventHandler(this.buttonReadDefault_Click);
            // 
            // buttonSaveInBase
            // 
            this.buttonSaveInBase.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonSaveInBase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveInBase.Location = new System.Drawing.Point(12, 358);
            this.buttonSaveInBase.Name = "buttonSaveInBase";
            this.buttonSaveInBase.Size = new System.Drawing.Size(527, 23);
            this.buttonSaveInBase.TabIndex = 20;
            this.buttonSaveInBase.Text = "Збереження до загальної бази з унікальним ім\'ям";
            this.buttonSaveInBase.UseVisualStyleBackColor = false;
            this.buttonSaveInBase.Click += new System.EventHandler(this.buttonSaveInBase_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.buttonSaveDefault);
            this.groupBox4.Controls.Add(this.buttonSave);
            this.groupBox4.Location = new System.Drawing.Point(12, 234);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(285, 118);
            this.groupBox4.TabIndex = 21;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Збереження";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.buttonReadDefault);
            this.groupBox5.Controls.Add(this.buttonRead);
            this.groupBox5.Location = new System.Drawing.Point(303, 238);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(285, 114);
            this.groupBox5.TabIndex = 22;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Зчитування";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(538, 358);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "База";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(186, 210);
            this.comboBox1.MaxDropDownItems = 99;
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBox1.Size = new System.Drawing.Size(189, 21);
            this.comboBox1.Sorted = true;
            this.comboBox1.TabIndex = 24;
            this.comboBox1.Text = "Вибрати зі списку";
            this.comboBox1.Click += new System.EventHandler(this.comboBox1_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(382, 208);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(201, 23);
            this.button2.TabIndex = 25;
            this.button2.Text = "Завантажити файл з бази";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormLab14
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 389);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.buttonSaveInBase);
            this.Name = "FormLab14";
            this.Text = "Лабораторна робота 14";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormLab14_FormClosed);
            this.Load += new System.EventHandler(this.FormLab14_Load);
            this.Controls.SetChildIndex(this.buttonSaveInBase, 0);
            this.Controls.SetChildIndex(this.groupBox4, 0);
            this.Controls.SetChildIndex(this.groupBox5, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.comboBox1, 0);
            this.Controls.SetChildIndex(this.button2, 0);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonSaveDefault;
        private System.Windows.Forms.Button buttonRead;
        private System.Windows.Forms.Button buttonReadDefault;
        private System.Windows.Forms.Button buttonSaveInBase;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button2;
    }
}