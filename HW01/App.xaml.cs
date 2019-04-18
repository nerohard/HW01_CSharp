using System.Windows;
using HW01.Managers;
using HW01.Models;
using HW01.Windows;

namespace HW01
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            MainWindow mainWindow = new MainWindow();
            UserModel user = new UserModel();
            NavigationModel navigationModel = new NavigationModel(mainWindow, user);
            NavigationManager.Instance.Initialize(navigationModel);
            mainWindow.Show();
            navigationModel.Navigate(DataHandlers.Input);
        }
    }
}
