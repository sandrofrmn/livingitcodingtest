using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextProcessor
{    
    public interface IWordCountAnalyser
    {
        int CalculateHighestWordCount(string text);
        int CalculateWordCount(string text, string word);
        List<IWordCount> GetMostCountedWords(string text, int top);
    }
    public class WordCountAnalyser : IWordCountAnalyser
    {
        public int CalculateHighestWordCount(string text) {
            text = text.ToLower();
            int count = 0;
            List<string> list = text.Split(' ').ToList();
            list.Sort();
            Dictionary<string, int> wordsWithCounts = new Dictionary<string, int>();
            for (int i = 0; i < list.Count; i++)
            {
                if (i == 0)
                {
                    count++;
                    if (list[i] != list[i + 1])
                    {
                        wordsWithCounts.Add(list[i], count);
                        count = 0;
                    }
                }
                else if (i > 0 && i < (list.Count - 1))
                {
                    if (list[i] == list[i + 1])
                    {
                        count++;
                    }
                    else if (list[i] == list[i - 1] && list[i] != list[i + 1])
                    {
                        count++;
                        wordsWithCounts.Add(list[i], count);
                        count = 0;
                    }
                    else
                    {
                        if (count == 0)
                        {
                            count++;
                        }
                        wordsWithCounts.Add(list[i], count);
                        count = 0;
                    }
                }
                else
                {
                    count++;
                    wordsWithCounts.Add(list[i], count);
                }

            }
            foreach (KeyValuePair<string, int> t in wordsWithCounts)
            {
                Console.WriteLine(t.Key + " " + t.Value);
            }
            int result = wordsWithCounts.Aggregate((l, r) => l.Value > r.Value ? l : r).Value;
            return result;
        }

        public int CalculateWordCount(string text, string word)
        {
            WordCount wordCount = new WordCount
            {
                Word = word
            };
            text = text.ToLower();
            List<string> TestList = text.Split(' ').ToList();
            int index = TestList.IndexOf(word);

            while (index >= 0)
            {
                index = TestList.IndexOf(word);
                if (index < 0)
                {
                    break;
                }
                wordCount.Count++;
                TestList.RemoveAt(index);
            }
            return wordCount.Count;
        }

        public List<IWordCount> GetMostCountedWords(string text, int top)
        {
            List<IWordCount> wordCountList = new List<IWordCount>();
            List<string> words = text.Split(' ').ToList();
            List<int> counts = new List<int>();
            for(int word = 0; words.Distinct.Count ; word++)
            {

            }
            for(int i = 0; i < counts.Count; i++)
            {
                wordCountList.Add(new WordCount { 
                    Word = words[i],
                    Count = counts[i]
                });
            }

            foreach (IWordCount wordCountItem in wordCountList.OrderBy(x => x.Count))
                Console.WriteLine(wordCountItem);
            //foreach (var item in wordCountList)
            //{
            //    Console.WriteLine(item.Word);
            //    Console.WriteLine(item.Count);
            //}
            //Console.WriteLine(wordCountList.Count());
            return wordCountList;
        }
    }
}
