Console.WriteLine("Enter your number: ");
string userNum = Console.ReadLine();

if (userNum.Length != 6 || !userNum.All(char.IsDigit))
{
    Console.WriteLine("Invalid input.");
    Environment.Exit(-1);
}

char[] digits = userNum.ToCharArray();

Console.WriteLine("Enter the first digit to swap: ");
int firstToSwap = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the second digit to swap: ");
int secondToSwap = Convert.ToInt32(Console.ReadLine());

char temp = digits[firstToSwap - 1];
digits[firstToSwap - 1] = digits[secondToSwap - 1];
digits[secondToSwap - 1] = temp;

userNum = new string(digits);

Console.WriteLine(userNum);