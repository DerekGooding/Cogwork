using Wpf.Ui.Abstractions.Controls;

namespace Cogwork.WPF.ViewModels.Pages;

[Singleton, ViewModel]
public partial class DataViewModel : INavigationAware
{
    private bool _isInitialized = false;

    public Task OnNavigatedToAsync()
    {
        if (!_isInitialized)
            InitializeViewModel();

        return Task.CompletedTask;
    }

    public Task OnNavigatedFromAsync() => Task.CompletedTask;

    private void InitializeViewModel() => _isInitialized = true;
}
