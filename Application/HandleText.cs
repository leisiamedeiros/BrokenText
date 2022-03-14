using System;
using System.Collections.Generic;

namespace BrokenText
{
    public static class HandleText
    {
        public static void PrintWords(IEnumerable<string> words)
        {
            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
        }

        public static IEnumerable<string> BrokeTextInLines(string text, int maxLineCharacters)
        {
            var words = text.Split(" ");

            var listOfWords = new List<string>();
            var lineWords = string.Empty;

            for (int index = 0; index < words.Length; index++)
            {
                var lineWordsLength = lineWords.Length + words[index].Length;

                if (lineWordsLength <= maxLineCharacters)
                {
                    lineWords += $"{words[index]} ";

                    if (index == (words.Length - 1))
                    {
                        listOfWords.Add(lineWords);
                    }
                }
                else
                {
                    listOfWords.Add(lineWords.Trim());
                    lineWords = $"{words[index]} ";
                }
            }

            return listOfWords;
        }
    }
}
