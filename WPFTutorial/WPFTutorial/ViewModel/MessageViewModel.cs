using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WPFTutorial.ViewModel
{
    class MessageViewModel
    {
        public ObservableCollection<string> MyMessage { get; private set; }
        public RelayCommand MessageBoxCommand { private set; get; }
        public RelayCommand ConsoleLogCommand { private set; get; }
        public MessageViewModel()
        {
            MyMessage = new ObservableCollection<string>()
            {
                "My Message 01",
                "My Message 02",
                "My Message 03",
                "My Message 04",
                "My Message 05",
                "is a console",
                "is a message box",

            };

            MessageBoxCommand = new RelayCommand(DisplayMessageBox, MessageBoxCanUse);
            ConsoleLogCommand = new RelayCommand(DisplayConsole, ConsoleCanUse);
        }

        public void DisplayMessageBox(object param)
        {
            MessageBox.Show((string)param);
        }

        public void DisplayConsole(object param)
        {
            Console.WriteLine((string)param);
        }

        public bool MessageBoxCanUse(object param)
        {
            if ((string)param == "is a console")
                return false;
            return true;
        }

        public bool ConsoleCanUse(object param)
        {
            if ((string)param == "is a message box")
                return false;
            return true;
        }
    }
}
