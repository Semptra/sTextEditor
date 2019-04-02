using System.Configuration;
using System.Windows.Forms;
using ReactiveUI;
using Splat;
using sTextEditor.Repositories;
using sTextEditor.ViewModels;
using sTextEditor.Views;

namespace sTextEditor
{
    public class Bootstrapper
    {
        public Bootstrapper()
        {
            ConfigureServices();
        }

        private void ConfigureServices()
        {
            Locator.CurrentMutable.Register(() => new ShellView(), typeof(IViewFor<ShellViewModel>));
            Locator.CurrentMutable.Register(() => new TextEditorView(), typeof(IViewFor<TextEditorViewModel>));
            Locator.CurrentMutable.Register(() => new OpenFromFileView(), typeof(IViewFor<OpenFromFileViewModel>));
            Locator.CurrentMutable.Register(() => new OpenFromDatabaseView(), typeof(IViewFor<OpenFromDatabaseViewModel>));

            Locator.CurrentMutable.RegisterLazySingleton(() => new CurrentLoadedFile());

            Locator.CurrentMutable.Register(() => new LocalFileRepository(), typeof(LocalFileRepository));
            Locator.CurrentMutable.Register(() => new DbFileRepository(ConfigurationManager.ConnectionStrings["Default"].ConnectionString), typeof(DbFileRepository));
        }
        
        public void Run()
        {
            var viewModel = new ShellViewModel();
            Locator.CurrentMutable.RegisterConstant(viewModel, typeof(IScreen));
            var view = ViewLocator.Current.ResolveView(viewModel);
            view.ViewModel = viewModel;
            Application.Run((Form)view);
        }
    }
}
