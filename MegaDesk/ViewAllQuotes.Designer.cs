namespace MegaDesk
{
    partial class ViewAllQuotes
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
            this.cancelViewButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cancelViewButton
            // 
            this.cancelViewButton.Location = new System.Drawing.Point(427, 344);
            this.cancelViewButton.Name = "cancelViewButton";
            this.cancelViewButton.Size = new System.Drawing.Size(75, 23);
            this.cancelViewButton.TabIndex = 0;
            this.cancelViewButton.Text = "cancel";
            this.cancelViewButton.UseVisualStyleBackColor = true;
            this.cancelViewButton.Click += new System.EventHandler(this.cancelViewButton_Click);
            // 
            // ViewAllQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cancelViewButton);
            this.Name = "ViewAllQuotes";
            this.Text = "ViewAllQuotes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cancelViewButton;
    }
}