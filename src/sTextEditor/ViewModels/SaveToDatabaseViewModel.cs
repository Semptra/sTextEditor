using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReactiveUI;
using Splat;
using sTextEditor.Repositories;

namespace sTextEditor.ViewModels
{
    public class SaveToDatabaseViewModel : ReactiveObject, IRoutableViewModel
    {
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

        public ReactiveCommand RefreshDbFilesCommand { get; }
        public ReactiveCommand SaveFileCommand { get; }

        public string UrlPathSegment { get; }
        public IScreen HostScreen { get; }

        private readonly DbFileRepository _dbFileRepository;

        public SaveToDatabaseViewModel(IScreen screen = null)
        {
            HostScreen = screen ?? Locator.Current.GetService<IScreen>();
            _dbFileRepository = Locator.Current.GetService<DbFileRepository>();

            RefreshDbFilesCommand = ReactiveCommand.Create(RefreshDbFiles);
            SaveFileCommand = ReactiveCommand.CreateFromTask(SafeFileAsync);

            LoadInfoFromCurrentFile();
        }

        private void RefreshDbFiles()
        {
            DbFiles = _dbFileRepository.LoadAllFiles();
        }

        private async Task SafeFileAsync()
        {
            if (FileText == null || FileName == null || FileSize == null)
            {
                MessageBox.Show("No loaded file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var isFileExists = await _dbFileRepository.IsFileExistsAsync(FileName);

            if (isFileExists)
            {
                var result = MessageBox.Show($"File with name {FileName} already exists. Do you want to update it?",
                    "Warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    await _dbFileRepository.UpdateFileAsync(FileName, Encoding.UTF8.GetBytes(FileText));
                    RefreshDbFiles();
                    MessageBox.Show($"File {FileName} saved.", "Success", MessageBoxButtons.OK);
                }
            }
            else
            {
                await _dbFileRepository.InsertFileAsync(FileName, Encoding.UTF8.GetBytes(FileText));
                RefreshDbFiles();
                MessageBox.Show($"File {FileName} saved.", "Success", MessageBoxButtons.OK);
            }
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
