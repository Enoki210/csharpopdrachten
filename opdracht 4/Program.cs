namespace opdracht4

{

    internal class Program
    {

        static void Main(string[] args)

        {

            int getal = 3;
            getal = int.Parse(Console.ReadLine());

            if (getal >= 1 && getal <= 5)

            {
                Console.WriteLine("Het getal ligt erbinnen");
            }

            else
            {
                Console.WriteLine("Het getal zit erbuiten");
            }
        }

    }

}