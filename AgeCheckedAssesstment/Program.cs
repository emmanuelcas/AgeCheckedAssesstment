using System;

namespace AgeCheckedAssesstment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            Console.WriteLine(CalculateWordScore("Hello"));
            Console.WriteLine("HELLO");
            Console.WriteLine(CalculateWordScore("HELLO"));
            Console.WriteLine("Hello World");
            Console.WriteLine(CalculateWordScore("Hello World"));

            


        }


        public static int CalculateWordScore(string word)
        {
            int result = 0;
            for (var i = 0; i < word.Length; i++)
            {
                if ((word[i] >= 97 && word[i] <= 122))
                {
                    result = result + ((int)word[i]-96);
                }
                else
                {
                    //Here i could have used everything as lowcase instead of doing a second if
                    //but this way is slightly more efficient
                    if ((word[i] >= 65 && word[i] <= 90))
                    {
                        result = result + ((int)word[i] - 64);
                    }
                    else
                    {
                        return -1;
                    }
                }
            }
            return result;
        }



    }
}
