using System;

public class Commands
{

    public static string command;

    public static bool isRunnning = true; // this is put for breaking out of the loop when the user exits. // this is the user input

    public static Random rnd = new Random();

    public static string[] allCommands = new string[] {"random trivia", "random riddles", "random quote", "random joke", "random hobby", "random fact", "random dad joke", "random word", "random baby name neutral", "random number 0 100", "random password", "help" };
    public static void AllCommands()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("HELP COMMANDS:");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("help random");
        Console.WriteLine("help random trivia");
        Console.WriteLine("help random riddles");
        Console.WriteLine("help random quote");
        Console.WriteLine("help random joke");
        Console.WriteLine("help random hobby");
        Console.WriteLine("help random fact");
        Console.WriteLine("help random dad joke");
        Console.WriteLine("help weather");
        Console.WriteLine("help random word");
        Console.WriteLine("help random definition");
        Console.WriteLine("help worldtime");
        Console.WriteLine("help random baby name");
        Console.WriteLine("help random number");
        Console.WriteLine("help rhyme");
        Console.WriteLine("help random password");
        Console.WriteLine("help convert currency");
        Console.WriteLine("help url");
        Console.WriteLine("help e\n");

        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("NOTE:");
        Console.WriteLine("The above commands are for getting specific details on the commands for example, what exactly they are, how they work and if there are some optional arguments to pass in.\n");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Main commands (for specific information on them, look above).\n");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("random");
        Console.WriteLine("random trivia {topic} - don't include the {} and the {topic} is optional.");
        Console.WriteLine("random riddles");
        Console.WriteLine("random quote {topic} - don't include the {} and the {topic} is optional.");
        Console.WriteLine("random joke");
        Console.WriteLine("random hobby {topic} - don't include the {} and the {topic} is optional.");
        Console.WriteLine("random fact");
        Console.WriteLine("random dad joke");
        Console.WriteLine("weather {city name} - don't include the {}. The {city name} is required.");
        Console.WriteLine("random word - gives you a random word");
        Console.WriteLine("random definition {word} - don't include the {}. The {word} is required");
        Console.WriteLine("worldtime {city} - don't include the {}. The {city} is required.");
        Console.WriteLine("random baby name {boy, girl or neutral} - don't include the {} the {boy, girl or neutral} is required.");
        Console.WriteLine("random number {lowRange} {highRange} - don't include the {}. The {lowRange} and {highRange} is required.");
        Console.WriteLine("rhyme {word} - don't include the {}. The {word} is required.");
        Console.WriteLine("convert currency {TO} {WANT} {AMOUNT FROM TO} - type in help convert currency for more info");
        Console.WriteLine("url {url}");
        Console.WriteLine("e - will exit the program.");
        Console.WriteLine("random password\n\n");

        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("The above are the main commands for this app. If you're unsure as to what they are and how exactly to use them, please type in 'help {the command}'");
        Console.WriteLine("If you see any delay or if the commands don't work properly if you entered them, it may be a problem with the API. However if you see a bug, type or if you want to suggest something, contact me on discord.");
    }
    
    private static void SpecificHelpCommands()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        switch(command)
        {
            case "help random trivia":
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("The command 'random trivia' will give you a random trivia question.");
                Console.WriteLine("For more specific details, you can do random trivia {topic} and will give you a topic based on the input you have entered. NOTE: YOU DO NOT HAVE TO ENTER {}");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nHere are the arguments for {topic}:\n");
                Console.WriteLine("artliterature\r\nlanguage\r\nsciencenature\r\ngeneral\r\nfooddrink\r\npeopleplaces\r\ngeography\r\nhistoryholidays\r\nentertainment\r\ntoysgames\r\nmusic\r\nmathematics\r\nreligionmythology\r\nsportsleisure");
                break;
            case "help random riddles":
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("The command 'random riddles' will give you a random riddle question.");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("There are currently no arugments or optional options to provide for this.");
                break;
            case "help random quote":
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("The command 'random quote' will give you a random quote.");
                Console.WriteLine("For more specific details, you can do random quote {topic} and will give a you a topic based on the input you have entered. NOTE: YOU DO NOT HAVE TO ENTER THE {}");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nHere are the arguments for {topic}:\n");
                Console.WriteLine("age\r\nalone\r\namazing\r\nanger\r\narchitecture\r\nart\r\nattitude\r\nbeauty\r\nbest\r\nbirthday\r\nbusiness\r\ncar\r\nchange\r\ncommunications\r\ncomputers\r\ncool\r\ncourage\r\ndad\r\ndating\r\ndeath\r\ndesign\r\ndreams\r\neducation\r\nenvironmental\r\nequality\r\nexperience\r\nfailure\r\nfaith\r\nfamily\r\nfamous\r\nfear\r\nfitness\r\nfood\r\nforgiveness\r\nfreedom\r\nfriendship\r\nfunny\r\nfuture\r\ngod\r\ngood\r\ngovernment\r\ngraduation\r\ngreat\r\nhappiness\r\nhealth\r\nhistory\r\nhome\r\nhope\r\nhumor\r\nimagination\r\ninspirational\r\nintelligence\r\njealousy\r\nknowledge\r\nleadership\r\nlearning\r\nlegal\r\nlife\r\nlove\r\nmarriage\r\nmedical\r\nmen\r\nmom\r\nmoney\r\nmorning\r\nmovies\r\nsuccess");
                break;
            case "help random joke":
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("The command 'random joke' will give you a random joke.");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("There are currently no arguments or optional options to provide for this.");
                break;
            case "help random hobby":
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("The command 'random hobby' will give you a random hobby.");
                Console.WriteLine("For more specific details, you can do random hobby {topic} and it will give you a hobby based on the input you have entered. NOTE: YOU DO NOT HAVE TO ENTER THE {}.");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nHere are the arguments for {topic}:\n");
                Console.WriteLine("general\r\nsports_and_outdoors\r\neducation\r\ncollection\r\ncompetition\r\nobservation");
                break;
            case "help random fact":
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("The command 'random fact' will give you a random fact.");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("There are currently no arguments or optional options to provide for this.");
                break;
            case "help random dad joke":
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("The command 'random dad joke' will give you a random dad joke.");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("There are currently no arguments or optional options to provide for this.");
                break;
            case "help weather":
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("The command 'weather' will give you the weather for the city you have entered.");
                Console.WriteLine("To enter the city name, you need to do weather {cityName} - DO NOT INCLUDE THE {}.");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("MAKE SURE IT IS A VALID CITY NAME OR IT WILL GIVE AN ERROR.");
                break;
            case "help random word":
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("The command 'random word' will give you a random word.");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("There are currently no rguments or optinoal options to provide for this.");
                break;
            case "help random definition":
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("The command 'random definition' will give you the definition of a word.");
                Console.WriteLine("To get the definition of the word, you will need to do 'random definition {word}. NOTE: DO NOT TYPE IN {}'");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("MAKE SURE THE WORD IS VALID OR IT WILL THROW AN ERROR.");
                break;
            case "help worldtime":
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("The command 'worldtime {city}' will give you the time and details of the current city.");
                Console.WriteLine("To enter the city name, you need to do worldtime {city} - DO NOT INCLUDE THE {}.");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("MAKE SURE IT IS A VALID CITY NAME OR IT WILL GIVE AN ERROR.");
                break;
            case "help random baby name":
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("The command 'random baby name' will give you a list of baby names");
                Console.WriteLine("To run the command, you need to do help random baby name {type (boy, girl or neutral)}. DO NOT TYPE IN {}");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("The arguments for {type} is either boy, girl or neutral.");
                break;
            case "help random number":
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("The command 'random number {l} {h}' will give you a random number between a range.");
                Console.WriteLine("To get the random number between the range, you need to type in 'help random number {low} {high}");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("This will return a number between {low} and {high}");
                break;
            case "help rhyme":
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("The command 'random rhyme' will give you a list of rhyming words for the word you have entered..");
                Console.WriteLine("To get a list of rhyming words, you will need to do 'rhyme {word}'. NOTE: DO NOT TYPE IN {}'");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("MAKE SURE THE WORD IS VALID OR IT WILL THROW AN ERROR.");
                break;
            case "help random password":
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("The command 'random password' will give you a random password");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("There are currently no rguments or optinoal options to provide for this but you will be queried about those options when you run the command.");
                break;
            case "help random":
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("The command 'help random' will give you something random from all the main commands that are there.");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("There are currently no arguments or optinoal options to provide for this.");
                break;
            case "help convert currency":
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("The command 'convert currency {to}{want}{amount}' will convert the 'to' to the 'want' currency by the 'amount.'");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("To run the command, you must do convert currency {to}{want}{amount}.");
                Console.WriteLine("The {to} will take a currency, and convert that currency to {want} by the {amount}. NOTE: YOU DO NOT HAVE TO ENTER THE {}");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nFor example: convert currency LKR USD 5000. This will convert 5000LKR to USD.");
                Console.WriteLine("\nNOTE: You need to enter the 3 letters of the currency you want to convert to.");
                break;
            case "help url":
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("The command 'url' {url} will return stats and information on the url you have input");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("MAKE SURE YOU INPUT A VALID URL AND DO NOT INCLUDE THE {} OR YOU WILL GET AN ERROR.");
                break;  
            case "help e":
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("The command 'e' will exit the program for you.");
                break;
        }
    }

    private static async Task BasicInputs()
    {
        if (command == "random")
        {
            command = allCommands[rnd.Next(0, Commands.allCommands.Count())];
        }
        switch (command)
        {
            case "random riddles":

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(await ClientTemplate.ResponseRequest("https://api.api-ninjas.com/v1/riddles", "question"));

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Would you like to get the answer? (y/n): ");

                if (Console.ReadLine().ToLower() == "y")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(ClientTemplate.answer);
                }

                break;
            case "random joke":
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(await ClientTemplate.ResponseRequest("https://api.api-ninjas.com/v1/jokes?limit=1", "joke"));
                break;
            case "random fact":
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine(await ClientTemplate.ResponseRequest("https://api.api-ninjas.com/v1/facts?limit=1", "fact"));
                break;
            case "random dad joke":
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(await ClientTemplate.ResponseRequest("https://api.api-ninjas.com/v1/dadjokes?limit=1", "joke"));
                break;
            case "random word":
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(await ClientTemplate.ResponseRequest("https://api.api-ninjas.com/v1/randomword", "word"));
                break;
            case "e":
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Thanks for coming!");
                isRunnning = false;
                break;
            case "help":
                AllCommands();
                break;
            case "random password":
                while (true)
                {
                    try
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("What length do you want your password to be?: ");
                        PasswordGenerator.passwordLength = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (OverflowException)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("ERROR: The number was too big, please try again.");
                        continue;
                    }
                    catch
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("ERROR: the input is not a valid number, please try again.");
                        continue;
                    }

                    if (PasswordGenerator.passwordLength > 50)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("ERROR: Sorry but the number was too big, please try again.");
                        continue;
                    }

                    break;
                }
                Console.WriteLine("Would you like to include numbers? (y/n): ");
                PasswordGenerator.isNum = Console.ReadLine().ToLower() == "y" ? true : false;
                Console.WriteLine("Would you like to include special characters? (y/n): ");
                PasswordGenerator.isChar = Console.ReadLine().ToLower() == "y" ? true : false;

                Console.WriteLine(PasswordGenerator.GeneratePassword());
                break;
            default:
                SpecificHelpCommands();
                await CheckSpecificInputs();
                break;
        }
    }
    private static async Task CheckSpecificInputs()
    {
        try
        {
            if (command.Substring(0, 3) == "url")
            {
                try
                {
                    Console.WriteLine(await ExtraInformationAPI.ReturnInformationURL($"https://api.api-ninjas.com/v1/urllookup?url={command.Substring(4)}"));
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("ERROR: Invalid arguments, please try again.");
                }
            }
            else if (command.Substring(0, 5) == "rhyme")
            {
                await ListAPI.ReturnList($"https://api.api-ninjas.com/v1/rhyme?word={command.Substring(7)}");
            }

            else if (command.Substring(0, 7) == "weather")
            {
                try
                {
                    Console.WriteLine(await ExtraInformationAPI.ReturnWeatherData($"https://api.api-ninjas.com/v1/weather?city={command.Substring(8)}"));
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("ERROR: The data you entered is not valid, please try again.");
                }
            }
            else if (command.Substring(0, 12) == "random trivi")
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                try
                {
                    Console.WriteLine(await ClientTemplate.ResponseRequest($"https://api.api-ninjas.com/v1/trivia?category={command.Substring(14)}", "question"));
                }
                catch
                {
                    Console.WriteLine(await ClientTemplate.ResponseRequest($"https://api.api-ninjas.com/v1/trivia", "question"));
                }
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Would you like to get an answer? (y/n): ");

                if (Console.ReadLine().ToLower() == "y")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(ClientTemplate.answer);
                    ClientTemplate.answer = "";
                }
            }
            else if (command.Substring(0, 12) == "random quote")
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                try
                {
                    Console.WriteLine(await ClientTemplate.ResponseRequest($"https://api.api-ninjas.com/v1/quotes?category={command.Substring(13)}", "quote"));
                }
                catch
                {
                    Console.WriteLine(await ClientTemplate.ResponseRequest($"https://api.api-ninjas.com/v1/quotes", "quote"));
                }
            }
            else if (command.Substring(0, 12) == "random hobby")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                try
                {
                    Console.WriteLine(await ClientTemplate.ResponseRequest($"https://api.api-ninjas.com/v1/hobbies?category={command.Substring(13)}", "hobby"));
                }
                catch
                {
                    Console.WriteLine(await ClientTemplate.ResponseRequest($"https://api.api-ninjas.com/v1/hobbies", "hobby"));
                }
            }
            else if (command.Substring(0, 9) == "worldtime")
            {
                try
                {
                    Console.WriteLine(await ExtraInformationAPI.ReturnWorldTimeData($"https://api.api-ninjas.com/v1/worldtime?city={command.Substring(10)}"));
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("ERROR: Sorry, but the data you entered is not valid, please try again.");
                }
            }
            else if (command.Substring(0, 16) == "random baby name")
            {
                try
                {
                    await ListAPI.ReturnList($"https://api.api-ninjas.com/v1/babynames?gender={command.Substring(17)}");
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("ERROR: Invalid arguments, please try again.");
                }
            }
            else if (command.Substring(0, 17) == "random definition")
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                try
                {
                    Console.WriteLine(await ClientTemplate.ResponseRequest($"https://api.api-ninjas.com/v1/dictionary?word={command.Substring(18)}", "definition"));
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("ERROR: Invalid arguments or it is not a word. Please try again.");
                }
            }
            else if (command.Substring(0, 13) == "random number")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Random number: " + RandomNumGen.GenerateNumber(command));
            } else if (command.Substring(0,16) == "convert currency")
            {
                try
                {
                    Console.WriteLine(await ExtraInformationAPI.ReturnConvertCurrency($"https://api.api-ninjas.com/v1/convertcurrency?have={command.Substring(17).Substring(0).Substring(0, 3)}&want={command.Substring(17).Substring(0).Substring(3, 4).TrimStart()}&amount={command.Substring(17).Substring(0).Substring(7).TrimStart()}"));
                } catch 
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("ERROR: Invalid arguments, please try again.");
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ERROR: Sorry, I did not understand what you said. Please type 'view' if you are unsure about which command to use.");
            }
        }
        catch
        {
            // do something.
        }
    }

    public static async Task CheckInput()
    {
        while (isRunnning)
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("\nPlease enter a command, if you are unsure, type 'help'. If you want to exit, type 'e': ");
            command = Console.ReadLine().ToLower().Trim();

            await BasicInputs();
        }
    }
}

