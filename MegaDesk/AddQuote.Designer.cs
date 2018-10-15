using System;
using System.Windows.Forms;

namespace MegaDesk
{
   public  partial class AddQuote
    {
        private Form _mainMenu;

        
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
            this.cancelQuotesButton = new System.Windows.Forms.Button();
            this.WidthSize = new System.Windows.Forms.NumericUpDown();
            this.DepthSize = new System.Windows.Forms.NumericUpDown();
            this.labelNewQuote = new System.Windows.Forms.Label();
            this.SurfaceLAbel = new System.Windows.Forms.Label();
            this.DepthLabel = new System.Windows.Forms.Label();
            this.WidthLabel = new System.Windows.Forms.Label();
            this.DeliveryLabel = new System.Windows.Forms.Label();
            this.GetQuoteButton = new System.Windows.Forms.Button();
            this.drawerNum = new System.Windows.Forms.NumericUpDown();
            this.DrawerNlabel = new System.Windows.Forms.Label();
            this.NameInput = new System.Windows.Forms.TextBox();
            this.Namelabel = new System.Windows.Forms.Label();
            this.ShippingInput = new System.Windows.Forms.ComboBox();
            this.MaterialInput = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.WidthSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DepthSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drawerNum)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelQuotesButton
            // 
            this.cancelQuotesButton.Location = new System.Drawing.Point(298, 244);
            this.cancelQuotesButton.Name = "cancelQuotesButton";
            this.cancelQuotesButton.Size = new System.Drawing.Size(75, 23);
            this.cancelQuotesButton.TabIndex = 0;
            this.cancelQuotesButton.Text = "Cancel";
            this.cancelQuotesButton.UseVisualStyleBackColor = true;
            this.cancelQuotesButton.Click += new System.EventHandler(this.cancelQuotesButton_Click);
            // 
            // WidthSize
            // 
            this.WidthSize.Location = new System.Drawing.Point(103, 135);
            this.WidthSize.Name = "WidthSize";
            this.WidthSize.Size = new System.Drawing.Size(120, 20);
            this.WidthSize.TabIndex = 1;
            // 
            // DepthSize
            // 
            this.DepthSize.Location = new System.Drawing.Point(103, 178);
            this.DepthSize.Name = "DepthSize";
            this.DepthSize.Size = new System.Drawing.Size(120, 20);
            this.DepthSize.TabIndex = 2;
            // 
            // labelNewQuote
            // 
            this.labelNewQuote.Location = new System.Drawing.Point(225, 24);
            this.labelNewQuote.Name = "labelNewQuote";
            this.labelNewQuote.Size = new System.Drawing.Size(80, 13);
            this.labelNewQuote.TabIndex = 5;
            this.labelNewQuote.Text = "New Quote";
            // 
            // SurfaceLAbel
            // 
            this.SurfaceLAbel.AutoSize = true;
            this.SurfaceLAbel.Location = new System.Drawing.Point(295, 137);
            this.SurfaceLAbel.Name = "SurfaceLAbel";
            this.SurfaceLAbel.Size = new System.Drawing.Size(90, 13);
            this.SurfaceLAbel.TabIndex = 6;
            this.SurfaceLAbel.Text = "Surface  Material:";
            // 
            // DepthLabel
            // 
            this.DepthLabel.AutoSize = true;
            this.DepthLabel.Location = new System.Drawing.Point(58, 180);
            this.DepthLabel.Name = "DepthLabel";
            this.DepthLabel.Size = new System.Drawing.Size(39, 13);
            this.DepthLabel.TabIndex = 7;
            this.DepthLabel.Text = "Depth:";
            // 
            // WidthLabel
            // 
            this.WidthLabel.AutoSize = true;
            this.WidthLabel.Location = new System.Drawing.Point(58, 137);
            this.WidthLabel.Name = "WidthLabel";
            this.WidthLabel.Size = new System.Drawing.Size(38, 13);
            this.WidthLabel.TabIndex = 8;
            this.WidthLabel.Text = "Width:";
            // 
            // DeliveryLabel
            // 
            this.DeliveryLabel.AutoSize = true;
            this.DeliveryLabel.Location = new System.Drawing.Point(336, 185);
            this.DeliveryLabel.Name = "DeliveryLabel";
            this.DeliveryLabel.Size = new System.Drawing.Size(48, 13);
            this.DeliveryLabel.TabIndex = 9;
            this.DeliveryLabel.Text = "Delivery:";
            // 
            // GetQuoteButton
            // 
            this.GetQuoteButton.Location = new System.Drawing.Point(171, 244);
            this.GetQuoteButton.Name = "GetQuoteButton";
            this.GetQuoteButton.Size = new System.Drawing.Size(75, 23);
            this.GetQuoteButton.TabIndex = 10;
            this.GetQuoteButton.Text = "Get Quote";
            this.GetQuoteButton.UseVisualStyleBackColor = true;
            this.GetQuoteButton.Click += new System.EventHandler(this.GetQuoteButton_Click);
            // 
            // drawerNum
            // 
            this.drawerNum.Location = new System.Drawing.Point(389, 98);
            this.drawerNum.Name = "drawerNum";
            this.drawerNum.Size = new System.Drawing.Size(42, 20);
            this.drawerNum.TabIndex = 11;
            // 
            // DrawerNlabel
            // 
            this.DrawerNlabel.AutoSize = true;
            this.DrawerNlabel.Location = new System.Drawing.Point(288, 105);
            this.DrawerNlabel.Name = "DrawerNlabel";
            this.DrawerNlabel.Size = new System.Drawing.Size(96, 13);
            this.DrawerNlabel.TabIndex = 12;
            this.DrawerNlabel.Text = "Number of Drawer:";
            // 
            // NameInput
            // 
            this.NameInput.Location = new System.Drawing.Point(205, 61);
            this.NameInput.Name = "NameInput";
            this.NameInput.Size = new System.Drawing.Size(100, 20);
            this.NameInput.TabIndex = 13;
            // 
            // Namelabel
            // 
            this.Namelabel.AutoSize = true;
            this.Namelabel.Location = new System.Drawing.Point(114, 64);
            this.Namelabel.Name = "Namelabel";
            this.Namelabel.Size = new System.Drawing.Size(85, 13);
            this.Namelabel.TabIndex = 14;
            this.Namelabel.Text = "Customer Name:";
            // 
            // ShippingInput
            // 
            this.ShippingInput.FormattingEnabled = true;
            this.ShippingInput.Location = new System.Drawing.Point(390, 185);
            this.ShippingInput.Name = "ShippingInput";
            this.ShippingInput.Size = new System.Drawing.Size(121, 21);
            this.ShippingInput.TabIndex = 15;
            // 
            // MaterialInput
            // 
            this.MaterialInput.FormattingEnabled = true;
            this.MaterialInput.Location = new System.Drawing.Point(391, 137);
            this.MaterialInput.Name = "MaterialInput";
            this.MaterialInput.Size = new System.Drawing.Size(121, 21);
            this.MaterialInput.TabIndex = 16;
            // 
            // AddQuote
            // 
            this.ClientSize = new System.Drawing.Size(553, 403);
            this.Controls.Add(this.MaterialInput);
            this.Controls.Add(this.ShippingInput);
            this.Controls.Add(this.Namelabel);
            this.Controls.Add(this.NameInput);
            this.Controls.Add(this.DrawerNlabel);
            this.Controls.Add(this.drawerNum);
            this.Controls.Add(this.GetQuoteButton);
            this.Controls.Add(this.DeliveryLabel);
            this.Controls.Add(this.WidthLabel);
            this.Controls.Add(this.DepthLabel);
            this.Controls.Add(this.SurfaceLAbel);
            this.Controls.Add(this.labelNewQuote);
            this.Controls.Add(this.DepthSize);
            this.Controls.Add(this.WidthSize);
            this.Controls.Add(this.cancelQuotesButton);
            this.Name = "AddQuote";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddQuote_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.WidthSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DepthSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drawerNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

      
        #endregion

        private Button CancelQuoteButton;
        private Button cancel;
        private Button cancelQuotesButton;
        private NumericUpDown WidthSize;
        private NumericUpDown DepthSize;
        private Label labelNewQuote;
        private Label SurfaceLAbel;
        private Label DepthLabel;
        private Label WidthLabel;
        private Label DeliveryLabel;
        private Button GetQuoteButton;
        private NumericUpDown drawerNum;
        private Label DrawerNlabel;
        private TextBox NameInput;
        private Label Namelabel;
        private ComboBox ShippingInput;
        private ComboBox MaterialInput;
    }
}