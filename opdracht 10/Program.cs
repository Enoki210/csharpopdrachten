namespace opdracht_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int counter = 0; counter <= 10; counter++)
            {
                Console.WriteLine("Counter: " + counter);
                if (counter == 3)
                {
                    counter++;
                    continue;
                }

            }
        }
    }
}
