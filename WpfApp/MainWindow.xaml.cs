using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using WpfApp.Classes;

namespace WpfApp
{
    public partial class MainWindow : Window
    {
        private PopUp popUp = new PopUp();
        private LoadColor loadColor = new LoadColor();
        private CustomMessage CustomMessageBox = new CustomMessage();
        private Execute Execute = new Execute();
        
        public MainWindow()
        {
            InitializeComponent();
            loadColor.LoadColorsFromJson("Main");
        }
        
        private void MainIcon_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            MainFrame.Content = null;
            MainTextBlock.Visibility = Visibility.Visible;
            MainTextBlock.Text = $"Welcome to WpfApp";
        }
        
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Application.Current.Shutdown();
        }        
        
        private void Goto_Button(object sender, RoutedEventArgs e)
        {
            if (sender is Button button && button.CommandParameter is string parameter)
            {
                SwitchFrame(MainTextBlock,MainFrame,parameter);
            }
        }
        
        private void SwitchFrame(TextBlock MainTextBlock, Frame MainFrame, string parameter)
        {
            switch (parameter)
            {
                case "Button1":
                    MainTextBlock.Visibility = Visibility.Hidden;
                    MainFrame.Content = null;
                    MainFrame.Content = new Window1();
                    break;
                case "Button2":
                    MainTextBlock.Visibility = Visibility.Hidden;
                    MainFrame.Content = null;
                    MainFrame.Content = new Window2();
                    break;
                default:
                    MainFrame.Content = null;
                    MainTextBlock.Visibility = Visibility.Visible;
                    MainTextBlock.Text = $"Warning: {parameter}";
                    break;
            }
        }
    }
}
