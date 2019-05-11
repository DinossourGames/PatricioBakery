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
    public partial class CustomMessageBox : Form
    {
        public CustomMessageBox()
        {
            InitializeComponent();
        }
        public DialogResult Show(string text,string title)
        {
            if (string.IsNullOrEmpty(title))
                title = "Message Box";

            this.text.Text = text;
            this.title.Text = title;
            return this.ShowDialog();
        }
        public DialogResult Show(string text, string title, Color bgColor)
        {
            if (string.IsNullOrEmpty(title))
                title = "Message Box";
            this.BackColor = bgColor;
            this.text.Text = text;
            this.title.Text = title;
            return this.ShowDialog();
        }
        public DialogResult Show(string text, string title, Color bgColor,Color foregroundColor)
        {
            if (string.IsNullOrEmpty(title))
                title = "Message Box";
            ForeColor = foregroundColor;
            this.BackColor = bgColor;
            this.text.Text = text;
            this.title.Text = title;
            return this.ShowDialog();
        }
    }
}
