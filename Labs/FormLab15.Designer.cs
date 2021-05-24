
namespace Labs
{
    partial class FormLab15
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.повідомленняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.фотоальбомToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.розробникToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.середовищеРозробкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.університетToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.проПрограмуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вихідToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Window;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.повідомленняToolStripMenuItem,
            this.фотоальбомToolStripMenuItem,
            this.проПрограмуToolStripMenuItem,
            this.вихідToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // повідомленняToolStripMenuItem
            // 
            this.повідомленняToolStripMenuItem.Name = "повідомленняToolStripMenuItem";
            this.повідомленняToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.повідомленняToolStripMenuItem.Text = "Повідомлення";
            this.повідомленняToolStripMenuItem.Click += new System.EventHandler(this.повідомленняToolStripMenuItem_Click);
            // 
            // фотоальбомToolStripMenuItem
            // 
            this.фотоальбомToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.розробникToolStripMenuItem,
            this.середовищеРозробкиToolStripMenuItem,
            this.університетToolStripMenuItem});
            this.фотоальбомToolStripMenuItem.Name = "фотоальбомToolStripMenuItem";
            this.фотоальбомToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.фотоальбомToolStripMenuItem.Text = "Фотоальбом";
            // 
            // розробникToolStripMenuItem
            // 
            this.розробникToolStripMenuItem.Name = "розробникToolStripMenuItem";
            this.розробникToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.розробникToolStripMenuItem.Text = "Розробник";
            this.розробникToolStripMenuItem.Click += new System.EventHandler(this.розробникToolStripMenuItem_Click);
            // 
            // середовищеРозробкиToolStripMenuItem
            // 
            this.середовищеРозробкиToolStripMenuItem.Name = "середовищеРозробкиToolStripMenuItem";
            this.середовищеРозробкиToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.середовищеРозробкиToolStripMenuItem.Text = "Середовище розробки";
            this.середовищеРозробкиToolStripMenuItem.Click += new System.EventHandler(this.середовищеРозробкиToolStripMenuItem_Click);
            // 
            // університетToolStripMenuItem
            // 
            this.університетToolStripMenuItem.Name = "університетToolStripMenuItem";
            this.університетToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.університетToolStripMenuItem.Text = "Факультет";
            this.університетToolStripMenuItem.Click += new System.EventHandler(this.університетToolStripMenuItem_Click);
            // 
            // проПрограмуToolStripMenuItem
            // 
            this.проПрограмуToolStripMenuItem.Name = "проПрограмуToolStripMenuItem";
            this.проПрограмуToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.проПрограмуToolStripMenuItem.Text = "Про програму";
            this.проПрограмуToolStripMenuItem.Click += new System.EventHandler(this.проПрограмуToolStripMenuItem_Click);
            // 
            // вихідToolStripMenuItem
            // 
            this.вихідToolStripMenuItem.Name = "вихідToolStripMenuItem";
            this.вихідToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.вихідToolStripMenuItem.Text = "Вихід";
            this.вихідToolStripMenuItem.Click += new System.EventHandler(this.вихідToolStripMenuItem_Click);
            // 
            // FormLab15
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimizeBox = false;
            this.Name = "FormLab15";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Лабораторна 15";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormLab15_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem повідомленняToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem фотоальбомToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem проПрограмуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вихідToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem розробникToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem середовищеРозробкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem університетToolStripMenuItem;
    }
}