using System.Reactive;
using System.Text;
using System.Windows.Forms;
using ReactiveUI;
using Splat;
using sTextEditor.Repositories;

namespace sTextEditor
{
    public class TextEditorViewModel : ReactiveObject
    {
        private TextFormatting _selectedTextFormatting = TextFormatting.None;
        public TextFormatting SelectedTextFormatting
        {
            get => _selectedTextFormatting;
            set => this.RaiseAndSetIfChanged(ref _selectedTextFormatting, value);
        }

        private string _formattedText;
        public string FormatedText
        {
            get => _formattedText;
            set => this.RaiseAndSetIfChanged(ref _formattedText, value);
        }

        private string _fileText;
        public string FileText
        {
            get => _fileText;
            set => this.RaiseAndSetIfChanged(ref _fileText, value);
        }

        private readonly IFileRepository _localRepository;
        private readonly IFileRepository _dbRepository;

        public TextEditorViewModel()
        {
            _localRepository = Locator.Current.GetService<IFileRepository>("Local");
            _dbRepository = Locator.Current.GetService<IFileRepository>("Database");

            OpenFileFromFile = ReactiveCommand.CreateFromTask(async _ =>
            {
                using (var openFileDialog = new OpenFileDialog())
                {
                    if(openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        var fileContent = await _localRepository.LoadFileAsync(openFileDialog.FileName);
                        var fileText = Encoding.UTF8.GetString(fileContent);
                        FileText = fileText;
                    }
                }
            });

            OpenFileFromDatabase = ReactiveCommand.CreateFromTask(async _ =>
            {
                var fileContent = await _dbRepository.LoadFileAsync("hello");

                if (fileContent is null)
                {
                    MessageBox.Show("File hello not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var fileText = Encoding.UTF8.GetString(fileContent);
                FileText = fileText;
            });

            SaveFileToFile = ReactiveCommand.CreateFromTask(async _ =>
            {
                using (var saveFileDialog = new SaveFileDialog())
                {
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        await _localRepository.SaveFileAsync(saveFileDialog.FileName, FileText);
                    }
                }
            });

            SaveFileToDatabase = ReactiveCommand.CreateFromTask(async _ =>
            {
                await _dbRepository.SaveFileAsync("newFile", FileText);
            });
        }

        public ReactiveCommand<Unit, Unit> OpenFileFromFile { get; }
        public ReactiveCommand<Unit, Unit> OpenFileFromDatabase { get; }
        public ReactiveCommand<Unit, Unit> SaveFileToFile { get; }
        public ReactiveCommand<Unit, Unit> SaveFileToDatabase { get; }

        public ReactiveCommand<Unit, Unit> FormatAsNone { get; }
        public ReactiveCommand<Unit, Unit> FormatAsJson { get; }
        public ReactiveCommand<Unit, Unit> FormatAsXml { get; }
    }
}
