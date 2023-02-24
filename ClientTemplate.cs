using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Bson;
using Newtonsoft.Json.Linq;

public class ClientTemplate
{
    public const string apiKeyPath = @"C:\Users\Diman\Desktop\Diman\Programming work\C#\GiveMeSomething\GiveMeSomething\APIKEY.txt";
    public static readonly string APIKEY = File.ReadAllLines(apiKeyPath)[0];

    public static string answer { get; set; }
    public static string category { get; private set; }
    public static string author { get; private set; }
    public static async Task<string> ResponseRequest(string url, string topic)
    {
        HttpClient client = new HttpClient();
        var request = new HttpRequestMessage()
        {
            Method = HttpMethod.Get,
            RequestUri = new Uri(url),
            Headers =
            {
                {"X-Api-Key", APIKEY},
            },
        };

        using (var response = await client.SendAsync(request))
        {
            try
            {
                var content = await response.Content.ReadAsStringAsync();

                if (content[0] == '[')
                {
                    content = content.Remove(0, 1);
                    content = content.Remove(content.Length - 1);
                }

                var o = JsonConvert.DeserializeObject<JObject>(content);

                answer = (string)o["answer"] != null ? (string)o["answer"] : "";
                author = (string)o["author"] != null ? ". By " + (string)o["author"] : "";
                category = (string)o["category"] != null ? ". Category: " + (string)o["category"] : "";

                if ((string)o[topic] == "" || (string)o[topic] == null)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    return "ERROR: There is no results for the data you have entered or it is invalid.";
                }
                return topic + ": " + (string)o[topic] + author + category;
            }
            catch (NullReferenceException e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                answer = "There is no answer for this invalid command.";
                return "ERROR: Invalid argument. If you are unsure about which one to type out, please type 'view'.";
            }
        } 
    }
}
