namespace opdracht7
{
    internal class Program
    {

        static void Main(string[] args)
        {

            Console.Write("Wat is mijn geluksgetal? ");
            ConsoleKeyInfo key = Console.ReadKey();
            Console.WriteLine();

            char geluksgetal = key.KeyChar;


            if (geluksgetal == '5')
            {
                Console.WriteLine("Correct mijn geluksgetal is 5!");

            }

            else if (char.IsDigit(geluksgetal))
            {
                Console.WriteLine(geluksgetal + " is niet correct.");

            }

            else
            {
                Console.WriteLine(geluksgetal + " kan niet, het moet een cijfer zijn.");

            }
            Console.ReadLine();

        }

    }

}