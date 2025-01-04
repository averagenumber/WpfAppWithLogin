using System.Windows;
using System.Windows.Controls;
using WpfApp.Classes;

namespace WpfApp {
    public partial class Window1 : UserControl {
    
        private PopUp popUp = new PopUp();
        private LoadColor loadColor = new LoadColor();
        private Execute Execute = new Execute();
        private GetUserId GetUserId = new GetUserId();
        private WindowsCheck WindowsCheck = new WindowsCheck();
        private CustomMessage CustomMessageBox = new CustomMessage();
    
        public Window1() {
            InitializeComponent();
            loadColor.LoadColorsFromJson("Frame");
        }

        private void OnFrameButton1_Click(object sender, RoutedEventArgs e)
        {
            popUp.ShowPopUp("test");
        }
    }
}