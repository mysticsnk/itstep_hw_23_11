Console.WriteLine("Enter the first boundary: ");
int firstBoundary = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the second boundary: ");
int secondBoundary = Convert.ToInt32(Console.ReadLine());

if (firstBoundary > secondBoundary)
{
    int temp = firstBoundary;
    firstBoundary = secondBoundary;
    secondBoundary = temp;
}

for (int i = firstBoundary; i <= secondBoundary; i++)
{
    if (i % 2 == 0)
        Console.Write($"{i} ");
}