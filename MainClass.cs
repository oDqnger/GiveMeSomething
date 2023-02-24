using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Threading.Tasks;

public class MainClass
{   
    // this is where everything gets run
    public static async Task Main(string[] args)
    {
        // this will print out a function and give out information that the user needs at the beginning of the program so they konw what they are doing
        Greetings();
        // this checks for any input from the user.
        await Commands.CheckInput();


    }

    // function for the greeting
    private static void Greetings()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Welcome to 'Give Me Something.'\n");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("In this application, you can ask the application for stuff, such as, a joke, a riddle, a quote to stuff like a password generator, the weather, the dictionary and more!");

        Console.WriteLine("This is really useful for you as this doesn't use that much resources, you don't have to put much effort into typing these queries and overall, it's just really efficient and easy to use.\n");
        Console.WriteLine("To get started, type 'help' to get the list of commands you can run.\n\n");

        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("NOTE: if you see any downtime when you're running the application, it may be a problem with the API, so you might have to be patient and wait a bit for it to get back to its normal pace.");
        Console.WriteLine("However, if you see any bugs, typos or even a suggestion you would like to give, please don't hesitate to contact me on discord. oDqnger#9216");
        Console.WriteLine("This update may recieve some updates as this is still a prototype, so make sure you stay updated with my github.\n");

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Enjoy!");
    }
}