using System.Reactive;
using System.Text;
using ReactiveUI;
using Splat;

namespace sTextEditor.ViewModels
{
    public class TextEditorViewModel : ReactiveObject, IRoutableViewModel
    {
        private string _fileText;
        public string FileText
        {
            get => _fileText;
            set => this.RaiseAndSetIfChanged(ref _fileText, value);
        }

        public TextEditorViewModel()
        {
            var currentLoadedFile = Locator.Current.GetService<CurrentLoadedFile>();
            FileText = currentLoadedFile?.Text ?? string.Empty;

            UpdateFileTextCommand = ReactiveCommand.Create<string, Unit>(UpdateFileText);
        }
        
        public IScreen HostScreen { get; protected set; }
        public string UrlPathSegment { get; protected set; }

        public ReactiveCommand<string, Unit> UpdateFileTextCommand { get; }

        private Unit UpdateFileText(string fileText)
        {
            var currentLoadedFile = Locator.Current.GetService<CurrentLoadedFile>();
            currentLoadedFile.Text = FileText;
            currentLoadedFile.Size = string.Concat(Encoding.UTF8.GetByteCount(FileText) * sizeof(byte), " B");
            
            return Unit.Default;
        }
    }
}
