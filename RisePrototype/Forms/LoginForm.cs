using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Firebase.Database;
using Firebase.Database.Query;
using RiseModels;

namespace RisePrototype
{
    public partial class LoginForm : Form
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

        public LoginForm()
        {
            m_aeroEnabled = false;

            InitializeComponent();

            int style = NativeWinAPI.GetWindowLong(this.Handle, NativeWinAPI.GWL_EXSTYLE);
            style |= NativeWinAPI.WS_EX_COMPOSITED;
            NativeWinAPI.SetWindowLong(this.Handle, NativeWinAPI.GWL_EXSTYLE, style);
        }

        private void OnLoad(object sender, EventArgs e)
        {
            btnLogin.Select();
            this.ActiveControl = pictureBox1;
            Sg.Reference = new FirebaseClient(Sg.BaseUrl);
            txtPass.TextInput.KeyPress += TxtPass_KeyPress;
            txtUser.TextInput.KeyPress += TxtUser_KeyPress;

            txtPass.TextInput.Fonte = new Font("Lato", 16, FontStyle.Regular);
            txtUser.TextInput.Fonte = new Font("Lato", 16, FontStyle.Regular);

        }

        private void TxtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                e.Handled = true;
                base.ProcessDialogKey(Keys.Tab);
                btnLogin.PerformClick();
            }
        }

        private void TxtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                e.Handled = true;
                base.ProcessDialogKey(Keys.Tab);
            }

        }

        private async void BtnLogin_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrEmpty(txtUser.InputText) || string.Equals(txtUser.InputText, txtUser.Hint)) && (string.IsNullOrEmpty(txtPass.InputText) || string.Equals(txtPass.InputText, txtPass.Hint)))
                new CustomMessageBox().Show("Por favor digite algo válido", "Usuario e/ou Senha", Sg.AccentColor);
            else if (string.IsNullOrEmpty(txtUser.InputText) || string.Equals(txtUser.InputText, txtUser.Hint))
                new CustomMessageBox().Show("Por favor digite algo válido", "Usuário Invalido", Sg.AccentColor);
            else if (string.IsNullOrEmpty(txtPass.InputText) || string.Equals(txtPass.InputText, txtPass.Hint))
                new CustomMessageBox().Show("Por favor digite algo válido", "Senha Invalida", Sg.AccentColor);
            else
            {

                var user = await Sg.GetUserAsync(txtUser.InputText);
                if (user != null)
                {
                    if (string.Equals(user.Password, txtPass.InputText))
                    {
                        user.IsOnline = true;
                        Sg.User = user;
                        //new Thread(() => { new CustomMessageBox().Show("Senha incorreta", "Erro de Login", Sg.AccentColor); }).te;
                        await Sg.UpdateUser();
                        var game = new GameScreen();
                        var result = game.ShowDialog();
                        if (result == DialogResult.Cancel)
                        {
                            if (Sg.IsValidUser)
                            {
                                Sg.User.IsOnline = false;
                                await Sg.UpdateUser();  
                            }
                            Sg.LoginForm.Close();
                        }
                    }
                    else
                        new CustomMessageBox().Show("Senha incorreta", "Erro de Login", Sg.AccentColor);
                }
                else
                    new CustomMessageBox().Show("Usuário Inexistente", "Erro de Login", Sg.AccentColor);
            }
        }

        private async void Close_Click(object sender, EventArgs e)
        {

            if (Sg.IsValidUser)
            {
                Sg.User.IsOnline = false;
                await Sg.UpdateUser();
            }
            Sg.LoginForm.Close();

        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            //used to drag the form
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private async void Label2_Click(object sender, EventArgs e)
        {
            //Sg.LoginForm.Hide();
            //Sg.LoginForm.ShowInTaskbar = true;
            var form2 = new Signup { ShowInTaskbar = false };
            var result = form2.ShowDialog();
            if (result == DialogResult.OK)
            {
                Sg.LoginForm.Show();
                form2.Close();
                try
                {
                    txtUser.InputText = Sg.User.Username;
                    txtPass.InputText = Sg.User.Password;
                    txtPass.TextInput.ForeColor = Color.Black;
                    txtUser.TextInput.ForeColor = Color.Black;
                }
                catch { }

            }
            else
            {
                if (Sg.IsValidUser)
                {
                    Sg.User.IsOnline = false;
                    await Sg.UpdateUser();
                }
                Sg.LoginForm.Close();
            }
        }

        #region Visual Effects

        private void SignUp_MouseEnter(object sender, EventArgs e)
        {
            signUp.ForeColor = Sg.LightBrown;
        }

        private void SignUp_MouseLeave(object sender, EventArgs e)
        {
            signUp.ForeColor = Sg.AccentColor;
        }

        // Close and minimize Buttons behaviour
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

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
        // Close and minimize Buttons behaviour 
        #endregion

    }
}
