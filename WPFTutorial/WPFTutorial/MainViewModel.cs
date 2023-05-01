using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFTutorial
{
     class MainViewModel : INotifyPropertyChanged
    {
        private List<Student> students = default;
        public MainViewModel()
        {
            students = Student.Students;
            mainViewModels = new ViewModel.MainViewModels();
        }

        private ViewModel.MainViewModels mainViewModels;

        public ViewModel.MainViewModels MainList
        {
            set { mainViewModels = value; }
            get
            {
                return mainViewModels;
                OnPropertyChanged("MainList");
            }
        }


        public List<Student> Students
        {
            get
            {
                return students;
            }
            set
            {
                students = value;
                OnPropertyChanged("Students");
            }
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
