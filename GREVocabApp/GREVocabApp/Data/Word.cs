using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GREVocabApp.Data
{
    public class Word
    {
        public String Word { get; private set;}
        public String Definition { get; private set;}
        public float Frequency { get; private set; }

        public Word(String word, String def)
        {
            Word = word;
            Definition = def;
            Frequency = 1.0f;
        }

        public void IncreaseFeq()
        {
            Frequency = Frequency + 0.25f;
        }

        public void DecreaseFreq()
        {
            Frequency = Frequency - 0.25f;
        }
    }
}
