
namespace Labs
{
    partial class FormLab17
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonStringer
            // 
            this.buttonStringer.FlatAppearance.BorderSize = 2;
            this.buttonStringer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumOrchid;
            // 
            // buttonMatcher
            // 
            this.buttonMatcher.FlatAppearance.BorderSize = 2;
            this.buttonMatcher.FlatAppearance.MouseOverBackColor = System.Drawing.Color.HotPink;
            // 
            // buttonCalc
            // 
            this.buttonCalc.FlatAppearance.BorderSize = 2;
            this.buttonCalc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            // 
            // buttonEnder
            // 
            this.buttonEnder.FlatAppearance.BorderSize = 2;
            this.buttonEnder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            // 
            // buttonCloser
            // 
            this.buttonCloser.FlatAppearance.BorderSize = 2;
            this.buttonCloser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed;
            this.buttonCloser.Location = new System.Drawing.Point(12, 304);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 366);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(341, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(116, 17);
            this.toolStripStatusLabel1.Text = "Форм створено: 0/5";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(12, 250);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(322, 48);
            this.button1.TabIndex = 6;
            this.button1.Text = "Каскад";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormLab17
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 388);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "FormLab17";
            this.Text = "Лабораторна 17";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormLab17_FormClosing);
            this.Controls.SetChildIndex(this.buttonStringer, 0);
            this.Controls.SetChildIndex(this.buttonMatcher, 0);
            this.Controls.SetChildIndex(this.buttonCalc, 0);
            this.Controls.SetChildIndex(this.buttonEnder, 0);
            this.Controls.SetChildIndex(this.buttonCloser, 0);
            this.Controls.SetChildIndex(this.statusStrip1, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        public System.Windows.Forms.Button button1;
    }
}