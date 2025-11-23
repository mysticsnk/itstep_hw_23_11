Console.WriteLine("Enter your temperature: ");
int startingTeperature = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter what you want to convert to: \n 1 -- Celsius \n 2 -- Fahrenheit");
int userChoice = Convert.ToInt32(Console.ReadLine());

int result = userChoice switch
{
    1 => (startingTeperature - 32) * 5 / 9,
    2 => startingTeperature * 9 / 5 + 32,
};

Console.WriteLine($"The result is: {result}");