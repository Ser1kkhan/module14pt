using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        string text = "This is the house that Jack built. And this is the wheat that is stored in the dark closet In the house that Jack built. And this is the cheerful bird sparrow That often steals the wheat That is stored in the dark closet In the house that Jack built.";

        // Split the text into words
        string[] words = text.Split(new char[] { ' ', ',', '.', '!', '?', '-', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

        // Create a collection to store the statistics
        Dictionary<string, int> wordCount = new Dictionary<string, int>();

        // Count the occurrences of each word
        foreach (string word in words)
        {
            // Convert the word to lowercase to account for different cases
            string cleanedWord = word.ToLower();

            if (wordCount.ContainsKey(cleanedWord))
            {
                wordCount[cleanedWord]++;
            }
            else
            {
                wordCount[cleanedWord] = 1;
            }
        }

        // Display the statistics
        Console.WriteLine("Word\t\tCount");
        foreach (var pair in wordCount.OrderBy(p => p.Key))
        {
            Console.WriteLine($"{pair.Key}\t\t{pair.Value}");
            Console.ReadKey();
        }
    }
}
