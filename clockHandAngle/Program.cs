short hour, minute;

/*
    Self-made Formula for getting the angle between clock hands
    Shorter Formula: (hour - (11/60)*minutes) * 30
    
    Convert minutes to its equivalent hour value
    Then compute the distance between hands through numbers used for Hour
    Then multiply it by 30 since every 3 hours is 90 degrees.
*/
double computeAngle(int hour, int minutes)
{

    double angle = (hour + minutes / 60.0 - minutes / 5.0) * 30.0;
    angle = Math.Round(angle, 2);
    angle = angle < 0 ? -angle : angle;

    // Get the smaller angle
    angle = angle > 180 ? 360 - angle : angle;
    return angle;

}

// Validate user inputs for Hour [0-24]
while (true)
{
    Console.Write("Hour: ");
    if (Int16.TryParse(Console.ReadLine(), out hour))
    {
        if (hour < 0 || hour > 24)
        {
            Console.WriteLine("Invalid number for Hour");
            continue;
        }

        else if (hour > 12)
        {
            hour -= 12;
        }

        break;
    }

    else
    {
        Console.WriteLine("Invalid input for Hour");
    }
}

// Validate user input for Minute [0-59]
while (true)
{
    Console.Write("Minute: ");

    if (Int16.TryParse(Console.ReadLine(), out minute))
    {
        if (minute < 0 || minute > 59)
        {
            Console.WriteLine("Invalid number for Minute");
            continue;
        }

        break;
    }
}

var angle = computeAngle(hour, minute);
string formattedHour = hour.ToString("00");
string formattedMinute = minute.ToString("00");
Console.WriteLine($"\n\n\tThe current time is {formattedHour}:{formattedMinute}");
Console.WriteLine($"\tThe angle between the Hour hand and Minute hand is {angle} degrees");



string foxSentence = "The quick brown fox jumps over the lazy dog.";

char[] message = foxSentence.ToCharArray();
Array.Reverse(message);

int count = 0;

foreach (char letter in message)
{
    if (letter == 'o') { count++; }
}

string newMessage = new String(message);
Console.WriteLine(newMessage);
Console.WriteLine($"'o' appears {count} times.");