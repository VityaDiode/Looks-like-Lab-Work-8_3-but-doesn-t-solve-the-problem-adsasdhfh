using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nr_8._3
{
    public class str
    {

        public void LetterParse(string s1)
        {
            foreach (char element in s1)
            {
                Console.WriteLine(element);
            }
        }

        public void WordParse(string s2)
        {
            char[] delimiterChars = { ' ', '?', ',', '.', '/', ':', ';', '!', '+', '-' };
            string[] words = s2.Split(delimiterChars);
            foreach (string element in words)
            {
                Console.WriteLine(element);
            }

        }

        public void SentenceParse(string s3)
        {
            char delimiterChars = '.';
            string[] words = s3.Split(delimiterChars);
            foreach (string element in words)
            {
                Console.WriteLine(element);
            }

        }
    }
}
