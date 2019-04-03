using System.Drawing;
using System.IO;
using System.Reactive;
using System.Text;
using Newtonsoft.Json;
using ReactiveUI;
using ScintillaNET;
using Splat;
using sTextEditor.Configuration;
using sTextEditor.Services;

namespace sTextEditor.ViewModels
{
    public class TextEditorViewModel : ReactiveObject, IRoutableViewModel
    {
        private readonly FormattingService _formattingService;

        public TextEditorViewModel()
        {
            var currentLoadedFile = Locator.Current.GetService<CurrentLoadedFile>();
            FileText = currentLoadedFile?.Text ?? string.Empty;

            UpdateFileTextCommand = ReactiveCommand.Create<string, Unit>(UpdateFileText);
            ClearFormattingCommand = ReactiveCommand.Create<Scintilla, Unit>(ClearFormatting);
            FormatAsXmlCommand = ReactiveCommand.Create<Scintilla, Unit>(FormatAsXml);
            FormatAsJsonCommand = ReactiveCommand.Create<Scintilla, Unit>(FormatAsJson);
        }

        private string _fileText;
        public string FileText
        {
            get => _fileText;
            set => this.RaiseAndSetIfChanged(ref _fileText, value);
        }

        public ReactiveCommand<string, Unit> UpdateFileTextCommand { get; }
        public ReactiveCommand<Scintilla, Unit> ClearFormattingCommand { get; }
        public ReactiveCommand<Scintilla, Unit> FormatAsXmlCommand { get; }
        public ReactiveCommand<Scintilla, Unit> FormatAsJsonCommand { get; }

        public IScreen HostScreen { get; protected set; }
        public string UrlPathSegment { get; protected set; }

        private Unit UpdateFileText(string fileText)
        {
            var currentLoadedFile = Locator.Current.GetService<CurrentLoadedFile>();
            currentLoadedFile.Text = fileText;
            currentLoadedFile.Size = string.Concat(Encoding.UTF8.GetByteCount(fileText) * sizeof(byte), " B");
            
            return Unit.Default;
        }

        private Unit ClearFormatting (Scintilla textEditor)
        {
            textEditor.Lexer = Lexer.Null;

            textEditor.StyleResetDefault();
            textEditor.Styles[Style.Default].Font = "Consolas";
            textEditor.Styles[Style.Default].Size = 10;
            textEditor.StyleClearAll();

            return Unit.Default;
        }

