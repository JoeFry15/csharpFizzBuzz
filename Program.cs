
Console.WriteLine("Type which mode number of FizzBuzz you would like: \n (1) FizzBuzz with rule selection \n (2) Simple FizzBuzz");
string fizzBuzzMode = Console.ReadLine()!;

if (fizzBuzzMode == "1")
{
    Console.Write("Please input a maximum number: ");
    string maxNum = Console.ReadLine()!;
    Console.Write("Which rules would you like to apply? Please type fizz/fezz/buzz/bang/bong: ");
    string ruleSelections = Console.ReadLine()!.ToLower();

    for (int i = 1; i <= int.Parse(maxNum); i++)
    {
        List<string> output = new List<string>();

        if (i % 3 == 0 && ruleSelections.Contains("fizz"))
        {
            output.Add("Fizz");
        }

        if (i % 13 == 0 && ruleSelections.Contains("fezz"))
        {
            output.Add("Fezz");
        }

        if (i % 5 == 0 && ruleSelections.Contains("buzz"))
        {
            output.Add("Buzz");
        }

        if (i % 7 == 0 && ruleSelections.Contains("bang"))
        {
            output.Add("Bang");
        }

        if (i % 11 == 0 && ruleSelections.Contains("bong"))
        {
            output.Clear();
            if (i % 13 == 0 && ruleSelections.Contains("fezz"))
            {
                output.Add("Fezz");
            }
            output.Add("Bong");
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

