using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
namespace CustomControllers
{
    public partial class GradientButton : Button
    {
        private int wh = 20;
        private Color cl0 = Color.Blue, cl1 = Color.Lime;
        private float angle;
        private string txt = "Custom Button";


        public string ButtonText
        {
            get { return txt; }
            set { txt = value; }
        }

        public float GradientAngle
        {
            get { return angle; }
            set { angle = value; Invalidate(); }
        }

        public int BorderRadius
        {
            get { return wh; }
            set { wh = value; Invalidate(); }
        }
        public Color Color0
        {
            get { return cl0; }
            set { cl0 = value; Invalidate(); }
        }
        public Color Color1
        {
            get { return cl1; }
            set { cl1 = value; Invalidate(); }
        }

        private void GradientButton_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
            var gp = new GraphicsPath();

            gp.AddArc(new Rectangle(0, 0, wh, wh), 180, 90);
            gp.AddArc(new Rectangle(Width - wh, 0, wh, wh), -90, 90);
            gp.AddArc(new Rectangle(Width - wh, Height - wh, wh, wh), 0, 90);
            gp.AddArc(new Rectangle(0, Height - wh, wh, wh), 90, 90);

            e.Graphics.FillPath(new LinearGradientBrush(ClientRectangle, cl0, cl1, angle), gp);
            e.Graphics.DrawString(txt, Font, new SolidBrush(ForeColor), ClientRectangle, new StringFormat() { LineAlignment = StringAlignment.Center, Alignment = StringAlignment.Center });

        }

        private void GradientButton_Enter(object sender, EventArgs e)
        {
            Color0 = Color.FromArgb(182, 67, 63);
            Color1 = Color.FromArgb(182, 67, 63);
        }

        private void GradientButton_Leave(object sender, EventArgs e)
        {
            Color0 = Color.FromArgb(208, 93, 70);
            Color1 = Color.FromArgb(153, 65, 48);
        }

        private void GradientButton_Click(object sender, EventArgs e)
        {
            Color0 = Color.FromArgb(88, 47, 34);
            Color1 = Color.FromArgb(88, 47, 34);
        }

        private void GradientButton_MouseUp(object sender, MouseEventArgs e)
        {
            Color0 = Color.FromArgb(208, 93, 70);
            Color1 = Color.FromArgb(153, 65, 48);
        }

        private void GradientButton_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                Color0 = Color.FromArgb(208, 93, 70);
                Color1 = Color.FromArgb(153, 65, 48);
            }
        }

        private void GradientButton_KeyPress(object sender, KeyPressEventArgs e)
        {
            Color0 = Color.FromArgb(88, 47, 34);
            Color1 = Color.FromArgb(88, 47, 34);
        }

        private void GradientButton_MouseDown(object sender, MouseEventArgs e)
        {
            Color0 = Color.FromArgb(88, 47, 34);
            Color1 = Color.FromArgb(88, 47, 34);
        }

        public GradientButton()
        {
            InitializeComponent();
            DoubleBuffered = true;

        }

    }
}
