namespace CustomControllers
{
    partial class GradientButton
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
            this.SuspendLayout();
            // 
            // GradientButton
            // 
            this.Size = new System.Drawing.Size(269, 79);
            this.Click += new System.EventHandler(this.GradientButton_Click);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.GradientButton_Paint);
            this.Enter += new System.EventHandler(this.GradientButton_Enter);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.GradientButton_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GradientButton_KeyUp);
            this.Leave += new System.EventHandler(this.GradientButton_Leave);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GradientButton_MouseDown);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.GradientButton_MouseUp);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
