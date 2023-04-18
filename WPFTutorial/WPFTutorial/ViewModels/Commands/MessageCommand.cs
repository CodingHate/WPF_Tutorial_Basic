using System;
using System.Windows.Input;

namespace WPFTutorial.ViewModels.Commands
{
    class MessageCommand : ICommand
    {
        private Action _execute;
        public event EventHandler CanExecuteChanged;

        public MessageCommand(Action execute)
        {
            _execute = execute;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _execute.Invoke();
        }
    }
}
