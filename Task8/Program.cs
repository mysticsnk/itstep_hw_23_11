bool isArmstrong(int number)
{
    int sum = 0;
    int[] digits = number.ToString().Select(c => c - '0').ToArray();
    // Прикольна вещ c - '0', робить з чарів цифр ці цифри
    foreach (int n in digits)
    {
        sum += Convert.ToInt32(Math.Pow(n, digits.Length));
    }

    return number == sum;
}

int userNum = Convert.ToInt32(Console.ReadLine());

bool numIsArmstrong = isArmstrong(userNum);

switch (numIsArmstrong)
{
    case true:
        Console.WriteLine("Your number is armstrong.");
        break;
    case false:
        Console.WriteLine("Your number is not armstrong.");
        break;
}

