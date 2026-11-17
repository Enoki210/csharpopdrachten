namespace opdracht_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wilt U een 1: klein, 2: medium, of 3: groot drankje?");
            int keuze = int.Parse(Console.ReadLine());

            switch (keuze)
            {
                case 1:
                    Console.WriteLine("Dit wordt dan 2,00 euro ");
                    break;
                case 2:
                    Console.WriteLine("Dit wordt dan 2,50 euro ");
                    break;
                case 3:
                    Console.WriteLine("Dit wordt dan 3,00- euro ");
                    break;
                default:
                    Console.WriteLine("Dit staat niet op de kaart, kies van de bovenstaande opties.");
                    break;
            }
            Console.ReadLine();
        }
    }
}
