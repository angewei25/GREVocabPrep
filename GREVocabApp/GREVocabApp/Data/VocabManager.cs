using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GREVocabApp.Data
{
    public class VocabManager
    {
        private Dictionary<String, String> vocabulary;

        private VocabManager() 
        {
            vocabulary = new Dictionary<string, string>();
        }

        public static void Load()
        {
            foreach (var t in vocab)
            { 

            }

        }

        private static List<Tuple<String, String>> vocab = new List<Tuple<String, String>>
        {
            //TODO: insert all the vocab to be studied here
            new Tuple<String, String>("a", "b")

        };
    }
}
