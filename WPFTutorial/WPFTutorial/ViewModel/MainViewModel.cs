using System.Windows;

namespace WPFTutorial.ViewModel
{

    class MainViewModel : ObservableObject
    {
        public MainViewModel()
        {
            isVisible = true;
            
        }

        private bool isVisible;

        public bool IsVisible
        {
            get { return isVisible; }
            set
            {
                isVisible = value;
                UpdateVisibility(value);
                OnPropertyChanged("IsVisible");
            }
        }

        private Visibility visibility;
        public Visibility Visibility
        {
            get { return visibility; }
            set
            {
                visibility = value;
                OnPropertyChanged("Visibility");
            }
        }



        private void UpdateVisibility(bool isVisible)
        {
            if (isVisible)
                Visibility = Visibility.Visible;
            else
                Visibility = Visibility.Hidden;
        }
    }
}
