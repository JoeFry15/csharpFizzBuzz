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

    if (output.Any())
    {
        Console.WriteLine(string.Join("", output));
    }
    else
    {
        Console.WriteLine(i);
    }
}