using System;

namespace Test{
    public static class Program
    {

        static void Main(string[] args)
        {
            string banWord1 = "Ugly";
            string banWord2 = "Negative";
            string banWord3 = "bad";

            string content = "That car is ugly";

            int badWords = 0;
            if (content.Contains(banWord1))
            {
                badWords = badWords + 1;
            }
            if (content.Contains(banWord2))
            {
                badWords = badWords + 1;
            }
            if (content.Contains(banWord3))
            {
                badWords = badWords + 1;
            }

            Console.WriteLine("Would you like to add a negative word?");
            Console.ReadLine("Yes", "No");

            string newWord;

            if (Console.Contains("Yes"))
            {
                Console.WriteLine("Enter your new word: ");
                Console.ReadLine(newWord);
                String newWord = banWord4;
                if (content.Contains(banWord4))
                {
                    badWords = badWords + 1;
                }
            }
            else
            {
                Console.WriteLine("Text Scanned: ");
                Console.WriteLine(content);
                Console.WriteLine("There are " + badWords + " negative words");

                Console.WriteLine("Press ANY key");
                Console.ReadKey();
            }
            
            ArrayList allBadwords = new ArrayList(banWord1, banWord2, banWord3, banWord4);
            
            foreach (string badWords in allBadwords)
            {
                string replacement = allBadwords[0].ToString() + new string('#' + badWords.Length - 2) + badWords[badWords.Length - 1].ToString();
            }
            return content;
    }

}

}