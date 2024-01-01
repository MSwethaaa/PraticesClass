using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraticesClass
{
    internal class Uppercase_to_Lowercase
    {
            static void Main()
            {
                string inputSentence = "TODAY IS WEDNESDAY";

                string convertedSentence = ConvertCase(inputSentence);

                Console.WriteLine("Original Sentence: " + inputSentence);
                Console.WriteLine("Converted Sentence: " + convertedSentence);
            }

            static string ConvertCase(string sentence)
            {
                char[] charArray = sentence.ToCharArray();

                for (int i = 0; i < charArray.Length; i++)
                {
                    if (char.IsUpper(charArray[i]))
                    {
                        charArray[i] = char.ToLower(charArray[i]);
                    }
                    else if (char.IsLower(charArray[i]))
                    {
                        charArray[i] = char.ToUpper(charArray[i]);
                    }
                }

                return new string(charArray);
            }
        }
    }

