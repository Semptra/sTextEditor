using ReactiveUI;
using sTextEditor.ViewModels;
using System.Windows.Forms;

namespace sTextEditor.Views
{
    public partial class TextEditorView : UserControl, IViewFor<TextEditorViewModel>
    {
        public TextEditorView()
        {
            InitializeComponent();

            this.WhenActivated(d =>
            {
                d(this.Bind(ViewModel,
                    viewModel => viewModel.FileText,
                    view => view.TextEditor.Text));
            });
        }

        public TextEditorViewModel ViewModel { get; set; }

        object IViewFor.ViewModel
        {
            get => ViewModel;
            set => ViewModel = (TextEditorViewModel)value;
        }       
    }
}
