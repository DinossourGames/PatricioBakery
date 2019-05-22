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
    public partial class CustomLeaderBoard : UserControl
    {
        [Category("CustomProps")]
        public string Username { get => lblUsername.Text; set { lblUsername.Text = value; UpdateText(lblUsername, value); } }
        [Category("CustomProps")]

        public Color TetColor { get => lblUsername.ForeColor; set { lblUsername.ForeColor = value; lbScore.ForeColor = value; } }
        [Category("CustomProps")]
        public string Position { get => lblRank.Text; set { lblRank.Text = value; DefineRank(value); } }
        [Category("CustomProps")]
        public string Score { get => lbScore.Text; set { lbScore.Text = value; UpdateText(lbScore, value); } }

        public CustomLeaderBoard()
        {
            InitializeComponent();
            lbScore.Visible = true;
            lblUsername.Visible = true;

        }
        private void UpdateText(Label label, string val)
        {
            label.Text = val;
        }

        private void DefineRank(string Valor)
        {

            if (int.TryParse(Valor, out int rank))
            {
                pbRank.Visible = true;
                lblRank.Visible = false;
                switch (rank)
                {
                    case 1:
                        pbRank.Image = Properties.Resources.ChapeuDourado;
                        break;
                    case 2:
                        pbRank.Image = Properties.Resources.ChapeuCinza;
                        break;
                    case 3:
                        pbRank.Image = Properties.Resources.ChapeuMarrom;
                        break;
                    default:
                        pbRank.Visible = false;
                        lblRank.Visible = true;
                        break;
                }
            }
        }

    }
}
