namespace Cogwork.WPF.ViewModels.Pages;

[Singleton, ViewModel]
public partial class DashboardViewModel
{
    [Bind] private int _counter;

    [Command] public void CounterIncrement() => Counter++;
}
