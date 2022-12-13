void Zadacha25()
{

    Console.Write("enter number A->");
    int numberA = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    Console.Write("enter number B->");
    int numberB = Convert.ToInt32(Console.ReadLine());
    
    int sum = 1;
    int counter = 1;
    while(counter <= numberB)
    {
        sum = sum * numberA;
        Console.Write($"{sum}*{numberA} = ");
        
        Console.WriteLine(sum);
        counter++;
        
    }
    Console.WriteLine("answer: "+ sum);
}

Zadacha25();