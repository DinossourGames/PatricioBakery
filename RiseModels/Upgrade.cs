namespace RiseModels
{
    public class Upgrade
    {
        public string ID { get; set; }
        public string ImageURL { get; set; }
        public string IconURL { get; set; }
        public string UpgradeName { get; set; }
        public double Price { get; set; }
        public int Ammount { get; set; }
        public double ClicksPerSecond { get; set; }
        public double PriceMultiplier { get; set; }

        public Upgrade(string iD, string imageURL, string iconURL, string upgradeName, double price, int ammount, double clicksPerSecond, double priceMultiplier)
        {
            ID = iD;
            ImageURL = imageURL;
            IconURL = iconURL;
            UpgradeName = upgradeName;
            Price = price;
            Ammount = ammount;
            ClicksPerSecond = clicksPerSecond;
            PriceMultiplier = priceMultiplier;
        }
    }
}
