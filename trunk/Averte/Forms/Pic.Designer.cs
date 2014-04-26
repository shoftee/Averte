namespace Averte
{
    partial class Pic
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
            this.PicTextBox = new MetroFramework.Controls.MetroTextBox();
            this.OKButton = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // PicTextBox
            // 
            this.PicTextBox.Location = new System.Drawing.Point(23, 63);
            this.PicTextBox.Name = "PicTextBox";
            this.PicTextBox.PasswordChar = '*';
            this.PicTextBox.Size = new System.Drawing.Size(255, 23);
            this.PicTextBox.TabIndex = 0;
            this.PicTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(203, 92);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 1;
            this.OKButton.Text = "OK";
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // Pic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 140);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.PicTextBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Pic";
            this.Resizable = false;
            this.Text = "Pic";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox PicTextBox;
        private MetroFramework.Controls.MetroButton OKButton;
    }
}