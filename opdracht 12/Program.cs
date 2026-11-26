namespace opdracht_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] naam = new string[5];
            naam[0] = Console.ReadLine();
            naam[1] = Console.ReadLine();
            naam[2] = Console.ReadLine();
            naam[3] = Console.ReadLine();
            naam[4] = Console.ReadLine();

            foreach (string n in naam)
            {
                Console.WriteLine(n);
            }
        }
    }
}
