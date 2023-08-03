using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using Prism.Regions;
using ModuleA.Events;
using System;

namespace dRAST3Test.ViewModels
{
    public class MainWindowViewModel : BindableBase // BindableBase 는 InotifyPropertyChanged와 동일함
    {
        private string _title = "Prism Application";

        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); } // SetProperty는 자동으로 Prism에서 InotifyPropertyChanged로 수행
        }

        private bool _isChecked;

        public bool IsChecked
        {
            get { return _isChecked; }
            set
            {
                SetProperty(ref _isChecked, value);
                //NavigateCommand.RaiseCanExecuteChanged(); // Navigate 변경 사항을 실시간으로 확인
            } // SetProperty는 자동으로 Prism에서 InotifyPropertyChanged로 수행
        }

        private DelegateCommand<string> _navigateCommand;   // ICommand
        private readonly IRegionManager _regionManager;     // region 설정
        private readonly IEventAggregator _eventAggregator; // event 설정

        // ICommand의 이름과 맞춰야 한다. "NavigateCommand" (단축어: cmdg)
        // 단축어 
        //public DelegateCommand<string> NavigateCommand =>
        //    _navigateCommand ?? (_navigateCommand = new DelegateCommand<string>(ExecuteCommandName, CanExecuteCommand).ObservesProperty(() => IsChecked));
        ////ObservesProperty(() => IsChecked) 을 사용함으로 "NavigateCommand.RaiseCanExecuteChanged();" 을 대신 할 수 있다.
        ///

        public DelegateCommand<string> NavigateCommand =>
           _navigateCommand ?? (_navigateCommand = new DelegateCommand<string>(ExecuteCommandName).ObservesCanExecute(() => IsChecked));

        private bool CanExecuteCommand(string arg)
        {
            return IsChecked;
        }

        public MainWindowViewModel(IRegionManager regionManager, IEventAggregator eventAggregator)
        {
            // 여기서 regionManager가 무엇일까?

            this._regionManager = regionManager;
            this._eventAggregator = eventAggregator;
        }

        void ExecuteCommandName(string viewName)
        {
            var p = new NavigationParameters();
            p.Add("id", 23);

            // Navigation에 parameter를 전달 할 수있다.
            _regionManager.RequestNavigate("ContentRegion", viewName, p);

            _eventAggregator.GetEvent<MessageEvent>().Publish($"Event Navigated to {viewName}"); // usercontrol에 message 전달
        }

    }
}
