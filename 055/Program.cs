Console.Clear();

Console.WriteLine("Enter the hight!");
int firstNumber = int.Parse(Console.ReadLine());



    for (int i = 0; i <= firstNumber; i++)
    {
        for (int j = 0; j <= i; j++)
        {
            Console.Write("@");
        }
        Console.WriteLine();
    }
    Console.WriteLine();



    for (int l = 0; l <= firstNumber; l++)
    {
        for (int j = firstNumber; j >= l; j--)
        {
            Console.Write("@");
        }
        Console.WriteLine();
    }
    Console.WriteLine();


    
    for (int i = 0; i <= firstNumber; i++)
    {
                for (int j = firstNumber; j > i; j--)
        {
            Console.Write(" ");
        }
        for (int j = 0; j <= i; j++)
        {
        
            Console.Write("@");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    

    for (int i = 0; i <= firstNumber; i++)
    {
                for (int j = 0; j < i; j++)
        {
            Console.Write(" ");
        }
        for (int j = firstNumber; j >= i; j--)
        {
        
            Console.Write("@");
        }
        Console.WriteLine();
    }
    Console.WriteLine();