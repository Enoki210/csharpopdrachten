namespace opdracht_11
{
    internal class Program
{
    static void Main(string[] args)
    {
            Console.WriteLine("Kies menu 1, 2 of 3 om af te sluiten");
            string optie = "";

        do
        {
            optie = Console.ReadKey().KeyChar.ToString();

            switch (optie)
            {
                case "1":
                    Console.WriteLine();
                    Console.WriteLine("menu 1");
                    break;
                case "2":
                    Console.WriteLine();
                    Console.WriteLine("menu 2");
                    break;
                case "3":
                    Console.WriteLine();
                    Console.WriteLine("afsluiten...");
                    break;
                default:
                    Console.WriteLine();
                    Console.WriteLine("geen geldige optie");
                    break;
            }
        } while (optie != "3");
    }
}
}