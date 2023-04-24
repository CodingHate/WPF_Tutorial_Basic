using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WPFTutorial
{
    class RelayCommand<T> : ICommand
    {
        readonly Action<T> _execute = null;
        public RelayCommand(Action<T> execute)
        {
            _execute = execute; // ?? throw new ArgumentNullException(nameof(execute));
        }
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }
        public void Execute(object parameter)
        {
            _execute((T)parameter);
        }
    }
}
