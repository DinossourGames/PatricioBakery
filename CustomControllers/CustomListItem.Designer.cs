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
            this.lblUpgradeName = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblAmmount = new System.Windows.Forms.Label();
            this.pbBread = new System.Windows.Forms.PictureBox();
            this.pbUpgradeImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbBread)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUpgradeImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUpgradeName
            // 
            this.lblUpgradeName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUpgradeName.BackColor = System.Drawing.Color.Transparent;
            this.lblUpgradeName.Font = new System.Drawing.Font("Franklin Gothic Demi", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpgradeName.Location = new System.Drawing.Point(71, 13);
            this.lblUpgradeName.Name = "lblUpgradeName";
            this.lblUpgradeName.Size = new System.Drawing.Size(188, 24);
            this.lblUpgradeName.TabIndex = 1;
            this.lblUpgradeName.Text = "Upgrade Name";
            // 
            // lblPrice
            // 
            this.lblPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblPrice.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(105, 41);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(154, 23);
            this.lblPrice.TabIndex = 3;
            this.lblPrice.Text = "100";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAmmount
            // 
            this.lblAmmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAmmount.BackColor = System.Drawing.Color.Transparent;
            this.lblAmmount.Font = new System.Drawing.Font("Franklin Gothic Heavy", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(198)))));
            this.lblAmmount.Location = new System.Drawing.Point(265, 0);
            this.lblAmmount.Name = "lblAmmount";
            this.lblAmmount.Size = new System.Drawing.Size(110, 80);
            this.lblAmmount.TabIndex = 4;
            this.lblAmmount.Text = "100";
            this.lblAmmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pbBread
            // 
            this.pbBread.BackColor = System.Drawing.Color.Transparent;
            this.pbBread.Location = new System.Drawing.Point(79, 40);
            this.pbBread.Name = "pbBread";
            this.pbBread.Size = new System.Drawing.Size(23, 24);
            this.pbBread.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBread.TabIndex = 2;
            this.pbBread.TabStop = false;
            // 
            // pbUpgradeImage
            // 
            this.pbUpgradeImage.BackColor = System.Drawing.Color.Transparent;
            this.pbUpgradeImage.Location = new System.Drawing.Point(13, 13);
            this.pbUpgradeImage.Name = "pbUpgradeImage";
            this.pbUpgradeImage.Size = new System.Drawing.Size(52, 51);
            this.pbUpgradeImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbUpgradeImage.TabIndex = 0;
            this.pbUpgradeImage.TabStop = false;
            // 
            // CustomListItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblAmmount);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.pbBread);
            this.Controls.Add(this.lblUpgradeName);
            this.Controls.Add(this.pbUpgradeImage);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CustomListItem";
            this.Size = new System.Drawing.Size(378, 80);
            this.Load += new System.EventHandler(this.CustomListItem_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.CustomListItem_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pbBread)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUpgradeImage)).EndInit();
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
