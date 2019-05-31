using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace RisePrototype
{
    public static class RestHelper
    {
        public static string ServerIP { get; private set; }
        public static RestClient HttpClient { get; private set; }

        public async static void GetServerIp() {
            var a = await Sg.Reference.Child("ServerIp").OnceSingleAsync<string>();
            ServerIP = a;
            Debug.WriteLine(ServerIP);
            HttpClient = new RestClient(ServerIP);
        }

        public static bool Votar(int index)
        {
            var request = new RestRequest("vote", Method.GET);
            request.AddParameter("voto",index);
            var response =HttpClient.Execute(request, Method.GET);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
                return true;
            else return false;
        }
    }
}
