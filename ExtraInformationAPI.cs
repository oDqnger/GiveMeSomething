using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

public class ExtraInformationAPI
{
	private static readonly string APIKEY = ClientTemplate.APIKEY;

	public static async Task<string> ReturnWorldTimeData(string url)
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

			var o = JsonConvert.DeserializeObject<JObject>(content);

			return WorldTimeDataFunction(o);
		};
	}

    public static async Task<string> ReturnWeatherData(string url)
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
            try
            {
                var content = await response.Content.ReadAsStringAsync();
                var o = JsonConvert.DeserializeObject<JObject>(content);

                return ReturnWeatherData(o);
            }
            catch (NullReferenceException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                return "Invalid argument. If you are unsure about which one to type out, please type 'view'.";
            }
        }
    }

    public static async Task<string> ReturnConvertCurrency(string url) {
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
            try
            {
                var content = await response.Content.ReadAsStringAsync();

                var jsonFile = JsonConvert.DeserializeObject<JObject>(content);

                return ConvertCurrencyDisplay(jsonFile);
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                return "ERROR: Invalid argument. If you are unsure about which one to type out, please type 'view'.";
            }
        }
    }

    public static async Task<string> ReturnInformationURL(string url)
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

            var jsonFile = JsonConvert.DeserializeObject<JObject>(content);

            return InformationURL(jsonFile);
        }
    }

    public static string WorldTimeDataFunction(JObject o)
	{
		Console.ForegroundColor = ConsoleColor.White;
        if ((string)o["timezone"] == "" || o["timezone"] == null)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            return "ERROR: The data you entered is invalid, please try again.";
        }
		Console.WriteLine($"\nThe timezone is: {o["timezone"]}");
		Console.WriteLine($"The datetime for this country is: {o["datetime"]}");
		Console.WriteLine($"The date is {o["year"]}-{o["month"]}-{o["day"]}");
		Console.WriteLine($"The time is currently {o["hour"]}:{o["minute"]}:{o["second"]}");
		return $"It is {o["day_of_week"]}";
	}

    public static string ReturnWeatherData(JObject jsonFile)
    {
        Console.ForegroundColor = (int)jsonFile["temp"] <= 8 ? ConsoleColor.Gray : ConsoleColor.White;
        Console.WriteLine("\nToday's weather will be: ");
        Console.ForegroundColor = (int)jsonFile["temp"] <= 8 ? ConsoleColor.Cyan : ConsoleColor.Red;
        Console.WriteLine($"The temperature is: {jsonFile["temp"]}");
        Console.ForegroundColor = (int)jsonFile["min_temp"] <= 8 ? ConsoleColor.Cyan : ConsoleColor.Red;
        Console.WriteLine($"The minimum temperature is: {jsonFile["min_temp"]}");
        Console.ForegroundColor = (int)jsonFile["max_temp"] <= 8 ? ConsoleColor.Cyan : ConsoleColor.Red;
        Console.WriteLine($"The maximum temperature is: {jsonFile["max_temp"]}");
        Console.ForegroundColor = (int)jsonFile["feels_like"] <= 8 ? ConsoleColor.Cyan : ConsoleColor.Red;
        Console.WriteLine($"It feels like: {jsonFile["feels_like"]}");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Humidity: {jsonFile["humidity"]}");
        Console.ForegroundColor = ConsoleColor.Green;
        return $"Wind speed: {jsonFile["wind_speed"]}";
    }

    public static string ConvertCurrencyDisplay(JObject jsonFile)
    {
        Console.ForegroundColor = (string)jsonFile["new_amount"] != null ? ConsoleColor.Yellow : ConsoleColor.Yellow;
        return $"\n{(int)jsonFile["old_amount"]} {(string)jsonFile["old_currency"]} to {(string)jsonFile["new_currency"]} is {(int)jsonFile["new_amount"]}{(string)jsonFile["new_currency"]}";
    }

    public static string InformationURL(JObject jsonFile)
    {
        if ((bool)jsonFile["is_valid"] == false)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            return $"ERROR: the url, {(string)jsonFile["url"]} is not valid. Please try again.";
        }
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($"\nThe url, {(string)jsonFile["url"]}, has the following features: ");
        Console.WriteLine($"The country the url is located in is {(string)jsonFile["country"]}");
        Console.WriteLine($"It's region is {(string)jsonFile["region"]}");
        Console.WriteLine($"It's city is in {(string)jsonFile["city"]}");
        return($"The isp for this website is, {(string)jsonFile["isp"]}");
    }
}
