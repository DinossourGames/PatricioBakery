namespace CustomControllers
{
    partial class MaterialTextInput
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
            this.line = new System.Windows.Forms.Panel();
            this.icon = new System.Windows.Forms.PictureBox();
            this.txtInput = new CustomControllers.TextInput();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).BeginInit();
            this.SuspendLayout();
            // 
            // line
            // 
            this.line.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.line.Location = new System.Drawing.Point(0, 33);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(346, 3);
            this.line.TabIndex = 2;
            // 
            // icon
            // 
            this.icon.Location = new System.Drawing.Point(3, 2);
            this.icon.Name = "icon";
            this.icon.Size = new System.Drawing.Size(24, 29);
            this.icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.icon.TabIndex = 1;
            this.icon.TabStop = false;
            // 
            // txtInput
            // 
            this.txtInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInput.BackColor = System.Drawing.Color.White;
            this.txtInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInput.DefaultColor = System.Drawing.Color.Black;
            this.txtInput.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput.Fonte = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput.Hint = "Hint";
            this.txtInput.HintColor = System.Drawing.Color.Gray;
            this.txtInput.Location = new System.Drawing.Point(35, 5);
            this.txtInput.Margin = new System.Windows.Forms.Padding(6);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(311, 32);
            this.txtInput.TabIndex = 0;
            this.txtInput.Enter += new System.EventHandler(this.TxtInput_Enter);
            this.txtInput.Leave += new System.EventHandler(this.TxtInput_Leave);
            // 
            // MaterialTextInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.line);
            this.Controls.Add(this.icon);
            this.Controls.Add(this.txtInput);
            this.Name = "MaterialTextInput";
            this.Size = new System.Drawing.Size(346, 36);
            ((System.ComponentModel.ISupportInitialize)(this.icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextInput txtInput;
        private System.Windows.Forms.PictureBox icon;
        private System.Windows.Forms.Panel line;
    }
}
