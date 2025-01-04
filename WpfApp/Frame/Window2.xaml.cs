using System.Windows;
using System.Windows.Controls;
using WpfApp.Classes;

namespace WpfApp {
  public partial class Window2 : UserControl {
    
    private PopUp popUp = new PopUp();
    private LoadColor loadColor = new LoadColor();
    private Execute Execute = new Execute();
    private GetUserId GetUserId = new GetUserId();
    private WindowsCheck WindowsCheck = new WindowsCheck();
    private CustomMessage CustomMessageBox = new CustomMessage();
    
    public Window2() {
      InitializeComponent();
      loadColor.LoadColorsFromJson("Frame");
    }

    private void OnFrameButton2_Click(object sender, RoutedEventArgs e)
    {
      CustomMessageBox.Show("Title", "Message");
    }
  }
}
