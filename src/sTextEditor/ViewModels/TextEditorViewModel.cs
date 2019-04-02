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
        }
        
        public IScreen HostScreen { get; protected set; }
        public string UrlPathSegment { get; protected set; }        
    }
}
