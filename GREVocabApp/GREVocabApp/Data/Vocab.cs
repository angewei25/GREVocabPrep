using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GREVocabApp.Data
{
    public class Vocab
    {
        public String Word { get; private set;}
        public String Definition { get; private set;}
        public String Sentence { get; private set; }
        public float Frequency { get; private set; }

        public Vocab(String word, String def, String sentence)
        {
            Word = word;
            Definition = def;
            Sentence = sentence;
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
