using System.Windows;
using WpfApp.LoginApp;

namespace WpfApp
{

    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e); 
            /*if (e.Args == null || e.Args.Length == 0 || e.Args[0] != "key")
            {
                MessageBox.Show("huh");
                Application.Current.Shutdown();
            }
            else
            {*/
                LoginWindow loginWindow = new LoginWindow();
                loginWindow.Show();
            //}
        }
    }
}
