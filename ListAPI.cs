using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;

public class ListAPI
{
    public static readonly string APIKEY = ClientTemplate.APIKEY;

    public static string error { get; set; }
	public static async Task ReturnList(string url)
	{
        HttpClient client = new HttpClient();
        var request = new HttpRequestMessage
        {
            Method = HttpMethod.Get,
            RequestUri = new Uri(url),
            Headers =
            {
                {"X-Api-Key", APIKEY},
            }
        };

        using (var response = await client.SendAsync(request))
        {
            var content = await response.Content.ReadAsStringAsync();
            
            try
            {
                var jsonFile = JsonConvert.DeserializeObject<JObject>(content);

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ERROR: gender parameter must be boy, girl or neutral.");
            } catch
            {
                var results = content.Split(",").ToList();

                Console.ForegroundColor = ConsoleColor.Yellow;

                if (results.Count <= 1)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    results.Add("ERROR: There is no results for this data.");
                }

                foreach (var result in results)
                {
                    Console.WriteLine(result);
                }
            }
        };
    }
}
