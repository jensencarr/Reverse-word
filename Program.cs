using System.Text.RegularExpressions;

namespace Reverse_word
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Console.Write("Ange en sträng: ");
            string input = Console.ReadLine();
            input = input.ToLower();                    

            char[] charReverse = input.ToCharArray();
            Array.Reverse(charReverse);
            string reversed = new string(charReverse);
            

            Console.WriteLine("Omvänd sträng: " + reversed);

            if (reversed == input)
            {
                Console.WriteLine("Detta är ett palindrom.");
            }
            else
            {
                Console.WriteLine("Detta är inte ett palindrom.");
            */

            string input = Console.ReadLine().ToLower(); // hej.


            string cleaned = string.Empty;

            char[] filter = { '.', ' ', '!', '?', ',' };

            foreach (var l in input)
            {
                if (!filter.Contains(l))
                {
                    cleaned += l; //hej
                }
            }

            string reversed = string.Empty;

            for (int i = cleaned.Length - 1; i >= 0; i--)
            {
                reversed += cleaned[i];
            }
            // jeh

            if (cleaned == reversed)
            {
                Console.WriteLine("Its a palindrome");
            }
            else
            {
                Console.WriteLine("It's not a palindrome");
            }



        }

    }
    
}