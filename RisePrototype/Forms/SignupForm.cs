using Firebase.Database.Query;
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
    public partial class Signup : Form
    {
        string texto = "We're looking for new employees. So, if you're interested in working, and receive absolutely nothing in return, this is the right place for you!";

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

        public bool Locker { get; private set; }

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

        public Signup()
        {
            m_aeroEnabled = false;
            InitializeComponent();
            int style = NativeWinAPI.GetWindowLong(this.Handle, NativeWinAPI.GWL_EXSTYLE);
            style |= NativeWinAPI.WS_EX_COMPOSITED;
            NativeWinAPI.SetWindowLong(this.Handle, NativeWinAPI.GWL_EXSTYLE, style);
        }
        private void Signup_Load(object sender, EventArgs e)
        {
            label4.Text = Justifier.JustifyParagraph(texto,new Font("Lato Hairline",12f), label4.ClientSize.Width);
            btnLogin.Select();
            this.ActiveControl = pictureBox1;
            txtPass.TextInput.KeyPress += TxtPass_KeyPress;
            txtConfirmPass.TextInput.KeyPress += TxtConfirmPass_KeyPress;
            txtUser.TextInput.KeyPress += TxtUser_KeyPress;
        }
        private void Signup_MouseDown(object sender, MouseEventArgs e)
        {
            //used to drag the form
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

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

        #region ReturnKeyPress Inputs
        private void TxtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                e.Handled = true;
                base.ProcessDialogKey(Keys.Tab);
            }

        }

        private void TxtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                e.Handled = true;
                base.ProcessDialogKey(Keys.Tab);
            }

        }

        private void TxtConfirmPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                e.Handled = true;
                base.ProcessDialogKey(Keys.Tab);
                btnLogin.PerformClick();
            }
        } 
        #endregion

        private void Label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            DialogResult = DialogResult.OK;
        }


        private async void BtnLogin_Click(object sender, EventArgs e)
        {

            if (!Locker)
            {
                Locker = true;
                var username = txtUser.InputText;
                var password = txtPass.InputText;
                var confirmPass = txtConfirmPass.InputText;
                //validation checkup -- could use regex I know..
                if ((username.Contains("\"") || username.Contains("\'") || username.Contains("\\")) || (username.Count() > 16 || username.Count() < 4) || (password.Contains("\"") || password.Contains("\'") || password.Contains("\\")) || (password.Count() > 24 || password.Count() < 4) || (!string.Equals(password, confirmPass)) || (string.IsNullOrEmpty(txtUser.InputText) || (string.Equals(txtUser.InputText, txtUser.Hint)) && (string.IsNullOrEmpty(txtPass.InputText) || string.Equals(txtPass.InputText, txtPass.Hint))))
                {
                    if (username.Contains("\"") || username.Contains("\'") || username.Contains("\\"))
                        new CustomMessageBox().Show("Os caracteres [ \" , \\ ,  \' ] não são permitidos, por favor tente outro username.", "Username Invalido", Sg.AccentColor);
                    else if (username.Count() > 16 || username.Count() < 4)
                        new CustomMessageBox().Show("O username deve conter entre 4 e 16 caracteres", "Username Invalido", Sg.AccentColor);
                    else if (password.Contains("\"") || password.Contains("\'") || password.Contains("\\"))
                        new CustomMessageBox().Show("Os caracteres [ \" , \\ ,  \' ] não são permitidos, por favor tente outra senha.", "Senha Invalida", Sg.AccentColor);
                    else if (password.Count() > 24 || password.Count() < 4)
                        new CustomMessageBox().Show("A senha deve conter entre 4 e 24 caracteres", "Senha Invalida", Sg.AccentColor);
                    else if (!string.Equals(password, confirmPass))
                        new CustomMessageBox().Show("As duas senhas devem coincidir", "Senha Invalida", Sg.AccentColor);
                    else if ((string.IsNullOrEmpty(txtUser.InputText) || string.Equals(txtUser.InputText, txtUser.Hint)) && (string.IsNullOrEmpty(txtPass.InputText) || string.Equals(txtPass.InputText, txtPass.Hint)))
                        new CustomMessageBox().Show("Por favor digite algo válido", "Usuario e/ou Senha", Sg.AccentColor);
                }
                else // if hasn't throw any error.
                {

                    var alreadyHas = await Sg.HasUserAsync(username);

                    if (alreadyHas)
                    {
                        new CustomMessageBox().Show("Já exste um usuário cadastrado com esse username no banco.", "User já cadastrado", Sg.AccentColor);
                        Locker = false;
                    }
                    else
                    {
                        var user = new User { Username = username, Password = password };
                        var result = await Sg.CreateUserAsync(user);
                        if (result)
                        {
                            Locker = false;
                            new CustomMessageBox().Show("Usuário cadastrado com sucesso", "Sucesso", Sg.AccentColor);
                            this.Hide();
                            DialogResult = DialogResult.OK;
                        }

                    }
                }
            }
            
        }

        private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);

            }
        }
    }
}
