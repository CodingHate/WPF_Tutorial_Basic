using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WPFTutorial
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName]string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public MainViewModel()
        {

        }

        private string? text1;

        public string Text1
        {
            get { return text1; }
            set { text1 = value; OnPropertyChanged(); }
        }

        private string? text2;

        public string Text2
        {
            get { return text2; }
            set { text2 = value; OnPropertyChanged(); }
        }

        public ICommand ClearCommand => new ClearCommand(this);
    }
}
