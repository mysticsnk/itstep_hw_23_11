bool isPerfect(int number)
{
    int divisorSum = -number;

    for (int i = 1; i * i < number; i++)
    {
        if (number % i == 0)
            divisorSum += (i + number / i);
    }
    
    return divisorSum == number;
}

int userNum = Convert.ToInt32(Console.ReadLine());

bool numIsPerfect = isPerfect(userNum);

switch (numIsPerfect)
{
    case true:
        Console.WriteLine("Your number is perfect.");
        break;
    case false:
        Console.WriteLine("Your number is not perfect.");
        break;
}
