using Wpf.Ui.Abstractions;

namespace Cogwork.WPF.Services;

[Singleton]
internal class NavigationViewPageProvider : INavigationViewPageProvider
{
    public object? GetPage(Type pageType) => App.GetService(pageType);
}
