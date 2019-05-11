using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Firebase.Database;
using Firebase.Database.Query;
using RiseModels;

namespace RisePrototype
{
    public partial class Form1 : Form
    {


        #region DragWindow
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        #endregion

       

        public Form1()
        {
            InitializeComponent();
        }

        private void OnLoad(object sender, EventArgs e)
        {
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
                new CustomMessageBox().Show("Por favor digite algo válido", "Usuario e/ou Senha", Sg.DarkBrown);
            else if (string.IsNullOrEmpty(txtUser.InputText) || string.Equals(txtUser.InputText, txtUser.Hint))
                new CustomMessageBox().Show("Por favor digite algo válido", "Usuário Invalido", Sg.DarkBrown);
            else if (string.IsNullOrEmpty(txtPass.InputText) || string.Equals(txtPass.InputText, txtPass.Hint))
                new CustomMessageBox().Show("Por favor digite algo válido", "Senha Invalida", Sg.DarkBrown);
            else
            {
                var user = await Sg.Reference
                                 .Child("Users")
                                 .OrderBy("Username")
                                 .StartAt(txtUser.InputText)
                                 .LimitToFirst(1)
                                 .OnceAsync<User>();

                if (user.Count > 0)
                {

                    Sg.User = user.First().Object;
                    if (Sg.User.Password == txtPass.InputText)
                    {
                        new CustomMessageBox().Show($"Logado Usuario: {Sg.User.Username}\nId: {Sg.User.Id}", "Sucesso", Sg.LightBrown);
                    }
                    else
                    {
                        new CustomMessageBox().Show("Senha incorreta", "Erro de Login", Sg.DarkBrown);
                    }
                }
                else
                {
                    new CustomMessageBox().Show("Usuário Inexistente", "Erro de Login", Sg.DarkBrown);

                }
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Close();
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

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label2_MouseEnter(object sender, EventArgs e)
        {
            label2.ForeColor = Sg.LightBrown;
        }

        private void Label2_MouseLeave(object sender, EventArgs e)
        {
            label2.ForeColor = Sg.AccentColor;
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
        // Close and minimize Buttons behaviour

    }
}
