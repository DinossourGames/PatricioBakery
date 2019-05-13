using System;
using System.Collections.Generic;
using System.Text;

namespace RiseModels
{
    public class Upgrade
    {
        public string ImageURL { get; set; }
        public string IconURL { get; set; }
        public string UpgradeName { get; set; }
        public float Price { get; set; }
        public int Ammount { get; set; }

        public Upgrade(string imageURL, string iconURL, string upgradeName, float price, int ammount)
        {
            ImageURL = imageURL;
            IconURL = iconURL;
            UpgradeName = upgradeName;
            Price = price;
            Ammount = ammount;
        }
    }
}
