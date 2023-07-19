using System;
using System.Windows;
using System.Windows.Input;

namespace WPFTutorial
{
    public class ClearCommand : ICommand
    {
        private MainViewModel _mainViewModel;

        public event EventHandler CanExecuteChanged;

        public ClearCommand(MainViewModel mainViewModel)
        {
            this._mainViewModel = mainViewModel;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            MessageBox.Show($"{_mainViewModel.Text1} / {_mainViewModel.Text2}");
            _mainViewModel.Text1 = "";
            _mainViewModel.Text2 = "";
        }
    }
}