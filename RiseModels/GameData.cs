using System;
using System.Collections.Generic;
using System.Text;

namespace RiseModels
{
    public class GameData
    {
        public bool Refresh { get; set; } = false;
        public string Id { get; set; }
        public double Breads { get; set; }
        public double ClickValue { get; set; }
        public double ClicksPerSecond { get; set; }
        public List<UserUpgrade> Upgrades { get; set; }
    }
}
