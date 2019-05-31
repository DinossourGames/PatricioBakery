using Firebase.Database.Query;
using RiseModels;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace RisePrototype
{
    public static class GM
    {
        #region Properties
        public static ConnectionState State { get; private set; } = ConnectionState.DISCONNECTED;
        public static GameData Game { get; set; } = null;
        public static string Pool { get; private set; } = null;
        private static GameData ServerData { get; set; }
        public static List<Upgrade> UpgradesRef { get; private set; }
        private static double milestone = 50;

        public static readonly Color OkColor = Color.Red;
        public static readonly Color CancelColor = Color.Red;

        #endregion

        #region Static Methods
        public async static Task Initiate()
        {
            milestone = Sg.User.ClicksTotais == 0 ? 50 : Sg.User.ClicksTotais + 50;

            await GetUpgrades();
            var result = await GetGamedataByIDAsync(Sg.User.Id);

            ServerData = result;
            if (ServerData == null)
            {
                await CreateGameData();
                StartListenServerData();
            }
            else
            {
                StartListenServerData();
                Game = ServerData;
            }

        }

        private static void StartListenServerData()
        {
            Sg.Reference.Child("Gamedata").AsObservable<GameData>().Subscribe(i =>
            {
                if (i.Key == Sg.User.Id)
                    ServerData = i.Object;
            });
        }

        private async static Task CreateGameData()
        {
            var game = new GameData()
            {
                Id = Sg.User.Id,
                Breads = 0f,
                ClicksPerSecond = 0f,
                ClickValue = 1f,
                Upgrades = new List<UserUpgrade>()
            };

            UpgradesRef.ForEach(i => game.Upgrades.Add(new UserUpgrade(i.ID, 0)));
            await Sg.Reference.Child("Gamedata").Child(game.Id).PutAsync(game);
            Game = game;
        }

        public async static Task<GameData> GetGamedataByIDAsync(string id)
        {
            var response = await Sg.Reference.Child("Gamedata").OnceAsync<GameData>();
            if (response.Count > 0)
            {
                GameData obj = null;
                var a = response.ToList();
                a.ForEach(i =>
                {
                    if (i.Object.Id == id)
                    {
                        obj = i.Object;
                    }
                });
                return obj;
            }
            else
                return null;
        }

        public static async Task<List<Upgrade>> GetUpgrades()//it works
        {
            var result = await Sg.Reference.Child("Upgrades").OnceAsync<Upgrade>();
            var list = result.ToList();
            var response = new List<Upgrade>();
            list.Reverse();
            list.ForEach(i => response.Add(i.Object));
            UpgradesRef = response;
            return response;
        }

        public static async Task<bool> UpdateGame()
        {
            await Sg.Reference.Child("Gamedata").Child(Game.Id).PutAsync(Game).ContinueWith(r => { return r.IsFaulted == true ? false : true; });
            return false;
        }

        public static async Task<bool> UpdateGame(GameData game)
        {
            await Sg.Reference.Child("Users").Child(game.Id).PutAsync(game).ContinueWith(r => { return r.IsFaulted == true ? false : true; });
            return false;
        }

     
        public static void ComputeClick()
        {
            Game.Breads += Game.ClickValue;
            if (Sg.User.ClicksTotais >= milestone)
            {
                milestone += 50;
                Game.ClickValue += 2;
            }
            Sg.User.ClicksTotais++;
        }
        public static void ComputeClick(double clickValue)
        {
            Game.Breads += clickValue;
        }

        public static Upgrade BuyUpgrade(int ammount, Upgrade upgradeButton)
        {
            var gameUpgrade = Game.Upgrades.FirstOrDefault(i => upgradeButton.ID == i.UpgradeID);
            var upgradeReference = UpgradesRef.FirstOrDefault(i => gameUpgrade.UpgradeID == i.ID);

            double baseprice = Math.Ceiling((upgradeReference.Price * Math.Pow(upgradeButton.PriceMultiplier, upgradeButton.Ammount)));
            double price = Math.Ceiling((upgradeReference.Price * Math.Pow(upgradeButton.PriceMultiplier, upgradeButton.Ammount)) * ammount);


            if (Game.Breads >= price)
            {
                Game.Breads -= price;
                gameUpgrade.Ammount += ammount;
                Game.ClicksPerSecond += gameUpgrade.Ammount != 0 ? gameUpgrade.Ammount : 1 * upgradeButton.ClicksPerSecond;
                return upgradeButton;
            }
            else
            {
                var valor = baseprice * Math.Pow((1 + upgradeButton.PriceMultiplier), ammount);
                var qq = Math.Floor(Game.Breads / valor);
                Game.Breads -= qq * baseprice;
                gameUpgrade.Ammount += (int)Math.Floor(qq);
                Game.ClicksPerSecond += gameUpgrade.Ammount != 0 ? gameUpgrade.Ammount : 1 * upgradeButton.ClicksPerSecond;
            }
            return upgradeButton;
        }


        #endregion
    }
}
