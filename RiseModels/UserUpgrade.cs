using System;
using System.Collections.Generic;
using System.Text;

namespace RiseModels
{
    public class UserUpgrade
    {
        public string UpgradeID { get; set; }
        public int Ammount { get; set; }

        public UserUpgrade()
        {

        }
        public UserUpgrade(string upgradeID, int ammount)
        {
            UpgradeID = upgradeID;
            Ammount = ammount;
        }
    }
}
