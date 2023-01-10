 void evenNumber(int x)
{
    int a = x % 2;
    if (a == 0)
    {
        Console.WriteLine("The number is even!");
    }
    else
    {
        Console.WriteLine("#######################################");
        Console.WriteLine("The number is not even!");
    }
}


Console.Clear();

double secondValue, firstValue;
int number;

Console.WriteLine("Enter the first number");
firstValue = double.Parse(Console.ReadLine());
Console.WriteLine("Enter the second number");
secondValue = Convert.ToInt32(Console.ReadLine());
double result = (firstValue + secondValue) / 2;
Console.WriteLine(result);

Console.WriteLine("Enter the number");
number = int.Parse(Console.ReadLine());

evenNumber(number);