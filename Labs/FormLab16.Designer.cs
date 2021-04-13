
namespace Labs
{
    partial class FormLab16
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
            this.buttonStringer = new System.Windows.Forms.Button();
            this.buttonMatcher = new System.Windows.Forms.Button();
            this.buttonCalc = new System.Windows.Forms.Button();
            this.buttonEnder = new System.Windows.Forms.Button();
            this.buttonCloser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonStringer
            // 
            this.buttonStringer.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonStringer.FlatAppearance.BorderSize = 2;
            this.buttonStringer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumOrchid;
            this.buttonStringer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStringer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStringer.Location = new System.Drawing.Point(13, 13);
            this.buttonStringer.Name = "buttonStringer";
            this.buttonStringer.Size = new System.Drawing.Size(322, 53);
            this.buttonStringer.TabIndex = 0;
            this.buttonStringer.Text = "Обробка рядка";
            this.buttonStringer.UseVisualStyleBackColor = false;
            this.buttonStringer.Click += new System.EventHandler(this.buttonStringer_Click);
            // 
            // buttonMatcher
            // 
            this.buttonMatcher.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonMatcher.FlatAppearance.BorderSize = 2;
            this.buttonMatcher.FlatAppearance.MouseOverBackColor = System.Drawing.Color.HotPink;
            this.buttonMatcher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMatcher.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMatcher.Location = new System.Drawing.Point(13, 72);
            this.buttonMatcher.Name = "buttonMatcher";
            this.buttonMatcher.Size = new System.Drawing.Size(322, 53);
            this.buttonMatcher.TabIndex = 1;
            this.buttonMatcher.Text = "Обчислення виразу";
            this.buttonMatcher.UseVisualStyleBackColor = false;
            this.buttonMatcher.Click += new System.EventHandler(this.buttonMatcher_Click);
            // 
            // buttonCalc
            // 
            this.buttonCalc.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonCalc.FlatAppearance.BorderSize = 2;
            this.buttonCalc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonCalc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCalc.Location = new System.Drawing.Point(12, 131);
            this.buttonCalc.Name = "buttonCalc";
            this.buttonCalc.Size = new System.Drawing.Size(322, 53);
            this.buttonCalc.TabIndex = 2;
            this.buttonCalc.Text = "Калькулятор";
            this.buttonCalc.UseVisualStyleBackColor = false;
            this.buttonCalc.Click += new System.EventHandler(this.buttonCalc_Click);
            // 
            // buttonEnder
            // 
            this.buttonEnder.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonEnder.FlatAppearance.BorderSize = 2;
            this.buttonEnder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.buttonEnder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEnder.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEnder.Location = new System.Drawing.Point(12, 190);
            this.buttonEnder.Name = "buttonEnder";
            this.buttonEnder.Size = new System.Drawing.Size(322, 53);
            this.buttonEnder.TabIndex = 3;
            this.buttonEnder.Text = "Закрити всі форми";
            this.buttonEnder.UseVisualStyleBackColor = false;
            this.buttonEnder.Click += new System.EventHandler(this.buttonEnder_Click);
            // 
            // buttonCloser
            // 
            this.buttonCloser.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonCloser.FlatAppearance.BorderSize = 2;
            this.buttonCloser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed;
            this.buttonCloser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCloser.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCloser.Location = new System.Drawing.Point(12, 249);
            this.buttonCloser.Name = "buttonCloser";
            this.buttonCloser.Size = new System.Drawing.Size(322, 53);
            this.buttonCloser.TabIndex = 4;
            this.buttonCloser.Text = "Завершити роботу";
            this.buttonCloser.UseVisualStyleBackColor = false;
            this.buttonCloser.Click += new System.EventHandler(this.buttonCloser_Click);
            // 
            // FormLab16
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 311);
            this.Controls.Add(this.buttonCloser);
            this.Controls.Add(this.buttonEnder);
            this.Controls.Add(this.buttonCalc);
            this.Controls.Add(this.buttonMatcher);
            this.Controls.Add(this.buttonStringer);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLab16";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Лабораторна 16";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonStringer;
        private System.Windows.Forms.Button buttonMatcher;
        private System.Windows.Forms.Button buttonCalc;
        private System.Windows.Forms.Button buttonEnder;
        private System.Windows.Forms.Button buttonCloser;
    }
}