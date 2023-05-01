using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFTutorial.ViewModel
{
    class MainViewModels: INotifyPropertyChanged
    {
        public MainViewModels()
        {
            MakeData();
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

        private List<ViewModelData> _studentList;

        public event PropertyChangedEventHandler PropertyChanged;

        public List<ViewModelData> StudentList
        {
            set { _studentList = value; }
            get
            {
                return _studentList;
                RaisePropertyChanged("StudentList");
            }
        }
        private void MakeData()
        {
            List<ViewModelData> list = new List<ViewModelData>();
            list.Add(new ViewModelData { name = "이지원", id = "210651", major = "컴퓨터공학", grade = 1, etc = "" });
            list.Add(new ViewModelData { name = "김현호", id = "210184", major = "컴퓨터공학", grade = 1, etc = "" });
            list.Add(new ViewModelData { name = "강희진", id = "210017", major = "컴퓨터공학", grade = 1, etc = "" });
            list.Add(new ViewModelData { name = "박서준", id = "210439", major = "컴퓨터공학", grade = 1, etc = "" });
            list.Add(new ViewModelData { name = "강나연", id = "210005", major = "컴퓨터공학", grade = 1, etc = "" });
            _studentList = list;
        }

    }
}
