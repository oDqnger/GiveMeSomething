using System;
public class RandomNumGen
{
    public static int lowNum { get; private set; }
    public static int highNum { get; private set; }

    public static int randomNum { get; private set; }
    public static int GenerateNumber(string command)
    {

        string lowNumString = "";
        string highNumString = "";

        bool isLow = false;
        // random number 0 100 100
        for (int x = 14; x < command.Length; x++)
        {
            if (command[x] != ' ' && !isLow)
            {
                lowNumString += command[x];
            }
            else
            {
                isLow = true;
                if (command[x] != ' ' && isLow)
                {
                    highNumString += command[x];
                }
            }
        }

        lowNum = Convert.ToInt32(lowNumString);
        highNum = Convert.ToInt32(highNumString);

        Random rnd = new Random();
        randomNum = rnd.Next(lowNum, highNum);

        return randomNum;
    }
}

public class PasswordGenerator
{
    public static int passwordLength { get; set; }
    public static bool isNum { private get; set; }
    public static bool isChar { private get; set; }
    public static string GeneratePassword()
    {
        string password = "";

        string lowercase = "abcdefghijklmnopqrstuvwsyz";
        string uppercase = lowercase.ToUpper();
        string nums = "0123456789";
        string specialChars = @"!@#$%^&*()";


        string[] all = { };

        if (!isNum && !isChar)
        {
            all = new string[] { lowercase, uppercase };
        }
        else if (isNum && isChar)
        {
            all = new string[] { lowercase, uppercase, specialChars, nums };
        }
        else if (isChar)
        {
            all = new string[] { lowercase, uppercase, specialChars };
        }
        else if (isNum)
        {
            all = new string[] { lowercase, uppercase, nums };
        }


        Random rnd = new Random();

        int randomChar;

        for (int x = 0; x < passwordLength; x++)
        {
            randomChar = rnd.Next(0, all.Length);
            password += all[randomChar][rnd.Next(0, all[randomChar].Length)];
        }

        return password;
    }
}
