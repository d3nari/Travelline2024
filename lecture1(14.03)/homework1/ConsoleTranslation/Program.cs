public class Program
{
    private static Dictionary<string, string> wordDictionary = new Dictionary<string, string>();
    private static string dictionaryFilePath = "../../../dictionary.txt";
    
    enum Commands { AddTranslation = 1, Translate = 2, Exit = 3};

    public static void ConsoleMenu()
    {
        bool isContinue = true; 
        while (isContinue)
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
                    case Commands.Exit:
                        isContinue = false;
                        break;
                    default:
                        Console.WriteLine("Eror: wrong command");
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
        Console.WriteLine("3.Exit");
    }

    public static void AddTranslation(string inputStr)
    {
        ReadFile($"../../../{inputStr}.txt");
        WriteFile(dictionaryFilePath);
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
                    if (dictionary.ContainsKey(words[0])){
                        dictionary[words[0]] = words[1];
                    }
                    else
                    {
                        dictionary.Add(words[0], words[1]);
                    }
                }
                wordDictionary = dictionary;
                Console.WriteLine("File read successfully");
            }
        }
        catch (InvalidDataException ex)
        {
            Console.WriteLine($"Eror: data processing eror: {ex.Message}");
            dictionary.Clear();
        }
    }

    public static void WriteFile(string filePath)
    {
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            foreach (var element in wordDictionary)
            {
                writer.WriteLine($"{element.Key} {element.Value}");
            }
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
        ReadFile(dictionaryFilePath);
        ConsoleMenu();
    }
}
