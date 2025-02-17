namespace Coditional_Statements
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = 20;
            int m = 15;

            if (n < m)
            {
                Console.WriteLine("n is less than m");
            }
            else if (n == m)
            {
                Console.WriteLine();
            }
            else {
                Console.WriteLine("n is greater than m");
            }

        }
    }
}
