namespace opdracht6

{

    internal class Program
    {

        static void Main(string[] args)

        {
            Console.WriteLine("Voer uw geboortjaar in ");

            int geboortejaar = int.Parse(Console.ReadLine());

            int jaar = DateTime.Now.Year;
            int leeftijd = jaar - geboortejaar;

            Console.WriteLine($"Uw leeftijd is {leeftijd} jaar.");
        }

    }

}