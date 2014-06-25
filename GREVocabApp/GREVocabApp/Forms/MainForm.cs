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
        }
    }
}
