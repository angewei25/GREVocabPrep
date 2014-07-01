using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GREVocabApp.VM;

namespace GREVocabApp.Forms
{
    public partial class MainForm : Form
    {
        private MainVM _vm;

        public MainForm(MainVM vm)
        {
            _vm = vm;

            InitializeComponent();

            SetBinds();
        }

        private void SetBinds()
        {
            listBoxWords.DataSource = _vm.Words;
            textBoxWord.DataBindings.Add("Text", _vm, "Word", true, DataSourceUpdateMode.OnPropertyChanged, "");
            textBoxDefinition.DataBindings.Add("Text", _vm, "Definition", true, DataSourceUpdateMode.OnPropertyChanged, "");
            textBoxSentence.DataBindings.Add("Text", _vm, "Sentence", true, DataSourceUpdateMode.OnPropertyChanged, "");
        }

        private void listBoxWords_SelectedValueChanged(object sender, EventArgs e)
        {
            _vm.SelectWord((String)listBoxWords.SelectedItem);
        }

        private void buttonIncFreq_Click(object sender, EventArgs e)
        {
            _vm.IncreaseFreq();
        }
    }
}
