namespace KeyLogger
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblKeyPressedLabel = new System.Windows.Forms.Label();
            this.lblKeyInformation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblKeyPressedLabel
            // 
            this.lblKeyPressedLabel.AutoSize = true;
            this.lblKeyPressedLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblKeyPressedLabel.Location = new System.Drawing.Point(12, 36);
            this.lblKeyPressedLabel.Name = "lblKeyPressedLabel";
            this.lblKeyPressedLabel.Size = new System.Drawing.Size(63, 25);
            this.lblKeyPressedLabel.TabIndex = 1;
            this.lblKeyPressedLabel.Text = "label1";
            // 
            // lblKeyInformation
            // 
            this.lblKeyInformation.AutoSize = true;
            this.lblKeyInformation.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblKeyInformation.Location = new System.Drawing.Point(12, 86);
            this.lblKeyInformation.Name = "lblKeyInformation";
            this.lblKeyInformation.Size = new System.Drawing.Size(63, 25);
            this.lblKeyInformation.TabIndex = 2;
            this.lblKeyInformation.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 389);
            this.Controls.Add(this.lblKeyInformation);
            this.Controls.Add(this.lblKeyPressedLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lblKeyPressedLabel;
        private Label lblKeyInformation;
    }
}