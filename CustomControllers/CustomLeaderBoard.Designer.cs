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
            this.lbScore = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pbRank)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbRank
            // 
            this.pbRank.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbRank.Image = global::CustomControllers.Properties.Resources.ChapeuDourado;
            this.pbRank.Location = new System.Drawing.Point(23, 8);
            this.pbRank.Name = "pbRank";
            this.pbRank.Size = new System.Drawing.Size(38, 35);
            this.pbRank.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRank.TabIndex = 0;
            this.pbRank.TabStop = false;
            // 
            // lblRank
            // 
            this.lblRank.Font = new System.Drawing.Font("Franklin Gothic Demi", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRank.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(198)))), ((int)(((byte)(197)))));
            this.lblRank.Location = new System.Drawing.Point(3, 8);
            this.lblRank.Name = "lblRank";
            this.lblRank.Size = new System.Drawing.Size(57, 35);
            this.lblRank.TabIndex = 1;
            this.lblRank.Text = "4";
            this.lblRank.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblRank.Visible = false;
            // 
            // lblUsername
            // 
            this.lblUsername.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(198)))), ((int)(((byte)(197)))));
            this.lblUsername.Location = new System.Drawing.Point(67, 5);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(187, 40);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "Cabeça de Alga";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblUsername.Visible = false;
            // 
            // lbScore
            // 
            this.lbScore.Font = new System.Drawing.Font("Franklin Gothic Demi", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(198)))), ((int)(((byte)(197)))));
            this.lbScore.Location = new System.Drawing.Point(260, 5);
            this.lbScore.Name = "lbScore";
            this.lbScore.Size = new System.Drawing.Size(118, 40);
            this.lbScore.TabIndex = 3;
            this.lbScore.Text = "1000000";
            this.lbScore.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbScore.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lbScore);
            this.panel1.Controls.Add(this.pbRank);
            this.panel1.Controls.Add(this.lblRank);
            this.panel1.Controls.Add(this.lblUsername);
            this.panel1.ForeColor = System.Drawing.SystemColors.Control;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(381, 50);
            this.panel1.TabIndex = 4;
            // 
            // CustomLeaderBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Controls.Add(this.panel1);
            this.Name = "CustomLeaderBoard";
            this.Size = new System.Drawing.Size(385, 57);
            ((System.ComponentModel.ISupportInitialize)(this.pbRank)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbRank;
        private System.Windows.Forms.Label lblRank;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lbScore;
        private System.Windows.Forms.Panel panel1;
    }
}
