namespace opdracht_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[5];

            for (int i = 0; i < num.Length; i++)
            {
                bool isValid = int.TryParse(Console.ReadLine(), out int getal);

                if (isValid)
                {
                    num[i] = getal;
                }
                else
                {
                    Console.WriteLine("Kan niet, voer een getal in.");
                    i--;
                }
            }

                foreach (int getal in num)
                {
                    Console.WriteLine(getal);
                }
            }
        }
    }
