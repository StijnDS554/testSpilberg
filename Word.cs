using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testSpilberg
{
    public class Word
    {
        public Word()
        {

        }

        public string FullWord { get; set; }
        public string Word1 { get; set; }
        public string Word2 { get; set; }

        public void FindWordCombinations(List<string> words)
        {
            for (int i = 0; i < words.Count; i++)
            {
                for (int j = i + 1; j < words.Count; j++)
                {
                    if (words[i] + words[j] == FullWord )
                    {
                        Word1 = words[i];
                        Word2 = words[j];
                        return; // Found a valid combination, exit the function
                    }
                }
            }
        }
    }
}