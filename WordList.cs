using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testSpilberg
{
    public class WordList
    {
        public WordList()
        {
            words = new List<Word>();
        }
        private List<Word> Words { get; set; }
        public List<Word> words { get { return Words; } set { Words = value; } }
        public void OrderList()
        {
            var orderedList = words.OrderBy(x => x.FullWord);
            Word lastResult = new Word();
            List<Word> result = new List<Word>();
            foreach (Word word in orderedList)
            {
                if (lastResult.Word1 == word.Word1 && lastResult.Word2 == word.Word2)
                {
                }
                else if (word.Word1 == null || word.Word2 == null)
                {
                }
                else
                {

                    result.Add(word);
                }                
            }
            words = result;
        }
    }
}
