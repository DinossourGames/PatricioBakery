namespace RisePrototype
{
    partial class GameScreen
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblOne = new System.Windows.Forms.Label();
            this.lblTwo = new System.Windows.Forms.Label();
            this.lblThree = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.minimize = new System.Windows.Forms.PictureBox();
            this.close = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.customListItem4 = new CustomControllers.CustomListItem();
            this.customListItem3 = new CustomControllers.CustomListItem();
            this.customListItem2 = new CustomControllers.CustomListItem();
            this.customListItem1 = new CustomControllers.CustomListItem();
            ((System.ComponentModel.ISupportInitialize)(this.minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 38F);
            this.label1.Location = new System.Drawing.Point(102, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 59);
            this.label1.TabIndex = 9;
            this.label1.Text = "10";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Demi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 24);
            this.label2.TabIndex = 12;
            this.label2.Text = "Comprar: ";
            // 
            // lblOne
            // 
            this.lblOne.AutoSize = true;
            this.lblOne.Font = new System.Drawing.Font("Franklin Gothic Demi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOne.Location = new System.Drawing.Point(172, 283);
            this.lblOne.Name = "lblOne";
            this.lblOne.Size = new System.Drawing.Size(21, 24);
            this.lblOne.TabIndex = 13;
            this.lblOne.Text = "1";
            this.lblOne.Click += new System.EventHandler(this.LblOne_Click);
            this.lblOne.MouseEnter += new System.EventHandler(this.BuyEnter);
            this.lblOne.MouseLeave += new System.EventHandler(this.BuyOut);
            // 
            // lblTwo
            // 
            this.lblTwo.AutoSize = true;
            this.lblTwo.Font = new System.Drawing.Font("Franklin Gothic Demi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTwo.Location = new System.Drawing.Point(240, 283);
            this.lblTwo.Name = "lblTwo";
            this.lblTwo.Size = new System.Drawing.Size(32, 24);
            this.lblTwo.TabIndex = 14;
            this.lblTwo.Text = "10";
            this.lblTwo.Click += new System.EventHandler(this.LblTwo_Click);
            this.lblTwo.MouseEnter += new System.EventHandler(this.BuyEnter);
            this.lblTwo.MouseLeave += new System.EventHandler(this.BuyOut);
            // 
            // lblThree
            // 
            this.lblThree.AutoSize = true;
            this.lblThree.Font = new System.Drawing.Font("Franklin Gothic Demi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThree.Location = new System.Drawing.Point(311, 283);
            this.lblThree.Name = "lblThree";
            this.lblThree.Size = new System.Drawing.Size(43, 24);
            this.lblThree.TabIndex = 15;
            this.lblThree.Text = "100";
            this.lblThree.Click += new System.EventHandler(this.LblThree_Click);
            this.lblThree.MouseEnter += new System.EventHandler(this.BuyEnter);
            this.lblThree.MouseLeave += new System.EventHandler(this.BuyOut);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(156, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "per second: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(222, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 15);
            this.label4.TabIndex = 17;
            this.label4.Text = "20";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.BackgroundImage = global::RisePrototype.Properties.Resources.bread_normal;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.CausesValidation = false;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(132, 110);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 122);
            this.button1.TabIndex = 0;
            this.button1.TabStop = false;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Click_Start);
            this.button1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Click_Exit);
            // 
            // minimize
            // 
            this.minimize.Image = global::RisePrototype.Properties.Resources.minimize;
            this.minimize.Location = new System.Drawing.Point(341, -4);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(36, 31);
            this.minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minimize.TabIndex = 8;
            this.minimize.TabStop = false;
            this.minimize.Click += new System.EventHandler(this.Minimize_Click);
            this.minimize.MouseEnter += new System.EventHandler(this.Minimize_MouseEnter);
            this.minimize.MouseLeave += new System.EventHandler(this.Minimize_MouseLeave);
            // 
            // close
            // 
            this.close.Image = global::RisePrototype.Properties.Resources.close;
            this.close.Location = new System.Drawing.Point(375, -4);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(36, 31);
            this.close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.close.TabIndex = 7;
            this.close.TabStop = false;
            this.close.Click += new System.EventHandler(this.Close_Click);
            this.close.MouseEnter += new System.EventHandler(this.Close_MouseEnter);
            this.close.MouseLeave += new System.EventHandler(this.Close_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RisePrototype.Properties.Resources.PatricioBakery;
            this.pictureBox1.Location = new System.Drawing.Point(13, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(198)))));
            this.panel1.Location = new System.Drawing.Point(19, 318);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(377, 82);
            this.panel1.TabIndex = 23;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(198)))));
            this.panel2.Location = new System.Drawing.Point(19, 406);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(377, 82);
            this.panel2.TabIndex = 24;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(198)))));
            this.panel3.Location = new System.Drawing.Point(19, 495);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(377, 82);
            this.panel3.TabIndex = 25;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(198)))));
            this.panel4.Location = new System.Drawing.Point(19, 588);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(377, 82);
            this.panel4.TabIndex = 26;
            // 
            // customListItem4
            // 
            this.customListItem4.Ammount = "100";
            this.customListItem4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.customListItem4.BackColor = System.Drawing.Color.White;
            this.customListItem4.BgColor = System.Drawing.Color.White;
            this.customListItem4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.customListItem4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(198)))));
            this.customListItem4.IconURL = null;
            this.customListItem4.ImageURL = null;
            this.customListItem4.Location = new System.Drawing.Point(15, 586);
            this.customListItem4.Margin = new System.Windows.Forms.Padding(4);
            this.customListItem4.Name = "customListItem4";
            this.customListItem4.Price = "100";
            this.customListItem4.PriceColor = System.Drawing.Color.Black;
            this.customListItem4.Size = new System.Drawing.Size(376, 78);
            this.customListItem4.TabIndex = 21;
            this.customListItem4.TextColor = System.Drawing.Color.Black;
            this.customListItem4.Upgrade = null;
            this.customListItem4.UpgradeName = "Upgrade Name";
            // 
            // customListItem3
            // 
            this.customListItem3.Ammount = "100";
            this.customListItem3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.customListItem3.BackColor = System.Drawing.Color.White;
            this.customListItem3.BgColor = System.Drawing.Color.White;
            this.customListItem3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.customListItem3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(198)))));
            this.customListItem3.IconURL = null;
            this.customListItem3.ImageURL = null;
            this.customListItem3.Location = new System.Drawing.Point(15, 493);
            this.customListItem3.Margin = new System.Windows.Forms.Padding(4);
            this.customListItem3.Name = "customListItem3";
            this.customListItem3.Price = "100";
            this.customListItem3.PriceColor = System.Drawing.Color.Black;
            this.customListItem3.Size = new System.Drawing.Size(376, 78);
            this.customListItem3.TabIndex = 20;
            this.customListItem3.TextColor = System.Drawing.Color.Black;
            this.customListItem3.Upgrade = null;
            this.customListItem3.UpgradeName = "Upgrade Name";
            // 
            // customListItem2
            // 
            this.customListItem2.Ammount = "100";
            this.customListItem2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.customListItem2.BackColor = System.Drawing.Color.White;
            this.customListItem2.BgColor = System.Drawing.Color.White;
            this.customListItem2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.customListItem2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(198)))));
            this.customListItem2.IconURL = null;
            this.customListItem2.ImageURL = null;
            this.customListItem2.Location = new System.Drawing.Point(15, 404);
            this.customListItem2.Margin = new System.Windows.Forms.Padding(4);
            this.customListItem2.Name = "customListItem2";
            this.customListItem2.Price = "100";
            this.customListItem2.PriceColor = System.Drawing.Color.Black;
            this.customListItem2.Size = new System.Drawing.Size(376, 78);
            this.customListItem2.TabIndex = 19;
            this.customListItem2.TextColor = System.Drawing.Color.Black;
            this.customListItem2.Upgrade = null;
            this.customListItem2.UpgradeName = "Upgrade Name";
            // 
            // customListItem1
            // 
            this.customListItem1.Ammount = "100";
            this.customListItem1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.customListItem1.BackColor = System.Drawing.Color.White;
            this.customListItem1.BgColor = System.Drawing.Color.White;
            this.customListItem1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.customListItem1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(198)))));
            this.customListItem1.IconURL = null;
            this.customListItem1.ImageURL = null;
            this.customListItem1.Location = new System.Drawing.Point(15, 316);
            this.customListItem1.Margin = new System.Windows.Forms.Padding(4);
            this.customListItem1.Name = "customListItem1";
            this.customListItem1.Price = "100";
            this.customListItem1.PriceColor = System.Drawing.Color.Black;
            this.customListItem1.Size = new System.Drawing.Size(376, 78);
            this.customListItem1.TabIndex = 18;
            this.customListItem1.TextColor = System.Drawing.Color.Black;
            this.customListItem1.Upgrade = null;
            this.customListItem1.UpgradeName = "Upgrade Name";
            // 
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(410, 674);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.customListItem4);
            this.Controls.Add(this.customListItem3);
            this.Controls.Add(this.customListItem2);
            this.Controls.Add(this.customListItem1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblThree);
            this.Controls.Add(this.lblTwo);
            this.Controls.Add(this.lblOne);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.minimize);
            this.Controls.Add(this.close);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GameScreen";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameScreen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GameScreen_FormClosing);
            this.Load += new System.EventHandler(this.GameScreen_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GameScreen_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox minimize;
        private System.Windows.Forms.PictureBox close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblOne;
        private System.Windows.Forms.Label lblTwo;
        private System.Windows.Forms.Label lblThree;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private CustomControllers.CustomListItem customListItem4;
        private CustomControllers.CustomListItem customListItem3;
        private CustomControllers.CustomListItem customListItem2;
        private CustomControllers.CustomListItem customListItem1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}