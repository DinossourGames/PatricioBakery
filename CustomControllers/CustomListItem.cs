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

      

#pragma warning disable CS0108 // Member hides inherited member; missing new keyword
        public event EventHandler OnClick;
#pragma warning restore CS0108 // Member hides inherited member; missing new keyword

        public Color BgColor { get => BackColor; set => BackColor = value; }
        public Color TextColor { get => lblUpgradeName.ForeColor; set { lblUpgradeName.ForeColor = value; lblAmmount.ForeColor = value; } }
        public Color PriceColor { get => lblPrice.ForeColor; set => lblPrice.ForeColor = value; }
        public string ImageURL { get => pbUpgradeImage.ImageLocation; set => pbUpgradeImage.ImageLocation = value; }
        public string IconURL { get => pbBread.ImageLocation; set => pbBread.ImageLocation = value; }
        public string UpgradeName
        {
            get =>
                 lblUpgradeName.Text;

            set =>

                lblUpgradeName.Text = value;
        }
        public string Price { get => lblPrice.Text; set => lblPrice.Text = value; }
        public string Ammount { get => lblAmmount.Text; set => lblAmmount.Text = value; }
        private Upgrade upgrade;

        public Upgrade Upgrade
        {
            get { return upgrade; }
            set
            {
                upgrade = value;
                Asdas(value);
            }
        }


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
        public CustomListItem(Upgrade upgrade)
        {
            UpgradeName = upgrade.UpgradeName;
            Price = upgrade.Price.ToString();
            Ammount = upgrade.Ammount.ToString();
            ImageURL = upgrade.ImageURL;
            IconURL = upgrade.IconURL;
            TextColor = ForeColor;
            PriceColor = Color.Red;
            BgColor = BackColor;
            InitializeComponent();
        }
        public CustomListItem()
        {
            InitializeComponent();
        }



        private void CustomListItem_Load(object sender, EventArgs e)
        {
            foreach (Control item in this.Controls)
            {
                item.Click += Item_Click;
            }
            this.Click += Item_Click;
        }

        private void Item_Click(object sender, EventArgs e)
        {
            if (this.OnClick != null)
                this.OnClick(this, e);
        }


        private void Asdas(Upgrade up)
        {
            UpgradeName = up.UpgradeName;
            Price = up.Price.ToString();
            Ammount = up.Ammount.ToString();
            ImageURL = up.ImageURL;
            IconURL = up.IconURL;
            this.Invalidate();
        }

      
    }
}
