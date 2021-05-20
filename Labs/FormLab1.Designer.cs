namespace Labs
{
    partial class lab1_Form
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
            this.hello_label = new System.Windows.Forms.Label();
            this.history1_button = new System.Windows.Forms.Button();
            this.lab1_panel = new System.Windows.Forms.Panel();
            this.exit_button = new System.Windows.Forms.Button();
            this.history5_button = new System.Windows.Forms.Button();
            this.history4_button = new System.Windows.Forms.Button();
            this.history3_button = new System.Windows.Forms.Button();
            this.history2_button = new System.Windows.Forms.Button();
            this.lab1_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // hello_label
            // 
            this.hello_label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hello_label.AutoSize = true;
            this.hello_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hello_label.Location = new System.Drawing.Point(50, 7);
            this.hello_label.Name = "hello_label";
            this.hello_label.Size = new System.Drawing.Size(131, 24);
            this.hello_label.TabIndex = 0;
            this.hello_label.Text = "Доброго дня!";
            this.hello_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // history1_button
            // 
            this.history1_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.history1_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.history1_button.Location = new System.Drawing.Point(10, 48);
            this.history1_button.Name = "history1_button";
            this.history1_button.Size = new System.Drawing.Size(197, 23);
            this.history1_button.TabIndex = 1;
            this.history1_button.Text = "Історія №1";
            this.history1_button.UseVisualStyleBackColor = true;
            this.history1_button.Click += new System.EventHandler(this.History1_button_Click);
            // 
            // lab1_panel
            // 
            this.lab1_panel.Controls.Add(this.exit_button);
            this.lab1_panel.Controls.Add(this.history5_button);
            this.lab1_panel.Controls.Add(this.history4_button);
            this.lab1_panel.Controls.Add(this.history3_button);
            this.lab1_panel.Controls.Add(this.history2_button);
            this.lab1_panel.Controls.Add(this.history1_button);
            this.lab1_panel.Controls.Add(this.hello_label);
            this.lab1_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lab1_panel.Location = new System.Drawing.Point(0, 0);
            this.lab1_panel.Name = "lab1_panel";
            this.lab1_panel.Size = new System.Drawing.Size(217, 180);
            this.lab1_panel.TabIndex = 2;
            // 
            // exit_button
            // 
            this.exit_button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.exit_button.Cursor = System.Windows.Forms.Cursors.Default;
            this.exit_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exit_button.Location = new System.Drawing.Point(10, 135);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(197, 35);
            this.exit_button.TabIndex = 6;
            this.exit_button.Text = "Закрити форму";
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.Exit_button_Click);
            // 
            // history5_button
            // 
            this.history5_button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.history5_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.history5_button.Location = new System.Drawing.Point(111, 106);
            this.history5_button.Name = "history5_button";
            this.history5_button.Size = new System.Drawing.Size(96, 23);
            this.history5_button.TabIndex = 5;
            this.history5_button.Text = "Історія №5";
            this.history5_button.UseVisualStyleBackColor = true;
            this.history5_button.Visible = false;
            this.history5_button.Click += new System.EventHandler(this.History5_button_Click);
            // 
            // history4_button
            // 
            this.history4_button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.history4_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.history4_button.Location = new System.Drawing.Point(10, 106);
            this.history4_button.Name = "history4_button";
            this.history4_button.Size = new System.Drawing.Size(95, 23);
            this.history4_button.TabIndex = 4;
            this.history4_button.Text = "Історія №4";
            this.history4_button.UseVisualStyleBackColor = true;
            this.history4_button.Visible = false;
            this.history4_button.Click += new System.EventHandler(this.History4_button_Click);
            // 
            // history3_button
            // 
            this.history3_button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.history3_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.history3_button.Location = new System.Drawing.Point(111, 76);
            this.history3_button.Name = "history3_button";
            this.history3_button.Size = new System.Drawing.Size(96, 23);
            this.history3_button.TabIndex = 3;
            this.history3_button.Text = "Історія №3";
            this.history3_button.UseVisualStyleBackColor = true;
            this.history3_button.Visible = false;
            this.history3_button.Click += new System.EventHandler(this.History3_button_Click);
            // 
            // history2_button
            // 
            this.history2_button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.history2_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.history2_button.Location = new System.Drawing.Point(10, 76);
            this.history2_button.Name = "history2_button";
            this.history2_button.Size = new System.Drawing.Size(95, 23);
            this.history2_button.TabIndex = 2;
            this.history2_button.Text = "Історія №2";
            this.history2_button.UseVisualStyleBackColor = true;
            this.history2_button.Visible = false;
            this.history2_button.Click += new System.EventHandler(this.History2_button_Click);
            // 
            // lab1_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(217, 180);
            this.Controls.Add(this.lab1_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "lab1_Form";
            this.Opacity = 0.99D;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Лабораторна робота 1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Action_on_FormClosing);
            this.lab1_panel.ResumeLayout(false);
            this.lab1_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label hello_label;
        private System.Windows.Forms.Button history1_button;
        private System.Windows.Forms.Panel lab1_panel;
        private System.Windows.Forms.Button history5_button;
        private System.Windows.Forms.Button history4_button;
        private System.Windows.Forms.Button history3_button;
        private System.Windows.Forms.Button history2_button;
        private System.Windows.Forms.Button exit_button;
    }
}