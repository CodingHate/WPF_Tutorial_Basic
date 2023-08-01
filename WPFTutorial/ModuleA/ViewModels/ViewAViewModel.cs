using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleA.ViewModels
{
    public class ViewAViewModel : BindableBase, INavigationAware
    {

        private string _message;
        public string Message
        {
            get { return _message; }
            set { SetProperty(ref _message, value); }
        }

        public ViewAViewModel(IEventAggregator eventAggregator)
        {
            Message = "View A from your Prism Module";
        }

        public void OnNavigatedTo(NavigationContext navigationContext)
        {
            // INavigationAware 을 통하여 직전에 무엇을 수행 하였는지 알 수 있다. (후생)
        }

        public bool IsNavigationTarget(NavigationContext navigationContext)
        {
            return true;
        }

        public void OnNavigatedFrom(NavigationContext navigationContext)
        {
            // INavigationAware 을 통하여 직전에 무엇을 수행 하였는지 알 수 있다. (선행)
            Message += navigationContext.Parameters.GetValue<int>("id");

        }
    }
}
