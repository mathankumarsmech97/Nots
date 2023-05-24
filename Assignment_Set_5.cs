using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Programes
{
    public class Assignment_Set_5
    {
        public static void countNoOfWords()
        {
            int count = 0, count2 = 0;

            string str = "Tod ay";

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != ' ')
                {
                    count2++;
                }

            }
            Console.WriteLine(count2);

        }
        public static void countWordsvowelsandConsonats()
        {
            string str = "Aravind";
           int vCount = 0;
            int cCount = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'a' || str[i] == 'e' || str[i] == 'i'||str[i] == 'o'||str[i] == 'u')
                {
                    vCount++;
                }
                else
                {
                    cCount++;
                }

            }
            Console.WriteLine("Vowelse count" + vCount + "\n" + "Consonats count" + cCount);
        }
        public static void bothStringAreAnagrams()
        {
            string str1 = "silent";
            string str2 = "listen";


            char[] c1 = str1.ToLower().ToCharArray();
            char[] c2 = str2.ToLower().ToCharArray();


            Array.Sort(c1);
            Array.Sort(c2);


            string val1 = new string(c1);
            string val2 = new string(c2);



            if (val1 == val2)
            {
                Console.WriteLine("The Both string are Anagrams");
            }
            else
            {
                Console.WriteLine("Both string are not anagram");
            }

        }

        public static void splitString()
        {
            string phrase = "The quick brown fox jumps over the lazy dog.";
            string[] words = phrase.Split(' ');

            foreach (var word in words)
            {
                System.Console.WriteLine($"<{word}>");
            }
            char[] delimiterChars = { ' ', ',', '.', ':', '\t' };

            string text = "one\ttwo :,five six seven";
            System.Console.WriteLine($"Original text: '{text}'");

            string[] words1 = text.Split(delimiterChars);
            System.Console.WriteLine($"{words1.Length} words in text:");

            foreach (var word in words)
            {
                System.Console.WriteLine($"<{word}>");
            }
        }


        public static void substring()
        {
            string str = "This new year is very fun and joy to me";

            string str1 = str.Substring(0, 7);

            Console.WriteLine(str1);





        }

    }
}
