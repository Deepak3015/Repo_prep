using System;
using System.Security.Claims;

class Cars
{
    public string Model;
    public double Price;
    public static int total_car = 0;

    public Cars(string model, double price)
    {
        Model = model;
        Price = price;
        total_car++;

    }

    public void Show_car_detail()
    {
        Console.WriteLine($"Model :{Model},Price :{Price}");
    }

    public static void Show_total_car()
    {
        Console.WriteLine($"Total cars :{total_car}");
    }
}

class Entry {

    static void Main()
    {
        Cars car1 = new Cars("Honda", 2000.23);
        Cars car2 = new Cars("Toyata", 52220.20);

        car1.Show_car_detail();
        Cars.Show_total_car();
    }
    
}
