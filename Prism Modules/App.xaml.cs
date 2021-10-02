using MyModule;
using Prism.Ioc;
using Prism.Modularity;
using Prism_Modules.Views;
using System.Windows;

namespace Prism_Modules
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
            moduleCatalog.AddModule<MyModuleModule>();
        }
    }
}
