using Firebase.Database;
using Firebase.Database.Query;
using RiseModels;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace RisePrototype
{
    public static class Sg
    {
        public const string BaseUrl = "https://patricioclicker.firebaseio.com/";
        public static User User { get; set; }
        public static FirebaseClient Reference { get; set; }


        public static Image CloseButtonDefault { get; set; } = RisePrototype.Properties.Resources.close;
        public static Image CloseButtonHighlighted { get; set; } = RisePrototype.Properties.Resources.close_filled;
        public static Image MinimizeButtonDefault { get; set; } = RisePrototype.Properties.Resources.minimize;
        public static Image MinimizeButtonHighlighted { get; set; } = RisePrototype.Properties.Resources.minimize_filled;



        #region Colors
        public static Color LightBrown { get; } = Color.FromArgb(208, 93, 70);
        public static Color DarkBrown { get; } = Color.FromArgb(153, 65, 48);
        public static Color BlackBrown { get; } = Color.FromArgb(88, 47, 34);
        public static Color AccentColor { get; } = Color.FromArgb(182, 67, 63);
        public static Color SelectedColor { get; } = Color.FromArgb(41, 204, 99);
        public static Color HoverColor { get; } = Color.FromArgb(162, 85, 163);
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

        public static bool IsValidUser { get => User == null ? false : true; }
        public static string StringPath { get; private set; }
        public static List<Iten> ix { get; set; }

        #region StaticMethods

        //Create
        public async static Task<bool> CreateUserAsync(User user)
        {
            var result = await Reference.Child("Users").PostAsync(new User());
            user.Id = result.Key;
            var updateResult = await UpdateUser(user);
            if (updateResult)
            {
                try
                {
                    var u = GetUserAsync(user);
                    if (u != null)
                    {
                        User = user;
                        return true;
                    }
                    return false;
                }
                catch
                {
                    return false;
                }
            }
            return false;
        }


        //Read
        public async static Task<User> GetUserAsync(string username)
        {
            var response = await Reference.Child("Users").OrderBy("Username").StartAt(username).OnceAsync<User>();
            User user = new User();
            response.ToList().ForEach(item =>
            {
                if (string.Equals(username, item.Object.Username))
                    user = item.Object;
            });
            return user.Id == null ? null : user;
        }
        public async static Task<User> GetUserAsync(User user)
        {
            var response = await Reference.Child("Users").OrderBy("Username").StartAt(user.Username).OnceAsync<User>();
            User u = new User();
            response.ToList().ForEach(item =>
            {
                if (string.Equals(user.Username, item.Object.Username))
                    user = item.Object;
            });
            return user.Id == null ? null : user;
        }
        public async static Task<User> GetUserByIDAsync(string id)
        {
            var response = await Reference.Child("Users").Child(id).OnceAsync<User>();
            if (response.Count > 0)
                return response.First().Object;
            else
                return null;
        }
        public async static Task<bool> HasUserAsync(string username)
        {
            var response = await Reference.Child("Users").OrderBy("Username").StartAt(username).OnceAsync<User>();
            User user = new User();
            response.ToList().ForEach(item =>
            {
                if (string.Equals(username.ToLower(), item.Object.Username.ToLower()))
                    user = item.Object;
            });
            return user.Id == null ? false : true;
        }

        //Update
        public static async Task<bool> UpdateUser()
        {
            await Reference.Child("Users").Child(User.Id).PutAsync(User).ContinueWith(r => { return r.IsCompleted  ? true : false; });
            return false;
        }

        public static async Task<bool> UpdateUser(User user)
        {
            await Reference.Child("Users").Child(user.Id).PutAsync(user).ContinueWith(r => { return r.IsCompleted  ? true : false; });
            return false;
        }

        #endregion

    }
}
