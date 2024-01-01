﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraticesClass
{
    internal class TitleCase2
    {
        static void Main()
        {
            string inputSentence = "HELLO ALL,TODAY IS WED";

            string titleCaseSentence = ConvertToTitleCase(inputSentence);

            Console.WriteLine("Original Sentence: " + inputSentence);
            Console.WriteLine("Title Case Sentence: " + titleCaseSentence);
        }

        static string ConvertToTitleCase(string sentence)
        {
            TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
            string titleCaseSentence = textInfo.ToTitleCase(sentence.ToLower());

            return titleCaseSentence;
        }
    }
}
