using System.Reactive;
using System.Windows;
using ReactiveUI;

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

        public TextEditorViewModel()
        {
            OpenFile = ReactiveCommand.Create(() => { MessageBox.Show("Open File"); });
            SaveFile = ReactiveCommand.Create(() => { MessageBox.Show("Save File"); });

            FormatAsNone = ReactiveCommand.Create(() => { SelectedTextFormatting = TextFormatting.None; });
            FormatAsJson = ReactiveCommand.Create(() => { SelectedTextFormatting = TextFormatting.Json; });
            FormatAsXml = ReactiveCommand.Create(() => { SelectedTextFormatting = TextFormatting.Xml; });
        }

        public ReactiveCommand<Unit, Unit> OpenFile { get; }
        public ReactiveCommand<Unit, Unit> SaveFile { get; }

        public ReactiveCommand<Unit, Unit> FormatAsNone { get; }
        public ReactiveCommand<Unit, Unit> FormatAsJson { get; }
        public ReactiveCommand<Unit, Unit> FormatAsXml { get; }

        public ReactiveCommand<string, string> FormatText { get; }
    }
}
