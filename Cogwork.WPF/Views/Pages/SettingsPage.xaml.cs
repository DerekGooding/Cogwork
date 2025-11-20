using Cogwork.WPF.ViewModels.Pages;
using Wpf.Ui.Abstractions.Controls;

namespace Cogwork.WPF.Views.Pages;

[Singleton]
public partial class SettingsPage : INavigableView<SettingsViewModel>
{
    public SettingsViewModel ViewModel { get; }

    public SettingsPage(SettingsViewModel viewModel)
    {
        ViewModel = viewModel;
        DataContext = this;

        InitializeComponent();
    }
}
