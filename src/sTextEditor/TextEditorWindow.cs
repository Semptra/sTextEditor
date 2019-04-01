using System;
using System.Reactive.Disposables;
using System.Reactive.Linq;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using ReactiveUI;

namespace sTextEditor
{
    public partial class TextEditorWindow : Form, IViewFor<TextEditorViewModel>
    {
        public TextEditorWindow()
        {
            InitializeComponent();

            ViewModel = new TextEditorViewModel();

            this.WhenActivated(disposableRegistration =>
            {
                #region File commands



                #endregion
                #region Formatting commands

                this.BindCommand(ViewModel,
                    viewModel => viewModel.FormatAsNone,
                    view => view.FormatAsNoneRadioButton)
                .DisposeWith(disposableRegistration);

                this.BindCommand(ViewModel,
                    viewModel => viewModel.FormatAsJson,
                    view => view.FormatAsJsonRadioButton)
                .DisposeWith(disposableRegistration);

                this.BindCommand(ViewModel,
                    viewModel => viewModel.FormatAsXml,
                    view => view.FormatAsXmlRadioButton)
                .DisposeWith(disposableRegistration);

                #endregion

                this.WhenAnyValue(x => x.TextEditorRichTextBox.Text)
                    .Subscribe(preFormatedText =>
                    {
                        this.TextEditorRichTextBox.Text = FormatText(preFormatedText);
                    });
            });
        }

        string FormatText(string text)
        {
            if (!IsValidJson(text))
            {
                return text;
            }

            var jsonFormatedText = JToken.Parse(text);

            if (jsonFormatedText != null)
            {
                return jsonFormatedText.ToString(Newtonsoft.Json.Formatting.Indented);
            }
            else
            {
                return text;
            }
        }

        private static bool IsValidJson(string strInput)
        {
            strInput = strInput.Trim();
            if ((strInput.StartsWith("{") && strInput.EndsWith("}")) || //For object
                (strInput.StartsWith("[") && strInput.EndsWith("]"))) //For array
            {
                try
                {
                    var obj = JToken.Parse(strInput);
                    return true;
                }
                catch (Exception ex) //some other exception
                {
                    Console.WriteLine(ex.ToString());
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public TextEditorViewModel ViewModel { get; set; }
        object IViewFor.ViewModel
        {
            get => ViewModel;
            set => ViewModel = (TextEditorViewModel)value;
        }
    }
}
