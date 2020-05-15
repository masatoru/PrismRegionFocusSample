using Prism.Ioc;
using PrismRegionFocusSample.Views;
using System.Windows;
using ModuleSet;
using Prism.Modularity;

namespace PrismRegionFocusSample
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {

        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            moduleCatalog.AddModule<ModuleSet.ModuleAModule>();
        }
    }
}
