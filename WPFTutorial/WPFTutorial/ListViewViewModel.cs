using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WPFTutorial
{
    class ListViewViewModel
    {
        public ICommand RemoveNameCommand02 { get; set; }
        public ICommand AddNameCommand02 { get; set; }

        public ObservableCollection<string> Names { get; set; }
        public ListViewViewModel()
        {
            Names = new ObservableCollection<string>()
           {
               "Joe",
               "Jane",
               "Johen",
               "Matt"
           };

            RemoveNameCommand02 = new RelayCommand<string>(RemoveName);
            AddNameCommand02 = new RelayCommand<string>(AddName);
        }

        private void RemoveName(string name)
        {
            this.Names.Remove(name);
        }

        int count = 0;
        private void AddName(string name)
        {
            count++;
            this.Names.Add("add " + count.ToString());
        }
    }
}
