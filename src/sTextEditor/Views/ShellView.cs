using ReactiveUI;
using sTextEditor.ViewModels;
using System.Windows.Forms;

namespace sTextEditor.Views
{
    public partial class ShellView : Form, IViewFor<ShellViewModel>
    {
        public ShellView()
        {
            InitializeComponent();

            this.WhenActivated(b =>
            {
                b(this.OneWayBind(ViewModel,
                    viewModel => viewModel.Router,
                    view => view.RoutedControlHost.Router));

                #region Menu commands binding

                b(this.BindCommand(ViewModel,
                    viewModel => viewModel.ShowOpenFromFileCommand,
                    view => view.OpenFromFileMenuItem));

                b(this.BindCommand(ViewModel,
                    viewModel => viewModel.ShowTextEditorCommand,
                    view => view.OpenFileEditorMenuItem));

                b(this.BindCommand(ViewModel,
                    viewModel => viewModel.ShowOpenFromDatabaseCommand,
                    view => view.OpenFromDatabaseMenuItem));

                // this.BindCommand(ViewModel,
                //    viewModel => viewModel.ShowOpenFromDatabaseCommand,
                //    view => view.OpenFromDatabaseMenuItem)
                //.DisposeWith(disposableRegistration);

                // this.BindCommand(ViewModel,
                //     viewModel => viewModel.ShowSaveToFileCommand,
                //     view => view.SaveToFileMenuItem)
                // .DisposeWith(disposableRegistration);

                // this.BindCommand(ViewModel,
                //     viewModel => viewModel.ShowSaveToDatabaseCommand,
                //     view => view.SaveToDatabaseMenuItem)
                // .DisposeWith(disposableRegistration);

                #endregion
            });
        }
        
        public ShellViewModel ViewModel { get; set; }

        object IViewFor.ViewModel
        {
            get => ViewModel;
            set => ViewModel = (ShellViewModel)value;
        }
    }
}
