using System;

namespace palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = "0100109";  //Here we write the word or number
            Console.WriteLine(IsPalindrome(word)); //Make and show the result 
            Console.ReadKey(); 
        }

      
        private static string IsPalindrome(string word_1)
        {
            word_1 = word_1.Trim(); // trim the space (in just in case)
            string word_2 = ""; // it'll save the other way around word
            string resp = "NO"; // this is the value to return

            //I iterate word_1 starting from back to front and save it in word_2
            for (int i = word_1.Length-1; i >= 0; i--)
            {
                word_2 += word_1[i];
            }

            
            if(word_2 == word_1)
            {
                resp = "SI";
            }

            return resp;
        }
    }
}
