namespace WindowsFormsApplication1
{
    partial class ConsoleGUI
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
            this.Execute = new System.Windows.Forms.Button();
            this.Commands = new System.Windows.Forms.TextBox();
            this.Results = new System.Windows.Forms.TextBox();
            this.Errors = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Execute
            // 
            this.Execute.Location = new System.Drawing.Point(12, 237);
            this.Execute.Name = "Execute";
            this.Execute.Size = new System.Drawing.Size(75, 23);
            this.Execute.TabIndex = 1;
            this.Execute.Text = "Execute";
            this.Execute.UseVisualStyleBackColor = true;
            this.Execute.Click += new System.EventHandler(this.Execute_Click);
            // 
            // Commands
            // 
            this.Commands.Location = new System.Drawing.Point(12, 12);
            this.Commands.Multiline = true;
            this.Commands.Name = "Commands";
            this.Commands.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Commands.Size = new System.Drawing.Size(644, 219);
            this.Commands.TabIndex = 0;
            // 
            // Results
            // 
            this.Results.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Results.Location = new System.Drawing.Point(12, 266);
            this.Results.Multiline = true;
            this.Results.Name = "Results";
            this.Results.ReadOnly = true;
            this.Results.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Results.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Results.Size = new System.Drawing.Size(644, 219);
            this.Results.TabIndex = 2;
            // 
            // Errors
            // 
            this.Errors.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Errors.Location = new System.Drawing.Point(662, 12);
            this.Errors.Multiline = true;
            this.Errors.Name = "Errors";
            this.Errors.ReadOnly = true;
            this.Errors.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Errors.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Errors.Size = new System.Drawing.Size(205, 473);
            this.Errors.TabIndex = 3;
            // 
            // ConsoleGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 494);
            this.Controls.Add(this.Errors);
            this.Controls.Add(this.Results);
            this.Controls.Add(this.Commands);
            this.Controls.Add(this.Execute);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ConsoleGUI";
            this.Text = "Console GUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Execute;
        private System.Windows.Forms.TextBox Commands;
        private System.Windows.Forms.TextBox Results;
        private System.Windows.Forms.TextBox Errors;
    }
}