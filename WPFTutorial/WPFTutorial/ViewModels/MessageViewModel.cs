using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WPFTutorial.ViewModels.Commands;

namespace WPFTutorial.ViewModels
{
    class MessageViewModel
    {
        public string MessageText { set; get; }
        public MessageCommand DisplayMessageCommand { private set; get; }
        public MessageViewModel()
        {
            DisplayMessageCommand = new MessageCommand(DisplayMessage);
        }

        public void DisplayMessage()
        {
            MessageBox.Show(MessageText);
        }
    }
}
