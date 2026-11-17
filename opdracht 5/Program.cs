namespace opdracht5
{

    internal class Program
    {
        static void Main()
        {

            Console.Write("Hoe breed is de rechthoek? ");
            double breedte = double.Parse(Console.ReadLine());

            Console.Write("Hoe hoog is de rechthoek? ");
            double hoogte = double.Parse(Console.ReadLine());

            double oppervlakte = breedte * hoogte;

            Console.WriteLine(string.Format("De oppervlakte is: {0:F2}", oppervlakte));
        }

    }

}