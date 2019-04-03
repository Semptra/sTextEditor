using System.Configuration;
using System.Windows.Forms;
using ReactiveUI;
using Splat;
using sTextEditor.Repositories;
using sTextEditor.Services;
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
            #region Views registretion
            Locator.CurrentMutable.Register(() => new ShellView(), typeof(IViewFor<ShellViewModel>));
            Locator.CurrentMutable.Register(() => new TextEditorView(), typeof(IViewFor<TextEditorViewModel>));
            Locator.CurrentMutable.Register(() => new OpenFromFileView(), typeof(IViewFor<OpenFromFileViewModel>));
            Locator.CurrentMutable.Register(() => new OpenFromDatabaseView(), typeof(IViewFor<OpenFromDatabaseViewModel>));
            Locator.CurrentMutable.Register(() => new SaveToFileView(), typeof(IViewFor<SaveToFileViewModel>));
            Locator.CurrentMutable.Register(() => new SaveToDatabaseView(), typeof(IViewFor<SaveToDatabaseViewModel>));
            #endregion
            #region Singleton registretion
            Locator.CurrentMutable.RegisterLazySingleton(() => new CurrentLoadedFile());
            #endregion
            #region Services registration
            Locator.CurrentMutable.Register(() => new CompressionService(), typeof(CompressionService));
            Locator.CurrentMutable.Register(() => new FormattingService(), typeof(FormattingService));
            #endregion
            #region Repositories registration
            Locator.CurrentMutable.Register(() => new LocalFileRepository(), typeof(LocalFileRepository));
            Locator.CurrentMutable.Register(() => new DbFileRepository(ConfigurationManager.ConnectionStrings["Default"].ConnectionString), typeof(DbFileRepository));
            #endregion
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
