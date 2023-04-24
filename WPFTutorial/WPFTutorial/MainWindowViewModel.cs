using System.Windows.Input;

namespace WPFTutorial
{
    class MainWindowViewModel: ObservableObject
    {
        public ListViewViewModel ListViewModel { get; set; }
        public ICommand RemoveNameCommand { get; set; }

        public MainWindowViewModel()
        {
            ListViewModel = new ListViewViewModel();
            RemoveNameCommand = new RelayCommand<string>(RemoveName);
        }

        private void RemoveName(string name)
        {
            ListViewModel.Names.Remove(name);
        }
    }
}
