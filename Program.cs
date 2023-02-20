Console.Write("Please input a maximum number: ");
string maxNum = Console.ReadLine()!;

for (int i = 1; i <= int.Parse(maxNum); i++)
{
    List<string> output = new List<string>();

    if (i % 3 == 0)
    {
        output.Add("Fizz");
    }

    if (i % 13 == 0)
    {
        output.Add("Fezz");
    }

    if (i % 5 == 0)
    {
        output.Add("Buzz");
    }

    if (i % 7 == 0)
    {
        output.Add("Bang");
    }

    if (i % 11 == 0)
    {
        output.Clear();
        if (i % 13 == 0)
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