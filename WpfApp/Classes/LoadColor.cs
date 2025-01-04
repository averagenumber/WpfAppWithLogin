using System.IO;
using System.Windows;
using System.Windows.Media;
using WpfApp.Classes;
using Newtonsoft.Json;

public class LoadColor
{
    private const string FolderPath = @"C:\WpfApp";
    private const string FilePath = @"C:\WpfApp\data.json";

    public void LoadColorsFromJson(string section)
    {
        try
        {
            EnsureDirectoryAndFileExists();

            string jsonContent = File.ReadAllText(FilePath);
            var colors = JsonConvert.DeserializeObject<ColorConfiguration>(jsonContent);

            if (colors == null) return;

            switch (section)
            {
                case "Main":
                    ApplyMainColors(colors.Main);
                    break;
                case "Frame":
                    ApplyFrameColors(colors.Frame);
                    break;
            }
        }
        catch (Exception ex)
        {
           
        }
    }

    private void EnsureDirectoryAndFileExists()
    {
        try
        {
            if (!Directory.Exists(FolderPath))
            {
                Directory.CreateDirectory(FolderPath);
            }

            if (!File.Exists(FilePath) || new FileInfo(FilePath).Length == 0)
            {
                var defaultSettings = new ColorConfiguration
                {
                    Main = new ColorSettingsMain
                    {
                        BackgroundGradientStart = "#156B8F",
                        BackgroundGradientEnd = "#7CDFEA",
                        ScrollBarThumb = "#E3AFFC",
                        ButtonBackground = "#EBF9F5",
                        ButtonBorder = "#0C4D50",
                        TextForeground = "#0F4861"
                    },
                    Frame = new ColorSettingsFrame
                    {
                        BackgroundGradientStart = "#156B8F",
                        BackgroundGradientEnd = "#7CDFEA",
                        MenuBackgroundStart = "#85BBB7",
                        MenuBackgroundMiddle = "#FCFCFC",
                        MenuBackgroundEnd = "#6CA4AA",
                        ScrollBarThumb = "#E3AFFC",
                        ButtonBackground = "#EBF9F5",
                        TextForeground = "#0F4861"
                    }
                };

                string defaultJson = JsonConvert.SerializeObject(defaultSettings, Formatting.Indented);
                File.WriteAllText(FilePath, defaultJson);
            }
        }
        catch (Exception ex)
        {
        }
    }

    private void ApplyMainColors(ColorSettingsMain settings)
    {
        if (settings == null) return;

        Application.Current.Resources["BackgroundColor"] = new LinearGradientBrush(
            new GradientStopCollection
            {
                new GradientStop((Color)ColorConverter.ConvertFromString(settings.BackgroundGradientStart), 0.0),
                new GradientStop((Color)ColorConverter.ConvertFromString(settings.BackgroundGradientEnd), 1.0)
            },
            90
        );

        Application.Current.Resources["ScrollBarThumbColor"] = new SolidColorBrush((Color)ColorConverter.ConvertFromString(settings.ScrollBarThumb));
        Application.Current.Resources["ButtonBackgroundColor"] = new SolidColorBrush((Color)ColorConverter.ConvertFromString(settings.ButtonBackground));
        Application.Current.Resources["ButtonBorderColor"] = new SolidColorBrush((Color)ColorConverter.ConvertFromString(settings.ButtonBorder));
        Application.Current.Resources["TextForegroundColor"] = new SolidColorBrush((Color)ColorConverter.ConvertFromString(settings.TextForeground));
    }

    private void ApplyFrameColors(ColorSettingsFrame settings)
    {
        if (settings == null) return;
        
        Application.Current.Resources["BackgroundColor"] = new LinearGradientBrush(
            new GradientStopCollection
            {
                new GradientStop((Color)ColorConverter.ConvertFromString(settings.BackgroundGradientStart), 0.0),
                new GradientStop((Color)ColorConverter.ConvertFromString(settings.BackgroundGradientEnd), 1.0)
            },
            90
        );
        
        Application.Current.Resources["MenuBackgroundColor"] = new LinearGradientBrush(
            new GradientStopCollection
            {
                new GradientStop((Color)ColorConverter.ConvertFromString(settings.MenuBackgroundStart), 0.0),
                new GradientStop((Color)ColorConverter.ConvertFromString(settings.MenuBackgroundMiddle), 0.5),
                new GradientStop((Color)ColorConverter.ConvertFromString(settings.MenuBackgroundEnd), 1.0)
            },
            90
        );
        
        Application.Current.Resources["ScrollBarThumbColor"] = new SolidColorBrush((Color)ColorConverter.ConvertFromString(settings.ScrollBarThumb));
        Application.Current.Resources["ButtonBackgroundColor"] = new SolidColorBrush((Color)ColorConverter.ConvertFromString(settings.ButtonBackground));
        Application.Current.Resources["TextForegroundColor"] = new SolidColorBrush((Color)ColorConverter.ConvertFromString(settings.TextForeground));
    }
}
