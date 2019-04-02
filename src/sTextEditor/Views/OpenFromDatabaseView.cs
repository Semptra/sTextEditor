using ReactiveUI;
using sTextEditor.ViewModels;
using System.Linq;
using System.Reactive.Linq;
using System.Windows.Forms;

namespace sTextEditor.Views
{
    public partial class OpenFromDatabaseView : UserControl, IViewFor<OpenFromDatabaseViewModel>
    {
        public OpenFromDatabaseView()
        {
            InitializeComponent();

            this.DbFilesDataGrid.Events()
                .SelectionChanged
                .Select(_ => FileNameSelector())
                .InvokeCommand(this, view => view.ViewModel.UpdateSelectedRowCommand);

            this.WhenActivated(d =>
            {
                d(this.OneWayBind(ViewModel,
                    viewModel => viewModel.DbFiles,
                    view => view.DbFilesDataGrid.DataSource));

                d(this.BindCommand(ViewModel,
                    viewModel => viewModel.RefreshDbFilesCommand,
                    view => view.RefreshDbFilesButton));

                d(this.BindCommand(ViewModel,
                    viewModel => viewModel.OpenFileCommand,
                    view => view.OpenFileButton));
            });
        }

        public OpenFromDatabaseViewModel ViewModel { get; set; }

        object IViewFor.ViewModel
        {
            get => ViewModel;
            set => ViewModel = (OpenFromDatabaseViewModel)value;
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
