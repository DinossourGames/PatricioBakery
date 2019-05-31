using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RisePrototype.Forms
{
    public partial class Pool : Form
    {
        public Pool()
        {
            InitializeComponent();
        }

        private void Pool_Load(object sender, EventArgs e)
        {
            UpdateUI();
            breads.Text = GM.Game.Breads.ToString();
        }

        private void UpdateUI()
        {
            UpdateItem(Sg.ix[0], item1, item1Name, item1Desc);
            UpdateItem(Sg.ix[1], item2, item2Name, item2Desc);
            UpdateItem(Sg.ix[2], item3, item3Name, item3Desc);
            UpdateItem(Sg.ix[3], item4, item4Name, item4Desc);
        }

        private void UpdateItem(Iten item, PictureBox pb, Label name, Label desc)
        {
            try
            {
                pb.ImageLocation = item.Item.URL;
                name.Text = item.Item.Nome;
                desc.Text = $"Preço: {item.Item.price} Breads\nDescrição: {item.Item.Description}";
            }
            catch { }
        }

        private void Item1_Click(object sender, EventArgs e)
        {
            if (GM.Game.Breads >= Sg.ix[0].Item.price)
            {
                RestHelper.Votar(0);
                GM.Game.Breads -= Sg.ix[0].Item.price;
            }
            else
                MessageBox.Show("Sem Grana Irmão");
            this.Close();
        }

        private void Item2_Click(object sender, EventArgs e)
        {
            if (GM.Game.Breads >= Sg.ix[1].Item.price)
            {
                RestHelper.Votar(1);
                GM.Game.Breads -= Sg.ix[1].Item.price;
            }
            else
                MessageBox.Show("Sem Grana Irmão");
            this.Close();

        }

        private void Item3_Click(object sender, EventArgs e)
        {
            if (GM.Game.Breads >= Sg.ix[2].Item.price)
            {
                RestHelper.Votar(2);
                GM.Game.Breads -= Sg.ix[2].Item.price;
            }
            else
                MessageBox.Show("Sem Grana Irmão");
            this.Close();
        }

        private void Item4_Click(object sender, EventArgs e)
        {
            if (GM.Game.Breads >= Sg.ix[3].Item.price)
            {
                RestHelper.Votar(3);
                GM.Game.Breads -= Sg.ix[3].Item.price;
            }
            else
                MessageBox.Show("Sem Grana Irmão");
            this.Close();

        }
    }
}
