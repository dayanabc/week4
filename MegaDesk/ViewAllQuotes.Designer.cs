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
            this.cancelViewButton.Location = new System.Drawing.Point(209, 440);
            this.cancelViewButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cancelViewButton.Name = "cancelViewButton";
            this.cancelViewButton.Size = new System.Drawing.Size(100, 28);
            this.cancelViewButton.TabIndex = 0;
            this.cancelViewButton.Text = "cancel";
            this.cancelViewButton.UseVisualStyleBackColor = true;
            this.cancelViewButton.Click += new System.EventHandler(this.cancelViewButton_Click);
            // 
            // ViewAllQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.cancelViewButton);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ViewAllQuotes";
            this.Text = "ViewAllQuotes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cancelViewButton;
    }
}