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

        public static async Task<List<Upgrade>> InitiateUI()
        {
            var result = await Sg.Reference.Child("Upgrades").OnceAsync<Upgrade>();
            var list = result.ToList();
            var response = new List<Upgrade>();
            list.Reverse();
            list.ForEach(i => response.Add(i.Object));
            return response;
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

            string[] img = { "https://olhardigital.com.br/uploads/acervo_imagens/2019/05/r16x9/20190508084427_1200_675.jpg",
                     "https://conteudo.imguol.com.br/c/entretenimento/ee/2019/05/11/cena-de-pokemon-detetive-pikachu-1557603270667_v2_900x506.png",
                     "https://www.ovale.com.br/_midias/jpg/2019/05/08/pikachu-524639.jpg",
                     "https://feededigno.com.br/wp-content/uploads/2019/05/detetive-pikachu-08-05-19-img03.jpg",
                     "https://conteudo.imguol.com.br/c/entretenimento/cc/2019/05/08/pikachu---primeira-geracao-1557342275054_v2_600x337.jpg",
                     "https://static1.purebreak.com.br/articles/4/86/16/4/@/323080-filme-pokemon-detetive-pikachu-e-chei-diapo-2.jpg"
                };
            //    Random rnd = new Random();
            //    for (int i = 0; i < 25; i++)
            //    {
            //        upgrades.Add(new Upgrade(img[rnd.Next(0,img.Length)], img[rnd.Next(0, img.Length)], $"Dumb Upgrade {i}", i * 100f, 0));
            //    }

            var upgrades = new List<Upgrade>();

            upgrades.Add(new Upgrade(img[3], img[3], "Pesquisa", 10000, 0));
            upgrades.Add(new Upgrade(img[2], img[2], "Fabrica", 1000, 0));
            upgrades.Add(new Upgrade(img[1], img[1], "Igreja", 100, 0));
            upgrades.Add(new Upgrade(img[0], img[0], "Ajudantes", 10, 2));

            return upgrades;
        }



        #endregion
    }
}
