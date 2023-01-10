Console.Clear();
int even, notEven, count;

even =0; 
notEven=0;

Console.WriteLine("Enter the first number in the range!");
int firstNumber=int.Parse(Console.ReadLine());
count=firstNumber;

Console.WriteLine("Enter the last number in the range!");
int lastNumber=int.Parse(Console.ReadLine());


while (count <= lastNumber)
{
    if (count%2==0)
    {
even++;
    }
    else
    {
        notEven++;
    }
    count++;
}

Console.WriteLine($"sum even numbers  ---   {even}");
Console.WriteLine($"sum not even numbers  ---   {notEven}");