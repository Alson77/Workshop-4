using System;

namespace Week4_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // task 1
            // Creating first student object
            Student s1 = new Student();
            s1.name = "Alson";
            s1.age = 24;
            s1.course = "BIT";

            // Creating second student object
            Student s2 = new Student();
            s2.name = "Bebish";
            s2.age = 21;
            s2.course = "BBA";

            // Displaying values of object 1
            Console.WriteLine("Student 1:");
            Console.WriteLine($"Name: {s1.name}, Age: {s1.age}, Major: {s1.course}");

            // Displaying values of object 2
            Console.WriteLine("\nStudent 2:");
            Console.WriteLine($"Name: {s2.name}, Age: {s2.age}, Major: {s2.course}");

            // Printing the static field
            Console.WriteLine($"\nSchool Name: {Student.college}");

            

            // Task2
            Console.WriteLine("\n--- Task 2 Output ---");

            Calculator calc = new Calculator();

            calc.PrintWelcome();

            int sum = calc.Add(5, 7);
            Console.WriteLine("Addition: " + sum);

            int product1 = calc.Multiply(6, 3);
            Console.WriteLine("Multiplication (6 * 3): " + product1);

            int product2 = calc.Multiply(10); // uses default value (num2 = 1)
            Console.WriteLine("Multiplication with default (10 * 1): " + product2);
            
            
            
            // TASK 3
            Console.WriteLine("\n--- Task 3 Output ---");

            ParameterDemo demo = new ParameterDemo();

            // REF example
            int value = 5;
            demo.Increase(ref value);
            Console.WriteLine("Value after Increase (ref): " + value);

            // OUT example
            demo.GetFullName(out string fullName);
            Console.WriteLine("Full Name (out): " + fullName);

            // PARAMS example
            int sumAll = demo.SumAll(1, 2, 3, 4, 5);
            Console.WriteLine("SumAll result (params): " + sumAll);

            
            
            // TASK 4
            Console.WriteLine("\n--- Task 4 Output ---");

            // Object using default constructor
            Player p1 = new Player();  
            p1.playerName = "Goblin";
            p1.level = 1;
            p1.health = 100;

            // Object using parameterized constructor
            Player p2 = new Player("Slug", 10, 150);

            // Printing all details
            Console.WriteLine("\nPlayer 1:");
            Console.WriteLine($"Name: {p1.playerName}, Level: {p1.level}, Health: {p1.health}");

            Console.WriteLine("\nPlayer 2:");
            Console.WriteLine($"Name: {p2.playerName}, Level: {p2.level}, Health: {p2.health}");
            
            
            
            // --- TASK 5 ---
            // ENUM
            Console.WriteLine("\n--- Task 5: Enum Output ---");

            Console.Write("Enter a day: ");
            string dayInput = Console.ReadLine().Trim().ToLower();

            if (dayInput == "friday" || dayInput == "saturday")
            {
                Console.WriteLine("It is: Weekend");
            }
            else
            {
                Console.WriteLine("It is: Weekday");
            }

            
            // RECORD
            Console.WriteLine("\n--- Task 5: Record Output ---");

            // Creating first book object
            Book book1 = new Book("Muna Madan", "Laxmi Prasad Devkota", 500);

            // Creating another object using 'with' expression
            Book book2 = book1 with { title = "Karnali Blues", price = 300 };

            // Printing first object
            Console.WriteLine("\nBook 1:");
            Console.WriteLine($"Title: {book1.title}, Author: {book1.author}, Price: {book1.price}");

            // Deconstructing second object
            var (title2, author2, price2) = book2;

            Console.WriteLine("\nBook 2 (After Deconstruction):");
            Console.WriteLine($"Title: {title2}, Author: {author2}, Price: {price2}");
            
            
            // --- TASK 6 ---
            Console.WriteLine("\n--- Task 6 ---");

            // Asking the user to input numbers
            Console.Write("Enter marks obtained: ");
            int marks = int.Parse(Console.ReadLine());

            Console.Write("Enter total marks: ");
            int total = int.Parse(Console.ReadLine());

           
            double percentageWrong = marks / total * 100;

            Console.WriteLine("Wrong Percentage = " + percentageWrong);
            
            double percentageCorrect = (double)marks / total * 100;

            Console.WriteLine("Correct Percentage = " + percentageCorrect);


        }
    }
}