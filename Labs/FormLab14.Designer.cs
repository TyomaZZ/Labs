
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
            this.SuspendLayout();
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.SeaGreen;
            this.buttonSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonSave.Location = new System.Drawing.Point(9, 291);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(200, 40);
            this.buttonSave.TabIndex = 16;
            this.buttonSave.Text = "Зберегти у інший файл";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonSaveDefault
            // 
            this.buttonSaveDefault.BackColor = System.Drawing.Color.SeaGreen;
            this.buttonSaveDefault.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSaveDefault.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveDefault.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonSaveDefault.Location = new System.Drawing.Point(9, 245);
            this.buttonSaveDefault.Name = "buttonSaveDefault";
            this.buttonSaveDefault.Size = new System.Drawing.Size(200, 40);
            this.buttonSaveDefault.TabIndex = 17;
            this.buttonSaveDefault.Text = "Зберегти у файл по замовчуванню";
            this.buttonSaveDefault.UseVisualStyleBackColor = false;
            this.buttonSaveDefault.Click += new System.EventHandler(this.buttonSaveDefault_Click);
            // 
            // buttonRead
            // 
            this.buttonRead.BackColor = System.Drawing.Color.Yellow;
            this.buttonRead.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRead.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRead.Location = new System.Drawing.Point(215, 291);
            this.buttonRead.Name = "buttonRead";
            this.buttonRead.Size = new System.Drawing.Size(199, 40);
            this.buttonRead.TabIndex = 18;
            this.buttonRead.Text = "Зчитати з іншого файла";
            this.buttonRead.UseVisualStyleBackColor = false;
            this.buttonRead.Click += new System.EventHandler(this.buttonRead_Click);
            // 
            // buttonReadDefault
            // 
            this.buttonReadDefault.BackColor = System.Drawing.Color.Yellow;
            this.buttonReadDefault.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonReadDefault.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReadDefault.Location = new System.Drawing.Point(214, 245);
            this.buttonReadDefault.Name = "buttonReadDefault";
            this.buttonReadDefault.Size = new System.Drawing.Size(200, 40);
            this.buttonReadDefault.TabIndex = 19;
            this.buttonReadDefault.Text = "Зчитати з файла по замовчуванню";
            this.buttonReadDefault.UseVisualStyleBackColor = false;
            this.buttonReadDefault.Click += new System.EventHandler(this.buttonReadDefault_Click);
            // 
            // buttonSaveInBase
            // 
            this.buttonSaveInBase.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonSaveInBase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveInBase.Location = new System.Drawing.Point(9, 334);
            this.buttonSaveInBase.Name = "buttonSaveInBase";
            this.buttonSaveInBase.Size = new System.Drawing.Size(405, 23);
            this.buttonSaveInBase.TabIndex = 20;
            this.buttonSaveInBase.Text = "Зберегти в базу";
            this.buttonSaveInBase.UseVisualStyleBackColor = false;
            this.buttonSaveInBase.Click += new System.EventHandler(this.buttonSaveInBase_Click);
            // 
            // FormLab14
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 393);
            this.Controls.Add(this.buttonSaveInBase);
            this.Controls.Add(this.buttonReadDefault);
            this.Controls.Add(this.buttonRead);
            this.Controls.Add(this.buttonSaveDefault);
            this.Controls.Add(this.buttonSave);
            this.Name = "FormLab14";
            this.Text = "Лабораторна робота 14";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormLab14_FormClosed);
            this.Load += new System.EventHandler(this.FormLab14_Load);
            this.Controls.SetChildIndex(this.PIB, 0);
            this.Controls.SetChildIndex(this.FatherName, 0);
            this.Controls.SetChildIndex(this.LastName, 0);
            this.Controls.SetChildIndex(this.FirstName, 0);
            this.Controls.SetChildIndex(this.BirthdayDay, 0);
            this.Controls.SetChildIndex(this.buttonSave, 0);
            this.Controls.SetChildIndex(this.buttonSaveDefault, 0);
            this.Controls.SetChildIndex(this.buttonRead, 0);
            this.Controls.SetChildIndex(this.buttonReadDefault, 0);
            this.Controls.SetChildIndex(this.buttonSaveInBase, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonSaveDefault;
        private System.Windows.Forms.Button buttonRead;
        private System.Windows.Forms.Button buttonReadDefault;
        private System.Windows.Forms.Button buttonSaveInBase;
    }
}