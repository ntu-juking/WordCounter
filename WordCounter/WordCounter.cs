using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCounter
{
    public static class WordCounter
    {

        public static WordCounterOptions Options
        {
            get;
            set;
        }

        static WordCounter()
        {
            Options = new WordCounterOptions();
        }
        

        public static Dictionary<string, int> Count(string sentense)
        {
            if (sentense == null)
            {
                return null;
            }

            if (sentense.Length == 0)
            {
                return new Dictionary<string, int>();
            }

            // if a word started
            bool wordStarted = false;

            // store word and count
            Dictionary<string, int> counts = new Dictionary<string, int>();

            // store current word's letters
            List<char> currentWordLetters = new List<char>();


            for (var i = 0; i < sentense.Length; i++)
            {
                bool wordEnd = false;
                char c = sentense[i];

                if (i == sentense.Length - 1)
                {
                    wordEnd = true;
                }

                if (!wordStarted)
                {
                    // only starts as letter can be a word
                    if (char.IsLetter(c))
                    {
                        wordStarted = true;
                        currentWordLetters.Add(c);
                    }
                }
                else
                {
                    if (char.IsLetter(c) || (char.IsDigit(c)))
                    {
                        currentWordLetters.Add(c);
                    }
                    else
                    {
                        wordEnd = true;
                    }

                }

                if (wordEnd)
                {

                    // check the letters count
                    if (currentWordLetters.Count >= Options.MinimumLetters)
                    {
                        if (Options.IgnoreNumbersAtTail)
                        {
                            // remove numbers at tail
                            for (int j = currentWordLetters.Count - 1; j >= 0; j--)
                            {
                                if (!char.IsNumber(currentWordLetters[j]))
                                {
                                    break;
                                }
                                currentWordLetters.RemoveAt(j);
                            }
                        }
                        // get the word
                        string word = new string(currentWordLetters.ToArray());
                        if (!Options.CaseSensitive)
                        {
                            word = word.ToLower();
                        }
                        // add to dictionary
                        if (!counts.ContainsKey(word))
                        {
                            counts[word] = 1;
                        }
                        else
                        {
                            counts[word]++;
                        }
                    }

                    currentWordLetters.Clear();
                    wordStarted = false;
                }
            }

            return counts;
        }

    }
}

