using Firebase.Database.Query;
using RiseModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RisePrototype
{
    public partial class Signup : Form
    {

        #region DragWindow
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        private void Signup_MouseDown(object sender, MouseEventArgs e)
        {
            //used to drag the form
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        #endregion

        public Signup()
        {
            InitializeComponent();
        }
        private void Signup_Load(object sender, EventArgs e)
        {
            txtPass.TextInput.KeyPress += TxtPass_KeyPress;
            txtConfirmPass.TextInput.KeyPress += TxtConfirmPass_KeyPress;
            txtUser.TextInput.KeyPress += TxtUser_KeyPress;
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

        private void Label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            DialogResult = DialogResult.OK;
        }


        private async void BtnLogin_Click(object sender, EventArgs e)
        {
            var username = txtUser.InputText;
            var password = txtPass.InputText;
            var confirmPass = txtConfirmPass.InputText;

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
            else // se não der nenhum erro ele cai aqui
            {

                var checker = await Sg.Reference
                                .Child("Users")
                                .OrderBy("Username")
                                .StartAt(username)
                                .LimitToFirst(1)
                                .OnceAsync<User>();

                if (checker.Count > 0)
                    new CustomMessageBox().Show("Já exste um usuário cadastrado com esse username no banco.", "User já cadastrado", Sg.AccentColor);
                else
                {

                    var id = await Sg.Reference.Child("Users").PostAsync(new User());
                    var user = new User { Id = id.Key, Username = username, Password = password };
                    Sg.User = user;
                    var result = Sg.Reference.Child("Users").Child(user.Id).PutAsync(user);
                    if (result.Exception == null)
                    {
                        new CustomMessageBox().Show("Usuário cadastrado com sucesso", "Sucesso", Sg.AccentColor);
                        this.Hide();
                        DialogResult = DialogResult.OK;
                    }

                }
            }
        }


    }
}
