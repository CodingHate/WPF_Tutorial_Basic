namespace WPFTutorial.ViewModels
{
    class PersonViewModel : ObservableObject
    {
        public PersonViewModel()
        {

        }

        private string _name;

        public string Name
        {
            get
            {
                if (string.IsNullOrEmpty(_name))
                    return "Unkown";
                return _name;
            }
            set { 
                _name = value;
                OnPropertyChanged("Name");
            }
        }

    }
}
