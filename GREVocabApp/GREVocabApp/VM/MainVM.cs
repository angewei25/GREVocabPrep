using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using GREVocabApp.Data;

namespace GREVocabApp.VM
{
    public class MainVM : INotifyPropertyChanged
    {
        private Vocab _curWord;

        public event PropertyChangedEventHandler PropertyChanged;

        public MainVM()
        {
            _curWord = null;
        }

        private void OnCurVocabChange()
        {
            Word = _curWord.Word;
            Definition = _curWord.Definition;
            Sentence = _curWord.Sentence;
        }

        public Vocab CurVocab
        {
            get
            {
                return _curWord;
            }
            set
            {
                if (_curWord == null || !_curWord.Equals(value))
                {
                    _curWord = value;
                    OnCurVocabChange();
                }
            }
        }

        public IList<String> Words
        {
            get
            {
                return VocabManager.GetInstance.Words.ToList();
            }
            set
            {
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("Words"));
                }
            }
        }

        public String Definition
        {
            get
            {
                if (_curWord != null) return _curWord.Definition;
                return null;
            }
            set
            {
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("Definition"));
                }
            }
        }

        public String Word
        {
            get
            {
                if (_curWord != null) return _curWord.Word;
                return null;
            }
            set
            {
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("Word"));
                }
            }
        }

        public String Sentence
        {
            get
            {
                if (_curWord != null) return _curWord.Sentence;
                return null;
            }
            set
            {
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("Sentence"));
                }
            }
        }

        public void SelectWord(String word)
        {
            CurVocab = VocabManager.GetInstance.FindVocab(word);
        }

        public void IncreaseFreq()
        {
            if(_curWord!=null)
                _curWord.IncreaseFeq();
        }
    }
}
