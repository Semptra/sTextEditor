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

                this.Bind(ViewModel,
                    viewModel => viewModel.FileText,
                    view => view.TextEditorRichTextBox.Text);

                #endregion
                #region Formatting commands

                this.BindCommand(ViewModel,
                    viewModel => viewModel.OpenFileFromFile,
                    view => view.FileOpenFromFileMenuItem,
                    "Click");

                this.BindCommand(ViewModel,
                   viewModel => viewModel.OpenFileFromDatabase,
                   view => view.FileOpenFromDbMenuItem,
                   "Click");

                this.BindCommand(ViewModel,
                    viewModel => viewModel.SaveFileToFile,
                    view => view.FileSaveToFileMenuItem,
                    "Click");

                this.BindCommand(ViewModel,
                    viewModel => viewModel.SaveFileToDatabase,
                    view => view.FileSaveToDbMenuItem,
                    "Click");

                #endregion
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
