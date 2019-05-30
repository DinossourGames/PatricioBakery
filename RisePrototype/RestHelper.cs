using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RisePrototype
{
    public static class RestHelper
    {
        public static string ServerIP { get; private set; }

        public async static void GetServerIp() {
            var a = await Sg.Reference.Child("ServerIp").OnceSingleAsync<string>();
            ServerIP = a;
            Debug.WriteLine(ServerIP);
        }
        public static void StartListenPool() { }
    }
}
