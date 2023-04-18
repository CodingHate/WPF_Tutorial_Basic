using System.Windows.Media;

namespace WPFTutorial.ViewModels
{
    class BackgroundViewModel : ObservableObject
    {
        public BackgroundViewModel()
        {

        }

        private Brush _color;

        public Brush Color
        {
            get
            {
                if (_color == null)
                    return Brushes.Red;
                return _color;
            }
            set
            {
                _color = value;
                OnPropertyChanged("Color");
            }
        }



    }
}
