using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace WPFTutorial.ViewModel
{
    internal class ViewModelData
    {
        public ViewModelData()
        {
        }
        public string name { get; set; }
        public string id { get; set; }
        public string major { get; set; }
        public int grade { get; set; }
        public string etc { get; set; }
    }

}
