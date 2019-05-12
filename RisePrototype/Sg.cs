using Firebase.Database;
using RiseModels;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RisePrototype
{
    public static class Sg
    {
        public const string BaseUrl = "https://patricioclicker.firebaseio.com/";
        public static User User { get; set; }
        public static FirebaseClient Reference { get; set; }
        public static string ServerIp { get; set; }


        public static Image CloseButtonDefault { get; set; } = RisePrototype.Properties.Resources.close;
        public static Image CloseButtonHighlighted { get; set; } = RisePrototype.Properties.Resources.close_filled;
        public static Image MinimizeButtonDefault { get; set; } = RisePrototype.Properties.Resources.minimize;
        public static Image MinimizeButtonHighlighted { get; set; } = RisePrototype.Properties.Resources.minimize_filled;



        #region Colors
        public static Color LightBrown { get; } = Color.FromArgb(208, 93, 70);
        public static Color DarkBrown { get; } = Color.FromArgb(153, 65, 48);
        public static Color BlackBrown { get; } = Color.FromArgb(88, 47, 34);
        public static Color AccentColor { get; } = Color.FromArgb(182, 67, 63);
        public static Color LightGray { get; } = Color.FromArgb(226, 229, 231);

        #endregion

        private static LoginForm loginForm;

        public static LoginForm LoginForm
        {
            get
            {
                if (loginForm == null)
                {
                    loginForm = new LoginForm();
                }
                return loginForm;
            }
        }


    }
}
