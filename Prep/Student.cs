using System;
using System.Collections.Generic;

class Students
{
    public string Name;
    public int Roll_no;
    public int Age;
    public float Marks;

    public static int Students_Counts = 0;

    public Students(string Name, int Roll_no, int Age, float Marks)

    {
        this.Name = Name;
        this.Age = Age;
        this.Roll_no = Roll_no;
        this.Marks = Marks;
        Students_Counts++;


    }

    public Students(Students e)
    {
        this.Name = e.Name;
        this.Age = e.Age;
        this.Roll_no = e.Roll_no;
        this.Marks = e.Marks;
    }

    public void get_student_info()
    {
        Console.WriteLine($"{Name}And his And Age :{Age} Roll_no:{Roll_no} And Marks :{Marks}");

    }

   public static void Total_count()
{
    Console.WriteLine($"Total Students in the Database: {Students.Students_Counts}");
}

    }

class Program
{
    static void Main(string[] args)
    {
        List<Students> studentList = new List<Students>();
        bool Running = true;

        do
        {
            Console.WriteLine("==============Students_Managenment_System==============");
            Console.WriteLine("1. Add New Student");
            Console.WriteLine("2. View All Students");
            Console.WriteLine("3. Show Total Student Count");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");
            string input = Console.ReadLine();
            Console.WriteLine();

            switch (input)
            {
                case "1":

                    Console.Write("Enter Name: ");
                    string name = Console.ReadLine();

                    Console.Write("Enter Age: ");
                    int age = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Enter Roll No: ");
                    int roll = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Enter Marks: ");
                    float marks = float.Parse(Console.ReadLine());

                    Students newStudent = new Students(name, roll, age, marks);

                    studentList.Add(newStudent);

                    Console.WriteLine("✅ Student added successfully!");
                    break;
                case "2":

                    Console.WriteLine("All Students:");
                    foreach (Students s in studentList)
                    {
                        s.get_student_info();
                    }
                    break;

                case "3":
                    Students.Total_count();
                    break;

                case "4":
                    Running = false;
                    Console.WriteLine("Exiting The Program ======================>");
                    break;

                default:

                    Console.WriteLine("❌ Invalid choice. Please enter a number from 1 to 5.");
                    break;

            }
        }

        while (Running);

        }
    }
