namespace CustomControllers
{
    partial class CustomListItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbUpgradeImage = new System.Windows.Forms.PictureBox();
            this.lblUpgradeName = new System.Windows.Forms.Label();
            this.pbBread = new System.Windows.Forms.PictureBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblAmmount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbUpgradeImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBread)).BeginInit();
            this.SuspendLayout();
            // 
            // pbUpgradeImage
            // 
            this.pbUpgradeImage.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.pbUpgradeImage.Location = new System.Drawing.Point(3, 3);
            this.pbUpgradeImage.Name = "pbUpgradeImage";
            this.pbUpgradeImage.Size = new System.Drawing.Size(72, 72);
            this.pbUpgradeImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbUpgradeImage.TabIndex = 0;
            this.pbUpgradeImage.TabStop = false;
            this.pbUpgradeImage.Click += new System.EventHandler(this.OnClick);
            // 
            // lblUpgradeName
            // 
            this.lblUpgradeName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUpgradeName.Font = new System.Drawing.Font("Lato", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpgradeName.Location = new System.Drawing.Point(81, 7);
            this.lblUpgradeName.Name = "lblUpgradeName";
            this.lblUpgradeName.Size = new System.Drawing.Size(218, 30);
            this.lblUpgradeName.TabIndex = 1;
            this.lblUpgradeName.Text = "Upgrade Name";
            this.lblUpgradeName.Click += new System.EventHandler(this.OnClick);
            // 
            // pbBread
            // 
            this.pbBread.BackColor = System.Drawing.Color.Bisque;
            this.pbBread.Location = new System.Drawing.Point(86, 40);
            this.pbBread.Name = "pbBread";
            this.pbBread.Size = new System.Drawing.Size(23, 24);
            this.pbBread.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBread.TabIndex = 2;
            this.pbBread.TabStop = false;
            this.pbBread.Click += new System.EventHandler(this.OnClick);
            // 
            // lblPrice
            // 
            this.lblPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPrice.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(115, 41);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(184, 23);
            this.lblPrice.TabIndex = 3;
            this.lblPrice.Text = "100";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPrice.Click += new System.EventHandler(this.OnClick);
            // 
            // lblAmmount
            // 
            this.lblAmmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAmmount.Font = new System.Drawing.Font("Lato Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmmount.Location = new System.Drawing.Point(305, -1);
            this.lblAmmount.Name = "lblAmmount";
            this.lblAmmount.Size = new System.Drawing.Size(72, 80);
            this.lblAmmount.TabIndex = 4;
            this.lblAmmount.Text = "100";
            this.lblAmmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAmmount.Click += new System.EventHandler(this.OnClick);
            // 
            // CustomListItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lblAmmount);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.pbBread);
            this.Controls.Add(this.lblUpgradeName);
            this.Controls.Add(this.pbUpgradeImage);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CustomListItem";
            this.Size = new System.Drawing.Size(376, 78);
            this.Load += new System.EventHandler(this.CustomListItem_Load);
            this.Click += new System.EventHandler(this.OnClick);
            ((System.ComponentModel.ISupportInitialize)(this.pbUpgradeImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBread)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbUpgradeImage;
        private System.Windows.Forms.Label lblUpgradeName;
        private System.Windows.Forms.PictureBox pbBread;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblAmmount;
    }
}
