namespace Calculator_app
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Simple Calculator");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.WriteLine("5. Exit");
            

            while (true)
            {

                Console.Write("Enter your choice (1-5): ");
                int choice=int.Parse(Console.ReadLine());

                if(choice == 5)
                {
                    Console.WriteLine("Thank you for using the calculator. Goodbye!");
                }
                Console.WriteLine("enter first number");
                double a=double.Parse(Console.ReadLine());
                Console.WriteLine("enter second number");
                double b = double.Parse(Console.ReadLine());
                double result = 0;

                switch (choice) {
                    case 1:
                        result = a + b;
                        Console.WriteLine($"Result: {a} + {b} = {result}");
                        break;
                    case 2:
                        result = a - b;
                        Console.WriteLine($"Result: {a} + {b} = {result}");
                        break;
                    case 3:
                        result = a * b;
                        Console.WriteLine($"Result: {a} + {b} = {result}");
                        break;
                    case 4:
                        if (b != 0)
                        {
                            result = a / b;
                            Console.WriteLine($"Result: {a} + {b} = {result}");
                        }
                        else
                        {
                            Console.WriteLine("Error: Division by zero is not allowed");
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again");
                        break;

                }
            }

        }
    }
}
