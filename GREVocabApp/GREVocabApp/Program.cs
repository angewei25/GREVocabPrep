using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using GREVocabApp.Data;
using GREVocabApp.VM;
using GREVocabApp.Forms;

namespace GREVocabApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            VocabManager.GetInstance.Load();
            var mainVM = new MainVM();
            Application.Run(new MainForm(mainVM));
        }
    }
}
