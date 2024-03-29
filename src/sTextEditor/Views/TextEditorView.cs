﻿using System;
using System.IO;
using System.Reactive.Linq;
using System.Windows.Forms;
using ReactiveUI;
using sTextEditor.ViewModels;

namespace sTextEditor.Views
{
    public partial class TextEditorView : UserControl, IViewFor<TextEditorViewModel>
    {
        public TextEditorView()
        {
            InitializeComponent();

            this.TextEditor.Events()
                .TextChanged
                .Select(_ => this.TextEditor.Text)
                .InvokeCommand(this, view => view.ViewModel.UpdateFileTextCommand);

            this.ClearFormattingButton.Events()
                .Click
                .Select(_ => this.TextEditor)
                .InvokeCommand(this, view => view.ViewModel.ClearFormattingCommand);

            this.FormatAsXmlButton.Events()
                .Click
                .Select(_ => this.TextEditor)
                .InvokeCommand(this, view => view.ViewModel.FormatAsXmlCommand);

            this.FormatAsJsonButton.Events()
                .Click
                .Select(_ => this.TextEditor)
                .InvokeCommand(this, view => view.ViewModel.FormatAsJsonCommand);

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
