Console.Write("Type which mode number of FizzBuzz you would like: \n (1) FizzBuzz with rule selection \n (2) Simple FizzBuzz \n Enter option: ");
string fizzBuzzMode = Console.ReadLine()!;

Dictionary<string, bool> rules = new Dictionary<string, bool>()
{
    {"fizz", false },
    {"buzz", false },
    {"bang", false },
    {"fezz", false },
    {"bong", false },
};

if (fizzBuzzMode == "1")
{
    Console.Write("Please input a maximum number: ");
    string maxNum = Console.ReadLine()!;

    Console.Write("Which rules would you like to apply? Please type fizz/fezz/buzz/bang/bong: ");
    string ruleSelections = Console.ReadLine()!.ToLower();

    foreach (KeyValuePair<string, bool> entry in rules)
    {
        rules[entry.Key] = ruleSelections.Contains(entry.Key);
    }

    for (int i = 1; i <= int.Parse(maxNum); i++)
    {
        List<string> output = new List<string>();

        if (i % 3 == 0 && rules["fizz"])
        {
            output.Add("Fizz");
        }

        if (i % 13 == 0 && rules["fezz"])
        {
            output.Add("Fezz");
        }

        if (i % 5 == 0 && rules["buzz"])
        {
            output.Add("Buzz");
        }

        if (i % 7 == 0 && rules["bang"])
        {
            output.Add("Bang");
        }

        if (i % 11 == 0 && rules["bong"])
        {
            output.Clear();
            if (i % 13 == 0 && rules["fezz"])
            {
                output.Add("Fezz");
            }
            output.Add("bong");
        }

        if (i % 17 == 0)
        {
            output.Reverse();
        }

        Console.WriteLine(output.Any() ? string.Join("", output) : i);
    }
}
else
{
    Enumerable.Range(1, 100).ToList().ForEach(i => Console.WriteLine((i % 3 == 0 || i % 5 == 0 || i % 7 == 0) ? ((i % 3 == 0 ? "Fizz" : "") + (i % 5 == 0 ? "Buzz" : "") + (i % 7 == 0 ? "Bang" : "")) : i));
}