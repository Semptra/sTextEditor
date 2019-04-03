using System.Threading.Tasks;
using System.Windows.Forms;
using ReactiveUI;
using Splat;
using sTextEditor.Repositories;

namespace sTextEditor.ViewModels
{
    public class SaveToFileViewModel : ReactiveObject, IRoutableViewModel
    {
        private readonly LocalFileRepository _localFileRepository;

        public SaveToFileViewModel()
        {
            _localFileRepository = Locator.Current.GetService<LocalFileRepository>();
            SaveFileCommand = ReactiveCommand.CreateFromTask(SaveFileAsync);

            LoadInfoFromCurrentFile();
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

        public ReactiveCommand SaveFileCommand { get; }

        public string UrlPathSegment { get; }
        public IScreen HostScreen { get; }

        private async Task SaveFileAsync()
        {
            string fileName = SaveFile();

            if (string.IsNullOrEmpty(fileName))
            {
                return;
            }

            FileName = fileName;

            await _localFileRepository.SaveFileAsync(FileName, FileText);

            MessageBox.Show($"File {FileName} saved.", "Success", MessageBoxButtons.OK);

            UpdateInfoToCurrentFile();
        }

        private string SaveFile()
        {
            using (var saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.FileName = FileName;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    return saveFileDialog.FileName;
                }
                else
                {
                    return null;
                }
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
