Console.WriteLine("Enter your number:");
int userNum = Convert.ToInt32(Console.ReadLine());
if (userNum < 0 || userNum > 100)
{
    Console.WriteLine("Invalid number.");
    Environment.Exit(-1);
}

string output = "";

if (userNum % 3 == 0) {
    output += "fizz";
} 
if (userNum % 5 == 0) {
    output += "buzz";
}

if (output != "") {
    Console.WriteLine(output);
} else {
    Console.WriteLine(userNum);
}