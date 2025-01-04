using System.Windows;
using WpfApp.Classes;

namespace WpfApp;

public partial class MiniWindow1 : Window
{
    private PopUp popUp = new PopUp();
    private LoadColor loadColor = new LoadColor();
    private Execute Execute = new Execute();
    private CustomMessage CustomMessageBox = new CustomMessage();
    public MiniWindow1() {
        InitializeComponent();
        loadColor.LoadColorsFromJson("Frame");
    }


    private void MiniButton1_Click(object sender, RoutedEventArgs e)
    {
        popUp.Show();
    }
    
    private void MiniButton2_Click(object sender, RoutedEventArgs e)
    {
        CustomMessageBox.Show("Title", "Message");
    }
}