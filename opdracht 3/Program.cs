namespace opdracht3

{

    internal class Program
    {

        static void Main(string[] args)

        {
            string getal = "42";
            int getal2 = int.Parse(getal);

            int resultaat = getal2 * 2;

            Console.WriteLine("Uitkomst is: " + resultaat);
            Console.ReadLine();
        }

    }
}