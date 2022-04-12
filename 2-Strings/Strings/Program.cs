using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            Split();

        }
        #region 1-Count Words
        static void CountWords(string a)
        {
          
            Console.WriteLine("Number of words = {0}", a.Split(' ').Length);
        }
        static void CountWords()
        {
            Console.WriteLine("please enter sentence");
            string a = Console.ReadLine();
            Console.WriteLine("Number of words = {0}", a.Split(' ').Length);
        }
        #endregion
        #region 2-Count Vowels
        static void CountVowels()
        {
            Console.WriteLine("Please enter sentence");
            string s = Console.ReadLine().ToLower();
            int v = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] =='a' || s[i] == 'e' || s[i] == 'i' || s[i] == 'u' || s[i] == 'o')
                {
                    v++;
                }
            }
            Console.WriteLine("Number of vowels = {0}", v);   
        }
        #endregion
        #region 3-Count Consonant
        static void CountConsonant()
        {
            Console.WriteLine("Please enter sentence");
            string s = Console.ReadLine().ToLower();
            int c = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != 'a' && s[i] != 'e' && s[i] != 'i' && s[i] != 'u' && s[i] != 'o' && s[i]!=' ')
                {
                    c++;
                }
            }
            Console.WriteLine("Number of consonants = {0}", c);
        }
        static void CountConsonants2()
        {
            Console.WriteLine("Please enter sentence");
            string s = Console.ReadLine().ToLower();
            int v = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'a' || s[i] == 'e' || s[i] == 'i' || s[i] == 'u' || s[i] == 'o')
                {
                    v++;
                }
            }
            int c = s.Length - v;
            Console.WriteLine("Number of consonants = {0}", c);
        }
        #endregion
        #region 4-Split
        //input string with commas
        static void Split()
        {
            Console.WriteLine("enter words to split");
            string s = Console.ReadLine();
           var words= s.Split(',');
            foreach (var item in words)
            {
                Console.WriteLine(item);
            }

        }
        //inserting commas within the string characters
        //input: word  expected output:w,o,r,d
        static void Split2()
        {
            Console.WriteLine("Please enter word");
            string s = Console.ReadLine();
            Console.WriteLine(string.Join(",",s.ToArray()));
            
        }
       
        #endregion
        #region 5-To Upper
        static void UpperCase()
        {
            Console.WriteLine("Please enter sentence");
            string s = Console.ReadLine();
            Console.WriteLine(s.ToUpper());
        }
        #endregion
    }
}
