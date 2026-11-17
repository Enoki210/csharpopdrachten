namespace opdracht_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Raad mijn gelukswoord ");

            string gelukswoord;
            gelukswoord = Console.ReadLine();

            string resultaat = (gelukswoord.ToUpper() == "LUCKY") ? $"{gelukswoord.ToUpper()} is het gelukswoord, goed geraden." : $"{gelukswoord.ToUpper()} is niet het gelukswoord.";

            Console.WriteLine(resultaat);
        }
    }
}
