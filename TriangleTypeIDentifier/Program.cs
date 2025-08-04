Console.WriteLine("Enter the three sides of the triangle separated by commas (e.g., 3,4,5):");

string[] parts = Console.ReadLine().Split(',');

if (parts.Length == 3 &&
    double.TryParse(parts[0], out double a) &&
    double.TryParse(parts[1], out double b) &&
    double.TryParse(parts[2], out double c))
{
    if (a == b && b == c)
    {
        Console.WriteLine("Equilateral");
    }
    else if (a == b || b == c || a == c)
    {
        Console.WriteLine("Isosceles");
    }
    else
    {
        Console.WriteLine("Scalene");
    }
}
else
{
    Console.WriteLine("Invalid input");
    Console.WriteLine("Three numbers, separated by commas. That’s it. Not rocket science.");
}
