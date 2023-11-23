using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using DataBindingsForWinForms.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBindingsForWinForms.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        private readonly IServiceProvider _serviceProvier;

        [ObservableProperty]
        private int _count = 0;

        [ObservableProperty]
        [NotifyCanExecuteChangedFor(nameof(TestACommand))]
        private bool _enable = false;

        [ObservableProperty]
        private int _maxProgress = 100;

        [ObservableProperty]
        private int _progress = 0;

        [ObservableProperty]
        [NotifyCanExecuteChangedFor(nameof(TestBCommand))]
        private bool _disable = false;

        public MainViewModel()
        {
            _serviceProvier = Program.ServiceProvider;
        }

        [RelayCommand(CanExecute = nameof(CanTestA))]
        private void TestA()
        {
            Count++;
        }

        private bool CanTestA()
        {
            return Enable;
        }

        [RelayCommand(CanExecute = nameof(CanTestBAsync), IncludeCancelCommand = true)]
        private async Task TestBAsync(CancellationToken token)
        {
            try
            {
                Progress = 0;
                Disable = true;

                for (int i = 0; i < 100; i++)
                {
                    if (token.IsCancellationRequested)
                    {
                        break;
                    }

                    await UpdateUIAsync();
                    Progress++;
                }
            }
            finally
            {
                Progress = 0;
                Disable = false;
                IDialogService dialogService = _serviceProvier.GetRequiredService<IDialogService>();
                dialogService.ShowDialog("Completed");
            }
        }

        private async Task UpdateUIAsync()
        {
            await Task.Delay(25);
        }

        private bool CanTestBAsync()
        {
            return !Disable;
        }
    }
}
