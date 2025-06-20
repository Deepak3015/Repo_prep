// using System;
// using System.Security.Claims;

// class Cars
// {
//     public string Model;
//     public double Price;
//     public static int total_car = 0;

//     public Cars(string model, double price)
//     {
//         Model = model;
//         Price = price;
//         total_car++;

//     }

//     public void Show_car_detail()
//     {
//         Console.WriteLine($"Model :{Model},Price :{Price}");
//     }

//     public static void Show_total_car()
//     {
//         Console.WriteLine($"Total cars :{total_car}");
//     }
// }

// class Entry {

//     static void Main()
//     {
//         Cars car1 = new Cars("Honda", 2000.23);
//         Cars car2 = new Cars("Toyata", 52220.20);

//         car1.Show_car_detail();
//         Cars.Show_total_car();
//     }

// }

using System;

class Program
{
    public static void Add_number(int a, int b)
    {
        int result = a + b;
        Console.WriteLine($"The result is: {result}");
    }

    public static void Subtract_number(int a, int b)
    {
        int result = a - b;
        Console.WriteLine($"The result is: {result}");
    }

    public static void Multiply_number(int a, int b)
    {
        int result = a * b;
        Console.WriteLine($"The result is: {result}");
    }

    public static void Divide_number(int a, int b)
    {
        double result = (double)a / b;
        Console.WriteLine($"The result is: {result}");
    }

    static void Main(string[] args)
    {
        string opt;

        do
        {
            Console.Write("Enter your first number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter your second number: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("\nChoose your operator (+, -, *, /): ");
            string op = Console.ReadLine();

            switch (op)
            {
                case "+":
                    Add_number(num1, num2);
                    break;
                case "-":
                    Subtract_number(num1, num2);
                    break;
                case "*":
                    Multiply_number(num1, num2);
                    break;
                case "/":
                    Divide_number(num1, num2);
                    break;
                default:
                    Console.WriteLine("Invalid operator!");
                    break;
            }

            Console.Write("\nDo you want to perform another calculation? (yes/no): ");
            opt = Console.ReadLine().ToLower();

        } while (opt == "yes");

        Console.WriteLine("Thanks for using the calculator!");
    }
}
