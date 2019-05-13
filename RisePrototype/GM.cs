using Firebase.Database.Query;
using RiseModels;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RisePrototype
{
    public static class GM
    {
        #region Properties
        public static ConnectionState State { get; private set; } = ConnectionState.DISCONNECTED;
        public static GameData Game { get; private set; } = null;
        public static string Pool { get; private set; } = null;
        private static GameData ServerData { get; set; }

        public static readonly Color OkColor = Color.Red;
        public static readonly Color CancelColor = Color.Red;

        #endregion

        #region Static Methods
        public static void Initiate()
        {
            if (Game == null)
            {
                Game = new GameData() { Breads = 0, ClickValue = 1f };
            }
        }

        //private static bool Connect()
        //{
        //    if (State == 0)
        //    {
        //        try
        //        {
        //            Sg.Reference.Child("GameData").Child(Sg.User.Id).AsObservable<GameData>().Subscribe(i => {
        //                State = ConnectionState.LISTENING;
        //                ServerData = i.Object;
        //            });
        //            return true;
        //        }
        //        catch
        //        {
        //            State = ConnectionState.DISCONNECTED;
        //            return false;
        //        }
        //    }

        //    return true;
        //}
        //private static bool PoolListener()
        //{
        //    if (State == 0)
        //    {
        //        try
        //        {
        //            Sg.Reference.Child("GameData").Child(Sg.User.Id).AsObservable<string>().Subscribe(i => {
        //                Pool = i.Object;
        //            });
        //            return true;
        //        }
        //        catch
        //        {
        //            State = ConnectionState.DISCONNECTED;
        //            return false;
        //        }
        //    }

        //    return true;
        //}

        public static void ComputeClick()
        {
            Game.Breads += Game.ClickValue;
        }
        public static void ComputeClick(int clickValue)
        {
            Game.Breads += clickValue;
        }

        public static Upgrade BuyUpgrade(int ammount, Upgrade sender)
        {
            var price = sender.Price * ammount;
            if (Game.Breads >= price)
            {
                Game.Breads -= price;
                sender.Ammount += ammount;
                return sender;
            }
            return sender;
        }

        internal static List<Upgrade> PrepareDumbData()
        {
            string image = "https://conteudo.imguol.com.br/c/entretenimento/ee/2019/05/11/cena-de-pokemon-detetive-pikachu-1557603270667_v2_900x506.png";
            var upgrades = new List<Upgrade>();
            for (int i = 0; i < 8; i++)
            {
                upgrades.Add(new Upgrade(image, image, $"Dumb Upgrade {i}", i * 100f, 0));
            }
            return upgrades;
        }



        #endregion
    }
}
