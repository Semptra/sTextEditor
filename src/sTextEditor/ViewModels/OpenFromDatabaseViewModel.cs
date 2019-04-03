using System.Data;
using System.Reactive;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReactiveUI;
using Splat;
using sTextEditor.Repositories;

namespace sTextEditor.ViewModels
{
    public class OpenFromDatabaseViewModel : ReactiveObject, IRoutableViewModel
    {
        private readonly DbFileRepository _dbFileRepository;

        public OpenFromDatabaseViewModel()
        {
            _dbFileRepository = Locator.Current.GetService<DbFileRepository>();

            RefreshDbFilesCommand = ReactiveCommand.Create(RefreshDbFiles);
            OpenFileCommand = ReactiveCommand.CreateFromTask(OpenFileAsync);
            UpdateSelectedRowCommand = ReactiveCommand.Create<string, Unit>(UpdateSelectedRow);

            LoadInfoFromCurrentFile();
        }

        private DataTable _dbFiles;
        public DataTable DbFiles
        {
            get => _dbFiles;
            set => this.RaiseAndSetIfChanged(ref _dbFiles, value);
        }

        private string _fileName;
        public string FileName
        {
            get => _fileName;
            set => this.RaiseAndSetIfChanged(ref _fileName, value);
        }

        private string _fileSize;
        public string FileSize
        {
            get => _fileSize;
            set => this.RaiseAndSetIfChanged(ref _fileSize, value);
        }

        private string _fileText;
        public string FileText
        {
            get => _fileText;
            set => this.RaiseAndSetIfChanged(ref _fileText, value);
        }

        private string _selectedDataGridFileName;
        public string SelectedDataGridFileName
        {
            get => _selectedDataGridFileName;
            set => this.RaiseAndSetIfChanged(ref _selectedDataGridFileName, value);
        }

        public ReactiveCommand RefreshDbFilesCommand { get; }
        public ReactiveCommand OpenFileCommand { get; }
        public ReactiveCommand<string, Unit> UpdateSelectedRowCommand { get; }

        public string UrlPathSegment { get; }
        public IScreen HostScreen { get; }

        private void RefreshDbFiles()
        {
            DbFiles = _dbFileRepository.LoadAllFiles();
        }

        private async Task OpenFileAsync()
        {
            if (SelectedDataGridFileName is null)
            {
                MessageBox.Show("Please select a file by chosing either the row or the file name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var fileContent = await _dbFileRepository.LoadFileAsync(SelectedDataGridFileName);

            if (fileContent is null)
            {
                MessageBox.Show($"File with name {SelectedDataGridFileName} not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            FileName = SelectedDataGridFileName;
            FileSize = string.Concat(fileContent.Length * sizeof(byte), " B");
            FileText = Encoding.UTF8.GetString(fileContent);

            MessageBox.Show($"File {FileName} loaded.", "Success", MessageBoxButtons.OK);

            UpdateInfoToCurrentFile();
        }

        private Unit UpdateSelectedRow(string fileName)
        {
            SelectedDataGridFileName = fileName;
            return Unit.Default;
        }

        private void LoadInfoFromCurrentFile()
        {
            var currentLoadedFile = Locator.Current.GetService<CurrentLoadedFile>();
            FileName = currentLoadedFile.Name;
            FileSize = currentLoadedFile.Size;
            FileText = currentLoadedFile.Text;
        }

        private void UpdateInfoToCurrentFile()
        {
            var currentLoadedFile = Locator.Current.GetService<CurrentLoadedFile>();
            currentLoadedFile.Name = FileName;
            currentLoadedFile.Size = FileSize;
            currentLoadedFile.Text = FileText;
        }
    }
}
