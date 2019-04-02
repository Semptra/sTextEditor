using ReactiveUI;
using sTextEditor.ViewModels;
using System.Windows.Forms;

namespace sTextEditor.Views
{
    public partial class OpenFromFileView : UserControl, IViewFor<OpenFromFileViewModel>
    {
        public OpenFromFileView()
        {
            InitializeComponent();

            this.WhenActivated(d =>
            {
                d(this.Bind(ViewModel,
                    viewModel => viewModel.FileName,
                    view => view.FileNameTextBox.Text));

                d(this.Bind(ViewModel,
                    viewModel => viewModel.FileSize,
                    view => view.FileSizeTextBox.Text));

                d(this.Bind(ViewModel,
                    viewModel => viewModel.FileText,
                    view => view.FileContentPreview.Text));

                d(this.BindCommand(ViewModel,
                    viewModel => viewModel.OpenFileCommand,
                    view => view.OpenFileButton));
            });
        }

        public OpenFromFileViewModel ViewModel { get; set; }

        object IViewFor.ViewModel
        {
            get => ViewModel;
            set => ViewModel = (OpenFromFileViewModel)value;
        }
    }
}
