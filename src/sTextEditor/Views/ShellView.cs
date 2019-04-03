using System.Windows.Forms;
using ReactiveUI;
using sTextEditor.ViewModels;

namespace sTextEditor.Views
{
    public partial class ShellView : Form, IViewFor<ShellViewModel>
    {
        public ShellView()
        {
            InitializeComponent();

            this.WhenActivated(d =>
            {
                d(this.OneWayBind(ViewModel,
                    viewModel => viewModel.Router,
                    view => view.RoutedControlHost.Router));

                d(this.BindCommand(ViewModel,
                    viewModel => viewModel.ShowOpenFromFileCommand,
                    view => view.OpenFromFileMenuItem));

                d(this.BindCommand(ViewModel,
                    viewModel => viewModel.ShowTextEditorCommand,
                    view => view.OpenFileEditorMenuItem));

                d(this.BindCommand(ViewModel,
                    viewModel => viewModel.ShowOpenFromDatabaseCommand,
                    view => view.OpenFromDatabaseMenuItem));

                d(this.BindCommand(ViewModel,
                    viewModel => viewModel.ShowSaveToFileCommand,
                    view => view.SaveToFileMenuItem));

                d(this.BindCommand(ViewModel,
                    viewModel => viewModel.ShowSaveToDatabaseCommand,
                    view => view.SaveToDatabaseMenuItem));
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
