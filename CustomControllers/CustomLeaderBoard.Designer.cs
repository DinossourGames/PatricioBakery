namespace CustomControllers
{
    partial class CustomLeaderBoard
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
            this.pbRank = new System.Windows.Forms.PictureBox();
            this.lblRank = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbRank)).BeginInit();
            this.SuspendLayout();
            // 
            // pbRank
            // 
            this.pbRank.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbRank.Image = global::CustomControllers.Properties.Resources._2_ChapeuDourado;
            this.pbRank.Location = new System.Drawing.Point(30, 5);
            this.pbRank.Name = "pbRank";
            this.pbRank.Size = new System.Drawing.Size(30, 25);
            this.pbRank.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRank.TabIndex = 0;
            this.pbRank.TabStop = false;
            // 
            // lblRank
            // 
            this.lblRank.Font = new System.Drawing.Font("Franklin Gothic Demi", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRank.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(198)))), ((int)(((byte)(197)))));
            this.lblRank.Location = new System.Drawing.Point(27, 5);
            this.lblRank.Name = "lblRank";
            this.lblRank.Size = new System.Drawing.Size(33, 25);
            this.lblRank.TabIndex = 1;
            this.lblRank.Text = "4";
            this.lblRank.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblRank.Visible = false;
            // 
            // lblUsername
            // 
            this.lblUsername.Font = new System.Drawing.Font("Franklin Gothic Demi", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(198)))), ((int)(((byte)(197)))));
            this.lblUsername.Location = new System.Drawing.Point(66, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(187, 40);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "Cabeça de Alga";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblUsername.Visible = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Demi", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(198)))), ((int)(((byte)(197)))));
            this.label1.Location = new System.Drawing.Point(259, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 40);
            this.label1.TabIndex = 3;
            this.label1.Text = "1000000";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Visible = false;
            // 
            // CustomLeaderBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblRank);
            this.Controls.Add(this.pbRank);
            this.Name = "CustomLeaderBoard";
            this.Size = new System.Drawing.Size(410, 46);
            ((System.ComponentModel.ISupportInitialize)(this.pbRank)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbRank;
        private System.Windows.Forms.Label lblRank;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label label1;
    }
}
