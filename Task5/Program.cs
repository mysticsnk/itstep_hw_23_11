string date = Console.ReadLine();

int[] dateInfo = date.Split('.').Select(int.Parse).ToArray();

int day = dateInfo[0];
int month = dateInfo[1];
int year = dateInfo[2];

string season = month switch
{
    12 or 1 or 2 => "Winter",
    3 or 4 or 5 => "Spring",
    6 or 7 or 8 => "Summer",
    9 or 10 or 11 => "Autumn",
    _ => "Unknown"
}; // ОООООО мені побається цей світч кейс він гарний 

if (month == 1 || month == 2)
{
    month += 12;
    year--;
}

int K = year % 100;
int J = year / 100;

int dayNumber = (day + (13*(month+1))/5 + K + K/4 + J/4 + 5*J) % 7;

string dayText = dayNumber switch
{
    0 => "Saturday",
    1 => "Sunday",
    2 => "Monday",
    3 => "Tuesday",
    4 => "Wednesday",
    5 => "Thursday",
    6 => "Friday",
    _ => "Unknown"
};

Console.WriteLine(season + " " + dayText);