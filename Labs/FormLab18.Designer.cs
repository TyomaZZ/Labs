
namespace Labs
{
    partial class FormLab18
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
            this.statusStripMain = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonCalc = new System.Windows.Forms.Button();
            this.buttonStringer = new System.Windows.Forms.Button();
            this.buttonMatcher = new System.Windows.Forms.Button();
            this.buttonController = new System.Windows.Forms.Button();
            this.buttonFormCloser = new System.Windows.Forms.Button();
            this.statusStripMain.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStripMain
            // 
            this.statusStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStripMain.Location = new System.Drawing.Point(0, 423);
            this.statusStripMain.Name = "statusStripMain";
            this.statusStripMain.Size = new System.Drawing.Size(610, 22);
            this.statusStripMain.SizingGrip = false;
            this.statusStripMain.TabIndex = 0;
            this.statusStripMain.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(120, 17);
            this.toolStripStatusLabel1.Text = "Форм створено: 0/∞";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.buttonExit, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.buttonCalc, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.buttonStringer, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonMatcher, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonController, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.buttonFormCloser, 0, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(610, 423);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.SystemColors.Window;
            this.buttonExit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonExit.FlatAppearance.BorderSize = 2;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExit.Location = new System.Drawing.Point(6, 348);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(598, 67);
            this.buttonExit.TabIndex = 5;
            this.buttonExit.Text = "Закрити лабораторну";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonCalc
            // 
            this.buttonCalc.BackColor = System.Drawing.SystemColors.Window;
            this.buttonCalc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonCalc.FlatAppearance.BorderSize = 2;
            this.buttonCalc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCalc.Location = new System.Drawing.Point(6, 144);
            this.buttonCalc.Name = "buttonCalc";
            this.buttonCalc.Size = new System.Drawing.Size(598, 62);
            this.buttonCalc.TabIndex = 2;
            this.buttonCalc.Text = "Калькулятор";
            this.buttonCalc.UseVisualStyleBackColor = false;
            this.buttonCalc.Click += new System.EventHandler(this.buttonCalc_Click);
            // 
            // buttonStringer
            // 
            this.buttonStringer.BackColor = System.Drawing.SystemColors.Window;
            this.buttonStringer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonStringer.FlatAppearance.BorderSize = 2;
            this.buttonStringer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStringer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStringer.Location = new System.Drawing.Point(6, 8);
            this.buttonStringer.Name = "buttonStringer";
            this.buttonStringer.Size = new System.Drawing.Size(598, 62);
            this.buttonStringer.TabIndex = 0;
            this.buttonStringer.Text = "Обробка рядку";
            this.buttonStringer.UseVisualStyleBackColor = false;
            this.buttonStringer.Click += new System.EventHandler(this.buttonStringer_Click);
            // 
            // buttonMatcher
            // 
            this.buttonMatcher.BackColor = System.Drawing.SystemColors.Window;
            this.buttonMatcher.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonMatcher.FlatAppearance.BorderSize = 2;
            this.buttonMatcher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMatcher.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMatcher.Location = new System.Drawing.Point(6, 76);
            this.buttonMatcher.Name = "buttonMatcher";
            this.buttonMatcher.Size = new System.Drawing.Size(598, 62);
            this.buttonMatcher.TabIndex = 1;
            this.buttonMatcher.Text = "Підрахунок по формулі";
            this.buttonMatcher.UseVisualStyleBackColor = false;
            this.buttonMatcher.Click += new System.EventHandler(this.buttonMatcher_Click);
            // 
            // buttonController
            // 
            this.buttonController.BackColor = System.Drawing.SystemColors.Window;
            this.buttonController.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonController.FlatAppearance.BorderSize = 2;
            this.buttonController.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonController.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonController.Location = new System.Drawing.Point(6, 212);
            this.buttonController.Name = "buttonController";
            this.buttonController.Size = new System.Drawing.Size(598, 62);
            this.buttonController.TabIndex = 3;
            this.buttonController.Text = "Управління формами";
            this.buttonController.UseVisualStyleBackColor = false;
            this.buttonController.Click += new System.EventHandler(this.buttonController_Click);
            // 
            // buttonFormCloser
            // 
            this.buttonFormCloser.BackColor = System.Drawing.SystemColors.Window;
            this.buttonFormCloser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonFormCloser.FlatAppearance.BorderSize = 2;
            this.buttonFormCloser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFormCloser.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFormCloser.Location = new System.Drawing.Point(6, 280);
            this.buttonFormCloser.Name = "buttonFormCloser";
            this.buttonFormCloser.Size = new System.Drawing.Size(598, 62);
            this.buttonFormCloser.TabIndex = 4;
            this.buttonFormCloser.Text = "Закрити всі створені форми";
            this.buttonFormCloser.UseVisualStyleBackColor = false;
            this.buttonFormCloser.Click += new System.EventHandler(this.buttonFormCloser_Click);
            // 
            // FormLab18
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 445);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.statusStripMain);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 400);
            this.Name = "FormLab18";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Лабораторна 18";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormLab18_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormLab18_FormClosed);
            this.Move += new System.EventHandler(this.FormLab18_Move);
            this.statusStripMain.ResumeLayout(false);
            this.statusStripMain.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStripMain;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonCalc;
        private System.Windows.Forms.Button buttonStringer;
        private System.Windows.Forms.Button buttonMatcher;
        private System.Windows.Forms.Button buttonController;
        private System.Windows.Forms.Button buttonFormCloser;
        public System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        public System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}