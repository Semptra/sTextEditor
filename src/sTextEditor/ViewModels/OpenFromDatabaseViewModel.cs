using ReactiveUI;
using Splat;
using sTextEditor.Models;
using sTextEditor.Models.Converters;
using sTextEditor.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reactive;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sTextEditor.ViewModels
{
    public class OpenFromDatabaseViewModel : ReactiveObject, IRoutableViewModel
    {
        private DataTable _dbFiles;
        public DataTable DbFiles
        {
            get => _dbFiles;
            set => this.RaiseAndSetIfChanged(ref _dbFiles, value);
        }

        private string _fileName;
        public string FileName
        {
            get => _fileName;
            set => this.RaiseAndSetIfChanged(ref _fileName, value);
        }

        private string _fileSize;
        public string FileSize
        {
            get => _fileSize;
            set => this.RaiseAndSetIfChanged(ref _fileSize, value);
        }

        private string _fileText;
        public string FileText
        {
            get => _fileText;
            set => this.RaiseAndSetIfChanged(ref _fileText, value);
        }

        private string _selectedFileName;
        public string SelectedFileName
        {
            get => _selectedFileName;
            set => this.RaiseAndSetIfChanged(ref _selectedFileName, value);
        }

        public ReactiveCommand RefreshDbFilesCommand { get; }
        public ReactiveCommand OpenFileCommand { get; }
        public ReactiveCommand<string, Unit> UpdateSelectedRowCommand { get; }

        public string UrlPathSegment { get; }
        public IScreen HostScreen { get; }

        private readonly DbFileRepository _dbFileRepository;

        public OpenFromDatabaseViewModel(IScreen screen = null)
        {
            HostScreen = screen ?? Locator.Current.GetService<IScreen>();
            _dbFileRepository = Locator.Current.GetService<DbFileRepository>();

            RefreshDbFilesCommand = ReactiveCommand.Create(RefreshDbFiles);
            OpenFileCommand = ReactiveCommand.CreateFromTask(OpenFileAsync);
            UpdateSelectedRowCommand = ReactiveCommand.Create<string, Unit>(x => 
            {
                SelectedFileName = x; return Unit.Default;
            });
        }

        private void RefreshDbFiles()
        {
            DbFiles = _dbFileRepository.LoadAllFiles();
        }

        private async Task OpenFileAsync()
        {
            if (SelectedFileName is null)
            {
                MessageBox.Show("Please select a file by chosing either the row or the file name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var file = await _dbFileRepository.LoadFileAsync(SelectedFileName);

            if (file is null)
            {
                MessageBox.Show($"File with name {SelectedFileName} not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show($"Loaded.", "Nice", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
