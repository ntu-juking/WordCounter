using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCounter
{
    public class WordCounterOptions
    {
        public WordCounterOptions()
        {
            this.CaseSensitive = false;
            this.IgnoreNumbersAtTail = true;
            this.MinimumLetters = 4;
        }

        public bool CaseSensitive
        {
            get;
            set;
        }

        public bool IgnoreNumbersAtTail
        {
            get;
            set;
        }

        public int MinimumLetters
        {
            get;
            set;
        }
    }
}
