namespace Labs
{
    partial class lab2_Form
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
            this.lab2_panel0 = new System.Windows.Forms.Panel();
            this.lab2_exitButton7 = new System.Windows.Forms.Button();
            this.lab2_var7_button2 = new System.Windows.Forms.Button();
            this.lab2_var7_button1 = new System.Windows.Forms.Button();
            this.lab2_panel0.SuspendLayout();
            this.SuspendLayout();
            // 
            // lab2_panel0
            // 
            this.lab2_panel0.Controls.Add(this.lab2_exitButton7);
            this.lab2_panel0.Controls.Add(this.lab2_var7_button2);
            this.lab2_panel0.Controls.Add(this.lab2_var7_button1);
            this.lab2_panel0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lab2_panel0.Location = new System.Drawing.Point(0, 0);
            this.lab2_panel0.Name = "lab2_panel0";
            this.lab2_panel0.Size = new System.Drawing.Size(517, 112);
            this.lab2_panel0.TabIndex = 0;
            // 
            // lab2_exitButton7
            // 
            this.lab2_exitButton7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lab2_exitButton7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lab2_exitButton7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lab2_exitButton7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lab2_exitButton7.Location = new System.Drawing.Point(10, 69);
            this.lab2_exitButton7.Name = "lab2_exitButton7";
            this.lab2_exitButton7.Size = new System.Drawing.Size(498, 36);
            this.lab2_exitButton7.TabIndex = 5;
            this.lab2_exitButton7.Text = "Завершити роботу";
            this.lab2_exitButton7.UseVisualStyleBackColor = false;
            this.lab2_exitButton7.Click += new System.EventHandler(this.lab2_exitButton_Click);
            // 
            // lab2_var7_button2
            // 
            this.lab2_var7_button2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lab2_var7_button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lab2_var7_button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lab2_var7_button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lab2_var7_button2.Location = new System.Drawing.Point(262, 12);
            this.lab2_var7_button2.Name = "lab2_var7_button2";
            this.lab2_var7_button2.Size = new System.Drawing.Size(246, 51);
            this.lab2_var7_button2.TabIndex = 4;
            this.lab2_var7_button2.Text = "Верхній одяг з параметрами";
            this.lab2_var7_button2.UseVisualStyleBackColor = false;
            this.lab2_var7_button2.Click += new System.EventHandler(this.lab2_var7_button2_Click);
            // 
            // lab2_var7_button1
            // 
            this.lab2_var7_button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lab2_var7_button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lab2_var7_button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lab2_var7_button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lab2_var7_button1.Location = new System.Drawing.Point(10, 12);
            this.lab2_var7_button1.Name = "lab2_var7_button1";
            this.lab2_var7_button1.Size = new System.Drawing.Size(246, 51);
            this.lab2_var7_button1.TabIndex = 3;
            this.lab2_var7_button1.Text = "Верхній одяг по замовчуванню";
            this.lab2_var7_button1.UseVisualStyleBackColor = false;
            this.lab2_var7_button1.Click += new System.EventHandler(this.lab2_var7_button1_Click);
            // 
            // lab2_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 112);
            this.Controls.Add(this.lab2_panel0);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "lab2_Form";
            this.Opacity = 0.99D;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Лабораторна робота 2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.lab2_Form_FormClosing);
            this.lab2_panel0.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel lab2_panel0;
        private System.Windows.Forms.Button lab2_exitButton7;
        private System.Windows.Forms.Button lab2_var7_button2;
        private System.Windows.Forms.Button lab2_var7_button1;
    }
}