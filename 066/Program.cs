Console.Clear();

void  sum (int[] mArray)
{
    int sum1=0;
    for (int k = 0; k < mArray.Length; k++)
    {
        if (mArray[k]%2==0)
        {
            sum1=sum1+mArray[k];
        }
    }
    System.Console.WriteLine("#################################");
    System.Console.WriteLine($"Sum is {sum1}");
}

void least (int [] smtArray)
{
    int min=smtArray[0];
    for (int o = 0; o < smtArray.Length; o++)
    {
        if (smtArray[o]<min)
        {
            min=smtArray[o];
        }
    }
    System.Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@");
    System.Console.WriteLine($"The least number in array is  {min}");
}

System.Console.WriteLine("Enter 5 numbers:");

int[] myArray2 = new int [5];
for (int j = 0; j < myArray2.Length; j++)
{
    myArray2[j]= int.Parse(Console.ReadLine());
}


System.Console.WriteLine("**********************************");



for (int i = (myArray2.Length-1); i >= 0; i--)
{
    Console.WriteLine(myArray2[i]);
}

sum (myArray2);
least (myArray2);