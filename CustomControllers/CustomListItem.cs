using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RiseModels;

namespace CustomControllers
{
    public partial class CustomListItem : UserControl
    {
        private bool isSelected;

        public Color BgColor { get => BackColor; set => BackColor = value;  }
        public Color TextColor { get => lblUpgradeName.ForeColor; set { lblUpgradeName.ForeColor = value; lblAmmount.ForeColor = value; } }
        public Color PriceColor { get => lblPrice.ForeColor; set => lblPrice.ForeColor = value; } 
        public string ImageURL { get => pbUpgradeImage.ImageLocation; set => pbUpgradeImage.ImageLocation = value; }
        public string IconURL { get => pbBread.ImageLocation; set => pbBread.ImageLocation = value; }
        public string UpgradeName { get => lblUpgradeName.Text; set => lblUpgradeName.Text = value; }
        public string Price { get => lblPrice.Text; set => lblPrice.Text = value; } 
        public string Ammount { get => lblAmmount.Text; set => lblAmmount.Text = value; }
        public Upgrade Upgrade { get; private set; }

        public CustomListItem(string upgradeName, string price, string ammount, string imageURL, string iconURL, Color textColor, Color priceColor, Color bgColor)
        {
            UpgradeName = upgradeName;
            Price = price;
            Ammount = ammount;
            ImageURL = imageURL;
            IconURL = iconURL;
            TextColor = textColor;
            PriceColor = priceColor;
            BgColor = bgColor;
            InitializeComponent();
        }

        public CustomListItem()
        {
            InitializeComponent();
        }

        private void CustomListItem_Load(object sender, EventArgs e)
        {

        }

        private void OnClick(object sender, EventArgs e)
        {
            Upgrade = new Upgrade(ImageURL, IconURL, UpgradeName, float.Parse(Price), int.Parse(Ammount));
        }
    }
}
