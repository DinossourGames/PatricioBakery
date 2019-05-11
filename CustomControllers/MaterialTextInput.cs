using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomControllers
{
    public partial class MaterialTextInput : UserControl
    {
        [Category("CustomProps")]
        public Color LineColor { get { return line.BackColor; } set { line.BackColor = value; } }
        [Category("CustomProps")]
        public Color HighlightedColor { get; set; }
        [Category("CustomProps")]
        public Color DefaultLineColor { get; set; }
        [Category("CustomProps")]
        public Color BackgroundColor { get => BackColor; set { BackColor = value; txtInput.BackColor = value; } }
        [Category("CustomProps")]
        public Color ForegroundColor { get => txtInput.ForeColor; set => txtInput.ForeColor = value; }

        [Category("CustomProps")]
        public Image Icon { get => icon.Image; set => icon.Image = value; }
        [Category("CustomProps")]
        public Image HighlightedIcon { get; set; }
        [Category("CustomProps")]
        public Image DefaultIcon { get; set; }


        [Category("CustomProps")]
        public Color HintColor { get => txtInput.HintColor; set => txtInput.HintColor = value; }
        [Category("CustomProps")]
        public string Hint { get => txtInput.Hint; set => txtInput.Hint = value; }
        [Category("CustomProps")]
        public Color DefaultInputColor { get => txtInput.DefaultColor; set => txtInput.DefaultColor = value; }

        [Category("CustomProps")]
        public string InputText { get => txtInput.Text; set => txtInput.Text = value.ToString(); }
        [Category("CustomProps")]
        public char PasswordCharacter { get => txtInput.PasswordChar; set => txtInput.PasswordChar = value; }

        public TextInput TextInput { get => txtInput; }
        public MaterialTextInput()
        {
            InitializeComponent();
            
        }

        private void TxtInput_Enter(object sender, EventArgs e)
        {
            LineColor = HighlightedColor;
            Icon = HighlightedIcon;
        }

        private void TxtInput_Leave(object sender, EventArgs e)
        {
            LineColor = DefaultLineColor;
            Icon = DefaultIcon;
        }


    }
}
