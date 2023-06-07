using System;

namespace CSharpBasics.Excercises
{
    public class FileExcercises
    {
        public static void Excercise0102()
        {
            string path = @"C:\Users\Nazmul\Desktop\FileTest.txt";
            try
            {
                var longestWord = "";
                if(File.Exists(path))
                {
                    string text = File.ReadAllText(path);
                    string[] words = text.Split(new[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
                    foreach(var word in words)
                    {
                        if (longestWord.Length < word.Length)
                            longestWord = word;
                    }
                    Console.WriteLine(longestWord);
                    Console.WriteLine(words.Length);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " +ex.Message);
            }
        }
    }
}
