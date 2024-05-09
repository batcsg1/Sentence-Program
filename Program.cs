// Samuel Batchelor


namespace LAB14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sentence = " the quick brown fox jumps over the lazy dog ";

            string hair = "hairy ", finalSent = "";
            Console.BackgroundColor = ConsoleColor.Green;

            string newsent = sentence.Insert(11, hair);
            newsent = newsent.Replace("dog", "chicken");
            newsent = newsent.Trim();
            Console.WriteLine("" + newsent + "");
            string[] splitsent = newsent.Split(' ');



            foreach (string word in splitsent)
            {



                finalSent = finalSent + (word[0].ToString().ToUpper() + word.Substring(1) + ' ');





            }
            finalSent = finalSent.Trim();
            Console.WriteLine(finalSent);


            Console.ReadLine();
        }
    }
}
