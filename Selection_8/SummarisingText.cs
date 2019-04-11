﻿using System;
using System.Collections.Generic;

namespace Selection_8
{
    public class SummarisingText
    {
        public static string SummerizeText(string text, int maxLength = 20)
        {
            if (text.Length < maxLength)
                Console.WriteLine(text);
           
                var words = text.Split(' ');
                var totalCharacters = 0;
                var summaryWords = new List<string>();

                foreach (var word in words)
                {
                    summaryWords.Add(word);
                    totalCharacters += word.Length + 1;

                    if (totalCharacters > maxLength)
                        break;
                }

                return String.Join(" ", summaryWords) + "....."; ;
        }
    }
}