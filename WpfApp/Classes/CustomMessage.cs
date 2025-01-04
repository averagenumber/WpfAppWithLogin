namespace WpfApp.Classes;

public class CustomMessage
{
    public void Show(string title, string content) {
        var customMessageBox = new CustomMessageBox.Show(title, content);
        customMessageBox.ShowDialog();
    }
}