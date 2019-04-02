using System;
using ReactiveUI;
using Splat;
using sTextEditor.Repositories;

namespace sTextEditor.ViewModels
{
    public class ShellViewModel : ReactiveObject, IScreen
    {
        private string _applicationTitle;

        public ShellViewModel()
        {
            Router = new RoutingState();

            ApplicationTitle = "sTextEditor";

            ShowOpenFromFileCommand = ReactiveCommand.Create(ShowOpenFromFile);
            ShowTextEditorCommand = ReactiveCommand.Create(ShowTextEditor);
            ShowOpenFromDatabaseCommand = ReactiveCommand.Create(ShowOpenFromDatabase);

            Locator.Current.GetService<DbFileRepository>().EnsureDbCreated();

            ShowTextEditor();
        }

        public RoutingState Router { get; }

        public string ApplicationTitle
        {
            get => _applicationTitle;
            set => this.RaiseAndSetIfChanged(ref _applicationTitle, value);
        }

        public ReactiveCommand ShowTextEditorCommand { get; }
        public ReactiveCommand ShowOpenFromFileCommand { get; }
        public ReactiveCommand ShowOpenFromDatabaseCommand { get; }
        public ReactiveCommand ShowContactCommand { get; }
        public ReactiveCommand GoBackCommand { get; }

        private void ShowTextEditor()
        {
            Router
                .Navigate
                .Execute(new TextEditorViewModel())
                .Subscribe();
        }

        private void ShowOpenFromFile()
        {
            Router
                .Navigate
                .Execute(new OpenFromFileViewModel())
                .Subscribe();
        }

        private void ShowOpenFromDatabase()
        {
            Router
                .Navigate
                .Execute(new OpenFromDatabaseViewModel())
                .Subscribe();
        }
    }
}
