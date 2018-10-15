using System;

namespace MegaDesk
{
    partial class MainMenu
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
            this.openAddQuoteButton = new System.Windows.Forms.Button();
            this.openViewQuoteButton = new System.Windows.Forms.Button();
            this.openSearchQuotesButton = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // openAddQuoteButton
            // 
            this.openAddQuoteButton.Location = new System.Drawing.Point(47, 43);
            this.openAddQuoteButton.Name = "openAddQuoteButton";
            this.openAddQuoteButton.Size = new System.Drawing.Size(150, 50);
            this.openAddQuoteButton.TabIndex = 0;
            this.openAddQuoteButton.Text = "Add New Quote";
            this.openAddQuoteButton.UseVisualStyleBackColor = true;
            this.openAddQuoteButton.Click += new System.EventHandler(this.openAddQuoteButton_Click);
            // 
            // openViewQuoteButton
            // 
            this.openViewQuoteButton.Location = new System.Drawing.Point(47, 99);
            this.openViewQuoteButton.Name = "openViewQuoteButton";
            this.openViewQuoteButton.Size = new System.Drawing.Size(150, 50);
            this.openViewQuoteButton.TabIndex = 1;
            this.openViewQuoteButton.Text = "View Quotes";
            this.openViewQuoteButton.UseVisualStyleBackColor = true;
            this.openViewQuoteButton.Click += new System.EventHandler(this.openViewQuoteButton_Click);
            // 
            // openSearchQuotesButton
            // 
            this.openSearchQuotesButton.Location = new System.Drawing.Point(47, 155);
            this.openSearchQuotesButton.Name = "openSearchQuotesButton";
            this.openSearchQuotesButton.Size = new System.Drawing.Size(150, 50);
            this.openSearchQuotesButton.TabIndex = 2;
            this.openSearchQuotesButton.Text = "Search Quotes";
            this.openSearchQuotesButton.UseVisualStyleBackColor = true;
            this.openSearchQuotesButton.Click += new System.EventHandler(this.openSearchQuotesButton_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(47, 211);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(150, 50);
            this.Exit.TabIndex = 3;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::MegaDesk.Properties.Resources.thRI4O6P2S;
            this.pictureBox3.Location = new System.Drawing.Point(239, 67);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(211, 175);
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // MegaDesk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.openSearchQuotesButton);
            this.Controls.Add(this.openViewQuoteButton);
            this.Controls.Add(this.openAddQuoteButton);
            this.Name = "MegaDesk";
            this.Text = "MegaDesk";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        

        #endregion

        private System.Windows.Forms.Button openAddQuoteButton;
        private System.Windows.Forms.Button openViewQuoteButton;
        private System.Windows.Forms.Button openSearchQuotesButton;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

