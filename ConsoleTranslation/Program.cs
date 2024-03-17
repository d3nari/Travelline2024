﻿public class Program
{
    private static Dictionary<string, string> wordDictionary = new Dictionary<string, string>();
    enum Commands { AddTranslation, Translate };

    public static void ConsoleMenu()
    {
        while (true)
        {
            PrintMenu();
            string menuInput = Console.ReadLine();

            if (Enum.TryParse(menuInput, true, out Commands userCommand))
            {
                switch (userCommand)
                {
                    case Commands.AddTranslation:
                        Console.WriteLine("Enter file name: ");
                        AddTranslation(Console.ReadLine());
                        break;
                    case Commands.Translate:
                        Console.WriteLine("Enter word: ");
                        Translate(Console.ReadLine());
                        break;
                }
            }
            else
            {
                Console.WriteLine("Eror: wrong command");
            }
        }
    }

    public static void PrintMenu()
    {
        Console.WriteLine("Translation commands menu");
        Console.WriteLine("1.AddTranslation");
        Console.WriteLine("2.Translate");
    }

    public static void AddTranslation(string inputStr)
    {
        ReadFile($"../../../{inputStr}.txt");
    }

    public static void Translate(string inputStr)
    {   
        if (wordDictionary.TryGetValue(inputStr, out string translateWord))
        {
            Console.WriteLine(translateWord);
        }
        else
        {
            Console.WriteLine("Eror: wrong input word");
        }
    }

    public static void ReadFile(string filePath)
    {
        var dictionary = new Dictionary<string, string>();
        string[] words;

        if (!File.Exists(filePath))
        {
            Console.WriteLine($"Eror: {filePath} don't exist");
            return;
        }

        try 
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    words = FillDictionary(line);
                    dictionary.Add(words[0], words[1]);
                }
                wordDictionary = dictionary;
            }
        }
        catch (InvalidDataException ex)
        {
            Console.WriteLine($"Eror: data processing eror: {ex.Message}");
            dictionary.Clear();
        }
    }

    public static string[] FillDictionary(string line)
    {
        string[] words = line.Split(' ');

        if (words.Length == 2)
        {
            return words;
        }
        else
        {
            throw new InvalidDataException("incorrect line data");
        }
        
    }

    public static void Main(string[] args)
    {
        ConsoleMenu();
    }
}
