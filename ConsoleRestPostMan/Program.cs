using RestSharp;
using System;

namespace ConsoleRestPostMan
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new RestClient("https://api.twitter.com/2/tweets/sample/stream");
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            request.AddHeader("Cookie", "personalization_id=\"v1_wIJduZ4fJ9BYGUk1RC7Bsw==\"; guest_id=v1%3A159788295328849170");
            IRestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);

            Console.ReadKey();
        }
    }
}
