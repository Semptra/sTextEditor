using ReactiveUI;
using Splat;
using sTextEditor.Repositories;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sTextEditor
{
    public class AppBootstrapper : IEnableLogger
    {
        public AppBootstrapper()
        {
            RegisterDependencies();
        }

        public void RegisterDependencies()
        {
            Locator.CurrentMutable.Register(() => new TextEditorWindow(), typeof(IViewFor<TextEditorViewModel>));

            Locator.CurrentMutable.Register(() => new LocalFileRepository(), typeof(IFileRepository), "Local");
            Locator.CurrentMutable.Register(() =>
            {
                var connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
                return new DbFileRepository(connectionString);
            }, typeof(IFileRepository), "Database");
        }

        public void Run()
        {
            var textEditorViewModel = new TextEditorViewModel();
            Locator.CurrentMutable.RegisterConstant(textEditorViewModel, typeof(TextEditorViewModel));
            var textEditorView = ViewLocator.Current.ResolveView(textEditorViewModel);
            textEditorView.ViewModel = textEditorViewModel;
            Application.Run((Form)textEditorView);
        }
    }
}
