using System;
using System.Windows.Input;

//http://ojc.asia/bbs/board.php?bo_table=WPF&wr_id=146
namespace WPFTutorial
{
    class RelayCommand : ICommand
    {
        readonly Action<object> _execute;
        readonly Predicate<object> _canExecute;

        public RelayCommand(Action<object> execute, Predicate<object> canExecute)
        {
            if (execute == null)
                throw new NullReferenceException("non execute");

            _execute = execute;
            _canExecute = canExecute;
        }

        public RelayCommand(Action<object> execute) : this(execute, null)
        {
        }

        // CanExecuteChanged 이벤트는 해당 ICommand에 바인딩 된
        // 모든 명령 소스(예 : Button 또는 MenuItem)에
        // CanExecute에 의해 반환 된 값이 변경 되었음을 알린다.
        // 커맨드 소스는 일반적으로 상태를 적절히 업데이트해야 하는데
        // 예를 들면 CanExecute()가 false를 반환하면 버튼이 비활성화 된다).
        // CommandManager.RequerySuggested 이벤트는 CommandManager가 명령 실행에
        // 영향을 줄 수있는 변경 사항이 있다고 생각할 때마다 발생하며 이때마다
        // CanExecute가 호출된다.
        // 예를 들어, 이는 포커스의 변화 일 수 있는데. 이 이벤트가 많이 발생한다.
        // 따라서 본질적으로 이 코드의 역할은 CommandManager가 명령 실행 기능이 변경되었다고 생각할 때마다(실제로 변경되지 않은 경우에도) CanExecuteChanged를 발생시키는 것이다.
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        //CommandManager.RequerySuggested 이벤트가 호출될 때마다 실행
        //즉 CanExecuteChanged 이벤트가 호출될 때마다 실행
        public bool CanExecute(object parameter)
        {
            return _canExecute == null ? true : _canExecute(parameter);
        }

        public void Execute(object parameter)
        {
            _execute.Invoke(parameter);
        }
    }
}
