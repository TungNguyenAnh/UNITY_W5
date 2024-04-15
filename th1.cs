double fahrenheit;
double celcius;
int choice;

do
{
    System.Console.WriteLine("Menu: ");
    System.Console.WriteLine("1. Fahrenheit to Celsius");
    System.Console.WriteLine("2. Celsius to Fahrenheit");
    System.Console.WriteLine("0. Exit");
    System.Console.WriteLine("Enter ya choice: ");
    choice = Int32.Parse(Console.ReadLine());

    switch (choice)
    {
        case 1:
            System.Console.WriteLine("Enter fahrenheit: ");
            fahrenheit = double.Parse(Console.ReadLine());
            System.Console.WriteLine("Fahrenheit to Celsius: " + FahrenheitToCelsius(fahrenheit));
            break;

        case 2:
            System.Console.WriteLine("Enter celsius: ");
            celcius = double.Parse(Console.ReadLine());
            System.Console.WriteLine("Celsius to Fahrenheit: " + CelsiusToFahrenheit(celcius));
            break;

        case 0:
            break;

        default:
            System.Console.WriteLine("Invalid choice");
            break;


    }
} while (choice != 0);


static double CelsiusToFahrenheit(double celcius)
{
    double fahrenheit = (9.0 / 5) * celcius + 32;
    return fahrenheit;
}

static double FahrenheitToCelsius(double fahrenheit)
{
    double celcius = (5.0 / 9) * (fahrenheit - 32);
    return celcius;
}