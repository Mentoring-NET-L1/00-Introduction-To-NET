namespace Hello.WinForm
{
    partial class MainForm
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
            this.btnShowHelllo = new System.Windows.Forms.Button();
            this.txbInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnShowHelllo
            // 
            this.btnShowHelllo.Location = new System.Drawing.Point(70, 78);
            this.btnShowHelllo.Name = "btnShowHelllo";
            this.btnShowHelllo.Size = new System.Drawing.Size(75, 23);
            this.btnShowHelllo.TabIndex = 0;
            this.btnShowHelllo.Text = "Hello!";
            this.btnShowHelllo.UseVisualStyleBackColor = true;
            this.btnShowHelllo.Click += new System.EventHandler(this.btnShowHelllo_Click);
            // 
            // txbInput
            // 
            this.txbInput.Location = new System.Drawing.Point(12, 38);
            this.txbInput.Name = "txbInput";
            this.txbInput.Size = new System.Drawing.Size(195, 20);
            this.txbInput.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(219, 136);
            this.Controls.Add(this.txbInput);
            this.Controls.Add(this.btnShowHelllo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.Text = "Hello";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShowHelllo;
        private System.Windows.Forms.TextBox txbInput;
    }
}

