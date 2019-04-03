using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Reactive.Linq;
using System.Reactive;
using System.Windows.Forms;
using ReactiveUI;
using sTextEditor.ViewModels;

namespace sTextEditor.Views
{
    public partial class SaveToDatabaseView : UserControl, IViewFor<SaveToDatabaseViewModel>
    {
        public SaveToDatabaseView()
        {
            InitializeComponent();

            this.Events()
                .Enter
                .Select(_ => Unit.Default)
                .InvokeCommand(this, view => view.ViewModel.RefreshDbFilesCommand);

            this.WhenActivated(d =>
            {
                d(this.OneWayBind(ViewModel,
                    viewModel => viewModel.DbFiles,
                    view => view.DbFilesDataGrid.DataSource));

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
                    viewModel => viewModel.RefreshDbFilesCommand,
                    view => view.RefreshDbFilesButton));

                d(this.BindCommand(ViewModel,
                    viewModel => viewModel.SaveFileCommand,
                    view => view.SaveFileButton));
            });
        }

        public SaveToDatabaseViewModel ViewModel { get; set; }

        object IViewFor.ViewModel
        {
            get => ViewModel;
            set => ViewModel = (SaveToDatabaseViewModel)value;
        }

        private string FileNameSelector()
        {
            var selectedRow = this.DbFilesDataGrid.SelectedRows.OfType<DataGridViewRow>().FirstOrDefault();
            var selectedCell = this.DbFilesDataGrid.SelectedCells.OfType<DataGridViewCell>().FirstOrDefault();

            if (selectedRow is null && selectedCell is null)
            {
                return null;
            }

            if (selectedRow != null)
            {
                return selectedRow.Cells["Name"].Value as string;
            }

            if (selectedCell != null)
            {
                return selectedCell.OwningColumn.Name == "Name" ? selectedCell.Value as string : null;
            }

            return null;
        }
    }
}
