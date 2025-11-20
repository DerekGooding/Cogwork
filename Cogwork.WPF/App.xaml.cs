using System.Reflection;
using Cogwork.WPF.Generated;
using Cogwork.WPF.Views.Windows;


namespace Cogwork.WPF;
/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App
{
    private static readonly Host _host = Host.Initialize();
    public static T GetService<T>() where T : class => _host.Get<T>();


    public static object? GetService(Type type)
    {
        MethodInfo? genericGetMethod = null;
        foreach (var m in typeof(Host).GetMethods(BindingFlags.Public | BindingFlags.Instance))
        {
            if (m.IsGenericMethodDefinition &&
                string.Equals(m.Name, "Get", StringComparison.Ordinal) &&
                m.GetGenericArguments().Length == 1 &&
                m.GetParameters().Length == 0)
            {
                genericGetMethod = m;
                break;
            }
        }

        var closedMethod = genericGetMethod?.MakeGenericMethod(type);

        return closedMethod?.Invoke(_host, []);
    }

    /// <summary>
    /// Occurs when the application is loading.
    /// </summary>
    private async void OnStartup(object sender, StartupEventArgs e)
    {
        var mainWindow = GetService<MainWindow>();
        Current.MainWindow = mainWindow;

        mainWindow.Show();
        mainWindow.Navigate(typeof(Views.Pages.DashboardPage));
    }
}
