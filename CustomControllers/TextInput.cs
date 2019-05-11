using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace CustomControllers
{
    public partial class TextInput : TextBox
    {
        public Color HintColor { get; set; } 
        public string Hint { get; set; }
        public Color DefaultColor { get; set; }
        public Font Fonte { get => Font; set => Font = value; }

        public TextInput()
        {

            Font = new Font("Roboto", 16);
            Margin = new Padding(6);
            // get default color of text

            if (!string.IsNullOrEmpty(Hint))
            {
                this.Text = Hint;
                this.ForeColor = HintColor;
            }
            else
            {
                this.Hint = "Hint";
                this.ForeColor = HintColor;
            }

            

            // Add event handler for when the control gets focus

            this.GotFocus += (object sender, EventArgs e) =>
            {
                if (string.Equals(this.Text, Hint))
                {
                    this.Text = String.Empty;
                    this.ForeColor = DefaultColor;
                }
            };

            // add event handling when focus is lost
            this.LostFocus += (Object sender, EventArgs e) =>
            {
                if (String.IsNullOrEmpty(this.Text) || string.Equals(this.Text, Hint))
                {
                    this.ForeColor = HintColor;
                    this.Text = Hint;
                }
                else
                {
                    this.ForeColor = DefaultColor;
                }
            };

        }


    }
}
