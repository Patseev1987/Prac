Console.Clear();

void doIf(double x, double y, string z)
{
    if (z == "-")
    {
        Console.WriteLine($"Do subtraction   {x} - {y} = {x - y}");
    }
    else if (z == "+")
    {
        Console.WriteLine($"Do addition   {x} + {y} = {x + y}");
    }
    else if (z == "*")
    {
        Console.WriteLine($"Do multiplication   {x} * {y} = {x * y}");
    }
    else if (z == "/")
    {
        Console.WriteLine($"Do addition   {x} + {y} = {x / y}");
    }
}

void doSwitch(double x, double y, string z)
{
    switch (z)
    {
        case "+":
            Console.WriteLine($"Do addition   {x} + {y} = {x + y}");
            break;
        case "-":
            Console.WriteLine($"Do subtraction   {x} - {y} = {x - y}");
            break;
        case "*":
            break;
            Console.WriteLine($"Do multiplication   {x} * {y} = {x * y}");
        case "/":
            Console.WriteLine($"Do addition   {x} + {y} = {x / y}");
            break;
        default:
            Console.WriteLine("You enterd wrong symbol!");
            break;
    }
}

double firstNumber, secondNumber;

Console.WriteLine("Enter the first number");
firstNumber = double.Parse(Console.ReadLine());


Console.WriteLine("Enter the second number");
secondNumber = double.Parse(Console.ReadLine());


Console.WriteLine("***************************");
Console.WriteLine("What scould i do with these numbers?");
string act = Console.ReadLine();

// doIf(firstNumber, secondNumber, act);

doSwitch(firstNumber, secondNumber, act);