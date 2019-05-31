using CustomControllers;
using Firebase.Database.Query;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using ClassModels;
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
        bool first = true;
        private bool locked;

        public int Quantidade { get; set; } = 1;
        public Pool Pool { get; set; }
        public Player Player { get; private set; }

        public GameScreen()
        {
            RestHelper.GetServerIp();
            Sg.LoginForm.Hide();
            InitializeComponent();
            int style = NativeWinAPI.GetWindowLong(this.Handle, NativeWinAPI.GWL_EXSTYLE);
            style |= NativeWinAPI.WS_EX_COMPOSITED;
            NativeWinAPI.SetWindowLong(this.Handle, NativeWinAPI.GWL_EXSTYLE, style);

            button1.FlatAppearance.MouseOverBackColor = button1.BackColor;
            button1.FlatAppearance.MouseDownBackColor = button1.BackColor;
            lblOne.ForeColor = Sg.SelectedColor;

            updateUi();
            Sg.ix = new List<Iten>();

            Sg.Reference.Child("Pool").AsObservable<Pool>().Subscribe(i =>
            {
                if (i.Object != null)
                {
                    Sg.ix = i.Object.Items;
                }
                else
                {
                    Sg.ix = null;
                }
            });


            Sg.Reference.Child("Gamedata1").AsObservable<Player>().Subscribe(play =>
            {
                try
                {
                    if (play.Object != null)
                    {
                        if (play.Object.IsPlaying)
                            Player = play.Object;
                        else
                            Player = null;
                    }
                    else
                        Player = null;
                }
                catch { }

            });


        }

        private void GameScreen_Load(object sender, EventArgs e)
        {

            click_show.Text = GM.Game.ClickValue.ToString();

            foreach (var item in this.Controls.OfType<CustomListItem>())
            {
                item.OnClick += new EventHandler(Control_Click);
            }


            timer1.Interval = 1600;
            timer1.Start();

            timer2.Interval = 1000;
            timer2.Start();
        }



        private void Control_Click(object sender, EventArgs e)
        {
            var item = sender as CustomListItem;
            GM.BuyUpgrade(Quantidade, item.Upgrade);
            updateUi();

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


        private async void Timer1_TickAsync(object sender, EventArgs e)
        {

            if (Sg.ix == null)
            {
                btnLeaderboard.Visible = false;
            }
            else
            {
                btnLeaderboard.Visible = true;
            }


            if (GM.Game.Id != null)
            {
                if (GM.Game.Refresh)
                {
                    updateUi();
                    GM.Game.Refresh = false;
                    await GM.UpdateGame();

                }
                else
                {
                    if (first)
                    {
                        label1.Text = GM.Game.Breads.ToString();
                        updateUi();
                    }
                    await GM.UpdateGame();
                }
            }
        }

        private void updateUi()
        {
            int i = 0;
            label1.Text = GM.Game.Breads.ToString();
            label4.Text = GM.Game.ClicksPerSecond.ToString();
            click_show.Text = GM.Game.ClickValue.ToString();
            foreach (var item in this.Controls.OfType<CustomListItem>())
            {
                item.Upgrade = GM.UpgradesRef.First(q => q.ID == GM.Game.Upgrades[i].UpgradeID);
                item.Upgrade.Ammount = GM.Game.Upgrades[i].Ammount;

                item.Price = Quantidade == 1 ? ((Math.Ceiling(GM.UpgradesRef.First(b => GM.Game.Upgrades[i].UpgradeID == b.ID).Price * Math.Pow(item.Upgrade.PriceMultiplier, GM.Game.Upgrades[i].Ammount))) * Quantidade).ToString() :
                    (Math.Floor(GM.UpgradesRef.First(b => GM.Game.Upgrades[i].UpgradeID == b.ID).Price * Math.Pow((1 + GM.UpgradesRef.First(b => GM.Game.Upgrades[i].UpgradeID == b.ID).PriceMultiplier), Quantidade))).ToString();
                if (double.Parse(item.Price) > GM.Game.Breads)
                    item.PriceColor = Color.Red;
                else
                    item.PriceColor = Color.Green;
                i++;
            }
        }

        private void LblOne_Click(object sender, EventArgs e)
        {
            Quantidade = 1;
            lblThree.ForeColor = Color.Black;
            lblOne.ForeColor = Sg.SelectedColor;
            lblTwo.ForeColor = Color.Black;
            updateUi();
        }

        private void LblTwo_Click(object sender, EventArgs e)
        {
            Quantidade = 10;
            lblThree.ForeColor = Color.Black;
            lblOne.ForeColor = Color.Black;
            lblTwo.ForeColor = Sg.SelectedColor;
            updateUi();

        }

        private void LblThree_Click(object sender, EventArgs e)
        {
            Quantidade = 100;
            lblThree.ForeColor = Sg.SelectedColor;
            lblOne.ForeColor = Color.Black;
            lblTwo.ForeColor = Color.Black;
            updateUi();

        }

        private void BuyEnter(object sender, EventArgs e)
        {
            var a = sender as Label;
            a.ForeColor = Sg.HoverColor;
        }

        private void BuyOut(object sender, EventArgs e)
        {
            var a = sender as Label;
            if (a.Text == Quantidade.ToString())
                a.ForeColor = Sg.SelectedColor;
            else
                a.ForeColor = Color.Black;


        }

        private void Click_Start(object sender, MouseEventArgs e)
        {
            button1.BackgroundImage = Properties.Resources.bread_clicked;

        }

        private void Click_Exit(object sender, MouseEventArgs e)
        {
            if (!locked)
            {

                click_show.Text = GM.Game.ClickValue.ToString();
                GM.ComputeClick();
                label1.Text = GM.Game.Breads.ToString();
            }

            button1.BackgroundImage = Properties.Resources.bread_normal;
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            if (Player != null)
            {
                if (Player.ItemAtual != null)
                {
                    if (Player.ItemAtual.Id == "-LgCnr4YC1pVnwgIYXEs")
                    {
                        locked = true;
                    }
                    else
                    {
                        locked = false;
                    }


                }
                else
                {
                    locked = false;
                }
            }
            else
            {
                locked = false;
            }

            if (!locked)
            {
                GM.ComputeClick(GM.Game.ClicksPerSecond);
            }
        }

        private void btnLeaderboard_Click(object sender, EventArgs e)
        {
            new Forms.Pool().Show();
        }

        private void CustomListItem1_Load(object sender, EventArgs e)
        {

        }
    }


    public class Pool
    {
        public List<Iten> Items { get; set; }
        public string Id { get; set; }
    }

    public class Iten
    {
        public Item Item { get; set; }
        public int Votes { get; set; }
    }


}
