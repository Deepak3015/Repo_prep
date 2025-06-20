using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("How Many values you want to be in you array :");
        int num = int.Parse(Console.ReadLine());

        int[] numbers = new int[num];
        for (int i = 0; i < num; i++)
        {
            Console.WriteLine("Enter your Data :");
            int Data = int.Parse(Console.ReadLine());
            numbers[i] = Data;

        }
        Console.WriteLine("==========Your Data===========");
        foreach (int item in numbers)
        {
            Console.WriteLine(item);
        }
    

    }
  
}