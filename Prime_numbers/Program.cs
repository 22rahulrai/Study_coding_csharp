namespace Prime_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a no: ");

            int n = Convert.ToInt32(Console.ReadLine());

            //or 

            //int n=int.Parse(Console.ReadLine());

            if (isprime(n))
            {
                Console.WriteLine(n + " is a prime number");
            }
            else
            {
                Console.WriteLine(n + " is not a prime number");
            }
        }

        public static bool isprime(int n)
        {
            if (n <= 1)
            {
                return false;
            }

            for (int i = 2; i < Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}



