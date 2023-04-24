using System.Windows.Input;

namespace WPFTutorial
{
    class MainWindowViewModel: ObservableObject
    {
        public ListViewViewModel ListView { get; set; }
        public ICommand RemoveNameCommand { get; set; }

        public MainWindowViewModel()
        {
            ListView = new ListViewViewModel();
            RemoveNameCommand = new RelayCommand<string>(RemoveName);
        }

        private void RemoveName(string name)
        {
            ListView.Names.Remove(name);
        }
    }
}