        private Unit FormatAsXml(Scintilla textEditor)
        {
            ClearFormatting(textEditor);

            var styles = JsonConvert.DeserializeObject<StylesConfiguration>(File.ReadAllText("styles.json"));

            textEditor.Lexer = Lexer.Xml;

            textEditor.Styles[Style.Xml.Asp].ForeColor = Color.FromName(styles.Xml.Asp.ForeColor);
            textEditor.Styles[Style.Xml.AspAt].ForeColor = Color.FromName(styles.Xml.AspAt.ForeColor);
            textEditor.Styles[Style.Xml.Attribute].ForeColor = Color.FromName(styles.Xml.Attribute.ForeColor);
            textEditor.Styles[Style.Xml.AttributeUnknown].ForeColor = Color.FromName(styles.Xml.AttributeUnknown.ForeColor);
            textEditor.Styles[Style.Xml.CData].ForeColor = Color.FromName(styles.Xml.CData.ForeColor);
            textEditor.Styles[Style.Xml.Comment].ForeColor = Color.FromName(styles.Xml.Comment.ForeColor);
            textEditor.Styles[Style.Xml.Default].ForeColor = Color.FromName(styles.Xml.Default.ForeColor);
            textEditor.Styles[Style.Xml.DoubleString].ForeColor = Color.FromName(styles.Xml.DoubleString.ForeColor);
            textEditor.Styles[Style.Xml.Entity].ForeColor = Color.FromName(styles.Xml.Entity.ForeColor);
            textEditor.Styles[Style.Xml.Number].ForeColor = Color.FromName(styles.Xml.Number.ForeColor);
            textEditor.Styles[Style.Xml.Other].ForeColor = Color.FromName(styles.Xml.Other.ForeColor);
            textEditor.Styles[Style.Xml.Question].ForeColor = Color.FromName(styles.Xml.Question.ForeColor);
            textEditor.Styles[Style.Xml.Script].ForeColor = Color.FromName(styles.Xml.Script.ForeColor);
            textEditor.Styles[Style.Xml.SingleString].ForeColor = Color.FromName(styles.Xml.SingleString.ForeColor);
            textEditor.Styles[Style.Xml.Tag].ForeColor = Color.FromName(styles.Xml.Tag.ForeColor);
            textEditor.Styles[Style.Xml.TagEnd].ForeColor = Color.FromName(styles.Xml.TagEnd.ForeColor);
            textEditor.Styles[Style.Xml.TagUnknown].ForeColor = Color.FromName(styles.Xml.TagUnknown.ForeColor);
            textEditor.Styles[Style.Xml.Value].ForeColor = Color.FromName(styles.Xml.Value.ForeColor);
            textEditor.Styles[Style.Xml.XcComment].ForeColor = Color.FromName(styles.Xml.XcComment.ForeColor);
            textEditor.Styles[Style.Xml.XmlEnd].ForeColor = Color.FromName(styles.Xml.XmlEnd.ForeColor);
            textEditor.Styles[Style.Xml.XmlStart].ForeColor = Color.FromName(styles.Xml.XmlStart.ForeColor);

            textEditor.Text = _formattingService.FormatAsXml(textEditor.Text);

            textEditor.Colorize(0, textEditor.TextLength);

            return Unit.Default;
        }

        private Unit FormatAsJson(Scintilla textEditor)
        {
            ClearFormatting(textEditor);

            var styles = JsonConvert.DeserializeObject<StylesConfiguration>(File.ReadAllText("styles.json"));

            textEditor.Lexer = Lexer.Json;

            textEditor.Styles[Style.Json.BlockComment].ForeColor = Color.FromName(styles.Json.BlockComment.ForeColor);
            textEditor.Styles[Style.Json.CompactIRI].ForeColor = Color.FromName(styles.Json.CompactIRI.ForeColor);
            textEditor.Styles[Style.Json.Default].ForeColor = Color.FromName(styles.Json.Default.ForeColor);
            textEditor.Styles[Style.Json.Error].ForeColor = Color.FromName(styles.Json.Error.ForeColor);
            textEditor.Styles[Style.Json.EscapeSequence].ForeColor = Color.FromName(styles.Json.EscapeSequence.ForeColor);
            textEditor.Styles[Style.Json.Keyword].ForeColor = Color.FromName(styles.Json.Keyword.ForeColor);
            textEditor.Styles[Style.Json.LdKeyword].ForeColor = Color.FromName(styles.Json.LdKeyword.ForeColor);
            textEditor.Styles[Style.Json.LineComment].ForeColor = Color.FromName(styles.Json.LineComment.ForeColor);
            textEditor.Styles[Style.Json.Number].ForeColor = Color.FromName(styles.Json.Number.ForeColor);
            textEditor.Styles[Style.Json.Operator].ForeColor = Color.FromName(styles.Json.Operator.ForeColor);
            textEditor.Styles[Style.Json.PropertyName].ForeColor = Color.FromName(styles.Json.PropertyName.ForeColor);
            textEditor.Styles[Style.Json.String].ForeColor = Color.FromName(styles.Json.String.ForeColor);
            textEditor.Styles[Style.Json.StringEol].ForeColor = Color.FromName(styles.Json.StringEol.ForeColor);
            textEditor.Styles[Style.Json.Uri].ForeColor = Color.FromName(styles.Json.Uri.ForeColor);

            textEditor.Text = _formattingService.FormatAsJson(textEditor.Text);

            textEditor.Colorize(0, textEditor.TextLength);

            return Unit.Default;
        }
    }
}
