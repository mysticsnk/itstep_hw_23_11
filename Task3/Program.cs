char num1 = Convert.ToChar(Console.ReadLine());
if (!char.IsDigit(num1))
{
    Console.WriteLine("Invalid digit.");
    Environment.Exit(-1);
}

char num2 = Convert.ToChar(Console.ReadLine());
if (!char.IsDigit(num2))
{
    Console.WriteLine("Invalid digit.");
    Environment.Exit(-1);
}

char num3 = Convert.ToChar(Console.ReadLine());
if (!char.IsDigit(num3))
{
    Console.WriteLine("Invalid digit.");
    Environment.Exit(-1);
}

char num4 = Convert.ToChar(Console.ReadLine());
if (!char.IsDigit(num4))
{
    Console.WriteLine("Invalid digit.");
    Environment.Exit(-1);
}

string result = Convert.ToString(num1) + Convert.ToString(num2) + Convert.ToString(num3) +  Convert.ToString(num4);
Console.WriteLine(result);
