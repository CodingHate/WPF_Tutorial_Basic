using ModuleA.ViewModels;
using ModuleA.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace ModuleA
{
    public class ModuleAModule : IModule
    {
        private readonly IRegionManager _regionManager;

        public ModuleAModule(IRegionManager regionManager)
        {
            this._regionManager = regionManager;
        }
        public void OnInitialized(IContainerProvider containerProvider)
        {
            // ContentRegion 이 Main의 MainWindow.xaml에서
            //  <ContentControl prism:RegionManager.RegionName="ContentRegion"/>
            // ContentRegion을 지정하였기 때문,

            _regionManager.RegisterViewWithRegion("ContentRegion", typeof(ViewA));

            /* 
            다음과 같은 방법이 있지만, 절대 사용하지 말라고 한다. 
            ViewA 생성자에 파라미터가 추가되면 App이 깨지는 경우가 발생된다.
            */

            //var view = containerProvider.Resolve<ViewA>();
            //_regionManager.Regions["ContentRegion"].Add(view);
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            // navigate를 위하여 등록을 수행 한다.

            containerRegistry.RegisterForNavigation<ViewA, ViewAViewModel>();
            containerRegistry.RegisterForNavigation<ViewB, ViewBViewModel>();
        }
    }
}