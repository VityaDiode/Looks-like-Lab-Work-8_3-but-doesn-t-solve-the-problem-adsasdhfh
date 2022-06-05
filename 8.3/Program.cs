using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nr_8._3
{
    /// <summary>
    /// хахахахаххахахахаххаха
    /// хавхфхафвхвхфыахывхвыаф
    /// 0  тасков из нужных выполнено
    /// какая музыка какие вены что мне втюхали?
    /// Где итераторы??7?7?7?77
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            str S = new str();

            string s1 = "Hello World";
            S.LetterParse(s1);

            string s2 = "one, two, three, four, five";
            S.WordParse(s2);

            string s3 = "Я себе внутривенно вкалываю музыку. Тихо, без боли, поражает каждую мускулу. Это лучше, даже самого чистого воздуха. До слез пробивает и становится глухо.";
            S.SentenceParse(s3);

            Console.ReadKey();
        }
    }
}
