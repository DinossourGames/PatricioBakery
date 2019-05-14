using CustomControllers;
using RiseModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RisePrototype
{
    public partial class GameScreen : Form
    {
        #region Window Drag And Shadows

        internal static class NativeWinAPI
        {
            internal static readonly int GWL_EXSTYLE = -20;
            internal static readonly int WS_EX_COMPOSITED = 0x02000000;

            [DllImport("user32")]
            internal static extern int GetWindowLong(IntPtr hWnd, int nIndex);

            [DllImport("user32")]
            internal static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);
        }




        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
           (
               int nLeftRect, // x-coordinate of upper-left corner
               int nTopRect, // y-coordinate of upper-left corner
               int nRightRect, // x-coordinate of lower-right corner
               int nBottomRect, // y-coordinate of lower-right corner
               int nWidthEllipse, // height of ellipse
               int nHeightEllipse // width of ellipse
            );

        [DllImport("dwmapi.dll")]
        public static extern int DwmExtendFrameIntoClientArea(IntPtr hWnd, ref MARGINS pMarInset);

        [DllImport("dwmapi.dll")]
        public static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);

        [DllImport("dwmapi.dll")]
        public static extern int DwmIsCompositionEnabled(ref int pfEnabled);

        private bool m_aeroEnabled;                     // variables for box shadow
        private const int CS_DROPSHADOW = 0x00020000;
        private const int WM_NCPAINT = 0x0085;
        private const int WM_ACTIVATEAPP = 0x001C;

        public struct MARGINS                           // struct for box shadow
        {
            public int leftWidth;
            public int rightWidth;
            public int topHeight;
            public int bottomHeight;
        }
        //private const int WM_NCHITTEST = 0x84;          // variables for dragging the form
        //private const int HTCLIENT = 0x1;
        //private const int HTCAPTION = 0x2;

        protected override CreateParams CreateParams
        {
            get
            {
                m_aeroEnabled = CheckAeroEnabled();

                CreateParams cp = base.CreateParams;
                if (!m_aeroEnabled)
                    cp.ClassStyle |= CS_DROPSHADOW;

                return cp;
            }
        }
        private bool CheckAeroEnabled()
        {
            if (Environment.OSVersion.Version.Major >= 6)
            {
                int enabled = 0;
                DwmIsCompositionEnabled(ref enabled);
                return (enabled == 1) ? true : false;
            }
            return false;
        }

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCPAINT:                        // box shadow
                    if (m_aeroEnabled)
                    {
                        var v = 2;
                        DwmSetWindowAttribute(this.Handle, 2, ref v, 4);
                        MARGINS margins = new MARGINS()
                        {
                            bottomHeight = 1,
                            leftWidth = 1,
                            rightWidth = 1,
                            topHeight = 1
                        };
                        DwmExtendFrameIntoClientArea(this.Handle, ref margins);

                    }
                    break;
                default:
                    break;
            }
            base.WndProc(ref m);

            //if (m.Msg == WM_NCHITTEST && (int)m.Result == HTCLIENT)     // drag the form
            //    m.Result = (IntPtr)HTCAPTION;

        }

        #endregion

        #region ActionButtons
        private void Close_Click(object sender, EventArgs e)
        {
            this.Hide();
            DialogResult = DialogResult.Cancel;
        }
        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Close_MouseEnter(object sender, EventArgs e)
        {
            close.Image = Sg.CloseButtonHighlighted;
        }

        private void Close_MouseLeave(object sender, EventArgs e)
        {
            close.Image = Sg.CloseButtonDefault;
        }

        private void Minimize_MouseEnter(object sender, EventArgs e)
        {
            minimize.Image = Sg.MinimizeButtonHighlighted;
        }

        private void Minimize_MouseLeave(object sender, EventArgs e)
        {
            minimize.Image = Sg.MinimizeButtonDefault;
        }
        #endregion

        public int Quantidade { get; set; } = 1;
        List<Upgrade> upgrades;
        public GameScreen()
        {
            Sg.LoginForm.Hide();
            InitializeComponent();
            int style = NativeWinAPI.GetWindowLong(this.Handle, NativeWinAPI.GWL_EXSTYLE);
            style |= NativeWinAPI.WS_EX_COMPOSITED;
            NativeWinAPI.SetWindowLong(this.Handle, NativeWinAPI.GWL_EXSTYLE, style);
        }

        private void GameScreen_Load(object sender, EventArgs e)
        {
            Sg.Initiate();
            GM.Initiate();
            upgrades = GM.PrepareDumbData();

            int i = 0;

            foreach (var item in this.Controls.OfType<CustomListItem>())
            {
                item.OnClick += new EventHandler(Control_Click);
                item.Upgrade = upgrades[i];
                i++;
            }

            timer1.Interval = 60;
            timer1.Start();
        }



        private void Control_Click(object sender, EventArgs e)
        {
            var item = sender as CustomListItem;
            var upgrade = GM.BuyUpgrade(Quantidade,item.Upgrade);
            item.Upgrade = upgrade;
            MessageBox.Show(item.Upgrade.Ammount.ToString());

        }

        private void GameScreen_MouseDown(object sender, MouseEventArgs e)
        {
            //used to drag the form
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        private void GameScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }


        private void Timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = GM.Game.Breads.ToString();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            GM.ComputeClick();
        }

        private void LblOne_Click(object sender, EventArgs e)
        {
            Quantidade = 1;
            lblThree.ForeColor = Color.Black;
            lblOne.ForeColor = Sg.AccentColor;
            lblTwo.ForeColor = Color.Black;

        }

        private void LblTwo_Click(object sender, EventArgs e)
        {
            Quantidade = 10;
            lblThree.ForeColor = Color.Black;
            lblOne.ForeColor = Color.Black;
            lblTwo.ForeColor = Sg.AccentColor;

        }

        private void LblThree_Click(object sender, EventArgs e)
        {
            Quantidade = 100;
            lblThree.ForeColor = Sg.AccentColor;
            lblOne.ForeColor = Color.Black;
            lblTwo.ForeColor = Color.Black;

        }
    }
}
