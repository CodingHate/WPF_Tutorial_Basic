using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace WPFTutorial.ViewModels
{
    class MainViewModel
    {
        public PersonViewModel Person { set; private get; }
        public BackgroundViewModel Background { set; private get; }

        public MainViewModel()
        {
            Person = new PersonViewModel();
            Background = new BackgroundViewModel();
        }

        public void SetBackground(Brush brushColor)
        {
            Background.Color = brushColor;
        }
    }
}
