namespace MegaDesk
{
    partial class SearchQuotes
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
            this.cancelSearchButton = new System.Windows.Forms.Button();
            this.comboSurfaceMaterial = new System.Windows.Forms.ComboBox();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelSearchButton
            // 
            this.cancelSearchButton.Location = new System.Drawing.Point(426, 352);
            this.cancelSearchButton.Name = "cancelSearchButton";
            this.cancelSearchButton.Size = new System.Drawing.Size(75, 23);
            this.cancelSearchButton.TabIndex = 0;
            this.cancelSearchButton.Text = "Cancel";
            this.cancelSearchButton.UseVisualStyleBackColor = true;
            this.cancelSearchButton.Click += new System.EventHandler(this.cancelSearchButton_Click);
            // 
            // comboSurfaceMaterial
            // 
            this.comboSurfaceMaterial.FormattingEnabled = true;
            this.comboSurfaceMaterial.Location = new System.Drawing.Point(380, 215);
            this.comboSurfaceMaterial.Name = "comboSurfaceMaterial";
            this.comboSurfaceMaterial.Size = new System.Drawing.Size(121, 21);
            this.comboSurfaceMaterial.TabIndex = 1;
            this.comboSurfaceMaterial.SelectedIndexChanged += new System.EventHandler(this.comboSurfaceMaterial_SelectedIndexChanged);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // SearchQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboSurfaceMaterial);
            this.Controls.Add(this.cancelSearchButton);
            this.Name = "SearchQuotes";
            this.Text = "SearchQuotes";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SearchQuotes_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cancelSearchButton;
        private System.Windows.Forms.ComboBox comboSurfaceMaterial;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
    }
}