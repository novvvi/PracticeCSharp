using System;
using System.Linq;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            String Post = "this is the longest string that you ever see...";
            var shortenedPost = Post.Shorten(5);
            Console.WriteLine(shortenedPost);
        }
    }

    public static class StringExt
    {
        public static string Shorten(this String str, int numberOfWords)
        {
            if(numberOfWords == 0)
                return "";

            var words = str.Split(" ");

            if (words.Length <= numberOfWords)
                return str;

            return String.Join(" ", words.Take(numberOfWords));

        }
    }
}
