using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFTutorial.Models;

namespace WPFTutorial.ViewModels
{
    class MainViewModels
    {
        public MainViewModels()
        {
            Items = Comboitem.Items;
        }

        public List<Comboitem> Items { set; get; }
    }
}
