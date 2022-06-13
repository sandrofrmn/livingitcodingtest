using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextProcessor
{    

    public interface IWordCount
    {
        string Word { get; set; }
        int Count { get; set; }
    }

    public class WordCount : IWordCount
    {
        public string Word { get; set; }
        public int Count { get ;  set; }

        //public WordCount(string word, int count)
        //{
        //    Word = word;
        //    Count = count;
        //}
    }
}
