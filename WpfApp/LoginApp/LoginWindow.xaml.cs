using System.IO;
using System.Management;
using System.Windows;
using WpfApp;
using System.Net.Http;
using System.Text;
using System.Windows.Input;
using WpfApp.Classes;

namespace WpfApp.LoginApp
{
    public partial class LoginWindow : Window
    {
        private PopUp popUp = new PopUp();
        private LoadColor loadColor = new LoadColor();
        private CustomMessage CustomMessageBox = new CustomMessage();
        private string keyPath = @"C:\WpfApp\Data\key.txt";
        
        public LoginWindow()
        {
            this.AllowsTransparency = true;
            this.Hide();
            InitializeComponent();
            //CheckBlackList();
            //CheckLogin(keyPath);
            loadColor.LoadColorsFromJson("Frame");
        }

        protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonDown(e);  
            DragMove();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
                Application.Current.Shutdown();
        }

        private async void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            string key = KeyTextBox.Text;

            bool checkKey = await KeyCheck(key, keyPath);
            
            if (checkKey)
            {
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                this.Hide();
            }
            else
            {
                popUp.ShowPopUp("Key invalid");
            }
        }

        public async void CheckLogin(string keyPath)
        {
            string fileKey = "";
            if (File.Exists(keyPath))
            {
                foreach (string line in File.ReadLines(keyPath))
                {
                    fileKey = line;
                }

                bool checkKey = await KeyCheck(fileKey, keyPath);
                if (checkKey)
                {
                    MainWindow mainWindow = new MainWindow();
                    mainWindow.Show();
                    this.Hide();
                    return;
                }
            }
            else {if (!this.IsVisible)
            {
                this.Show();
            }}
        }

        public async void CheckBlackList()
        {
            string motherId = GetMHWID();
            
            string data = "linktoblacklist";
            string pasteContent = await GetPasteContent(data);
            string[] lines = pasteContent.Split(new[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string id in lines)
            {
                if (id == motherId)
                {
                    Application.Current.Shutdown();
                }
            }
        }

        public async Task<bool> KeyCheck(string expectedKey, string keyPath)
        {
            string expectedMotherID = GetMHWID();
            string data = "linktokeylist";

            string pasteContent = await GetPasteContent(data);
            string[] lines = pasteContent.Split(new[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string line in lines)
            {
                string[] credentials = line.Split(':');

                if (credentials.Length == 2)
                {
                    string motherID = credentials[0].Trim();
                    string key = credentials[1].Trim();

                    if (motherID == expectedMotherID && key == expectedKey)
                    {
                        popUp.ShowPopUp("Logged in");

                        
                        string directory = Path.GetDirectoryName(keyPath);
                        if (!Directory.Exists(directory))
                        {
                            Directory.CreateDirectory(directory);
                        }
                        if (!File.Exists(keyPath))
                        {
                            File.WriteAllText(keyPath, expectedKey);
                        }
                        return true;
                    }
                }
            }
            if (File.Exists(keyPath))
            {
                File.Delete(keyPath);
            }
            return false;
        }

        private void SigninButton_Click(object sender, RoutedEventArgs e)
        {
            popUp.ShowPopUp("Request sent!");

            string userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            string key = RandomString(45);
            
            WebhookSend($"```\nUsername: {userName}\n{GetMHWID()}:{key}\n```");
        }

        private static Random random = new Random();

        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#$%^&*()_";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        static async Task WebhookSend(string message)
        {
            string webhookUrl =
                "linktowebhook";
            
            using (HttpClient client = new HttpClient())
            {
                var payload = new
                {
                    content = message
                };

                string jsonPayload = System.Text.Json.JsonSerializer.Serialize(payload);

                var content = new StringContent(jsonPayload, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await client.PostAsync(webhookUrl, content);
            }
        }

        static string GetMHWID()
        {
            ManagementObjectSearcher mos = new ManagementObjectSearcher("SELECT * FROM Win32_BaseBoard");
            ManagementObjectCollection moc = mos.Get();
            string serial = "";
            foreach (ManagementObject mo in moc)
            {
                serial = mo["SerialNumber"].ToString();
            }

            return serial;
        }

        static async Task<string> GetPasteContent(string url)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string content = await client.GetStringAsync(url);
                    return content;
                }
                catch (Exception ex)
                {
                    return null;
                }
            }
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
