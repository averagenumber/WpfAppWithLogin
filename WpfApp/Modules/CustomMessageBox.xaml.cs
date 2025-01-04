using System;
using System.IO;
using System.Windows;
using Newtonsoft.Json;
using System.Windows.Media;
using WpfApp.Classes;

namespace WpfApp.CustomMessageBox
{
    public partial class Show : Window
    {
        private const string FolderPath = @"C:\WpfApp";
        private const string FilePath = @"C:\WpfApp\data.json";

        public Show(string title, string message)
        {
            InitializeComponent();
            this.Title = title;
            MessageText.Text = message;
            LoadColorsFromJson("Main");
        }

        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void LoadColorsFromJson(string section)
        {
            try
            {
                string jsonContent = File.ReadAllText(FilePath);
                var colors = JsonConvert.DeserializeObject<ColorConfiguration>(jsonContent);

                if (colors == null) return;

                if (section == "Main")
                {
                    ApplyMainColors(colors.Main);
                }
            }
            catch (Exception ex)
            {
                
            }
        }
        private void ApplyMainColors(ColorSettingsMain settings)
        {
            if (settings == null) return;

            this.Background = TryConvertToColorBrush(settings.Background) ?? this.Background;
            Application.Current.Resources["ButtonBackgroundColor"] = TryConvertToColorBrush(settings.ButtonBackground) ?? Application.Current.Resources["ButtonBackgroundColor"];
            Application.Current.Resources["ButtonBorderColor"] = TryConvertToColorBrush(settings.ButtonBorder) ?? Application.Current.Resources["ButtonBorderColor"];
            Application.Current.Resources["TextForegroundColor"] = TryConvertToColorBrush(settings.TextForeground) ?? Application.Current.Resources["TextForegroundColor"];
        }

        private SolidColorBrush TryConvertToColorBrush(string colorString)
        {
            try
            {
                var color = (Color)ColorConverter.ConvertFromString(colorString);
                return new SolidColorBrush(color);
            }
            catch
            {
                return null;
            }
        }
    }
}
