using System.ComponentModel;

namespace WPFTutorial.ViewModel
{
    class ButtonName : INotifyPropertyChanged
    {
        public ButtonName()
        {
            // 
        }

        private void RaisePropertyChanged(string propertyName)
        {
            // take a copy to prevent thread issues
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }


        private string _setButtonName;

        public event PropertyChangedEventHandler PropertyChanged;

        public string SetButtonName
        {
            set
            {
                _setButtonName = value;
            }

            get
            {
                return _setButtonName;
            }
        }
    }
}
