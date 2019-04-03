using System.Windows.Forms;
using ReactiveUI;
using sTextEditor.ViewModels;

namespace sTextEditor.Views
{
    public partial class SaveToFileView : UserControl, IViewFor<SaveToFileViewModel>
    {
        public SaveToFileView()
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
                    viewModel => viewModel.SaveFileCommand,
                    view => view.SaveFileButton));
            });
        }

        public SaveToFileViewModel ViewModel { get; set; }

        object IViewFor.ViewModel
        {
            get => ViewModel;
            set => ViewModel = (SaveToFileViewModel)value;
        }
    }
}
