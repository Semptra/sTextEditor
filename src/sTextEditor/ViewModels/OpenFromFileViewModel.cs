using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReactiveUI;
using Splat;
using sTextEditor.Repositories;

namespace sTextEditor.ViewModels
{
    public class OpenFromFileViewModel : ReactiveObject, IRoutableViewModel
    {
        private readonly LocalFileRepository _localFileRepository;

        public OpenFromFileViewModel()
        {
            _localFileRepository = Locator.Current.GetService<LocalFileRepository>();

            OpenFileCommand = ReactiveCommand.CreateFromTask(OpenFileAsync);

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

        public ReactiveCommand OpenFileCommand { get; }

        public string UrlPathSegment { get; }
        public IScreen HostScreen { get; }

        private async Task OpenFileAsync()
        {
            string fileName = OpenFile();

            if (string.IsNullOrEmpty(fileName))
                return;

            var fileContent = await _localFileRepository.LoadFileAsync(fileName);

            FileName = fileName;
            FileSize = string.Concat(fileContent.Length * sizeof(byte), " B");
            FileText = Encoding.UTF8.GetString(fileContent);

            MessageBox.Show($"File {FileName} loaded.", "Success", MessageBoxButtons.OK);

            UpdateInfoToCurrentFile();
        }

        private string OpenFile()
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    return openFileDialog.FileName;
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
