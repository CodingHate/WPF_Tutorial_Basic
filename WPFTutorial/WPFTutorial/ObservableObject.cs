using System.ComponentModel;

namespace WPFTutorial
{
    class ObservableObject : INotifyPropertyChanged
    {
        public ObservableObject()
        {

        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
