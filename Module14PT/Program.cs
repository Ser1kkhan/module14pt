using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        string text = "Вот дом, Который построил Джек. А это пшеница, Кото­рая в темном чулане хранится В доме, Который построил Джек. А это веселая птица­ синица, Которая часто вору­ет пшеницу, Которая в темном чулане хранится В доме, Который построил Джек.";

        
        string[] words = text.Split(new char[] { ' ', ',', '.', '!', '?', '-', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

        
        Dictionary<string, int> wordCount = new Dictionary<string, int>();

       
        foreach (string word in words)
        {
            
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

        
        Console.WriteLine("Word\t\tCount");
        foreach (var pair in wordCount.OrderBy(p => p.Key))
        {
            Console.WriteLine($"{pair.Key}\t\t{pair.Value}");
            Console.ReadKey();
        }
    }
}
