namespace WpfApp.Classes;

public class ColorConfiguration {
    public ColorSettingsMain Main { get; set; }
    public ColorSettingsFrame Frame { get; set; }
}

public class ColorSettingsMain {
    public string Background { get; set; }
    public string BackgroundGradientStart { get; set; }
    public string BackgroundGradientEnd { get; set; }
    public string ScrollBarThumb { get; set; }
    public string ButtonBackground { get; set; }
    public string ButtonBorder { get; set; }
    public string TextForeground { get; set; }
}

public class ColorSettingsFrame {
    public string Background { get; set; }
    public string BackgroundGradientStart { get; set; }
    public string BackgroundGradientEnd { get; set; }
    public string MenuBackgroundStart { get; set; }
    public string MenuBackgroundMiddle { get; set; }
    public string MenuBackgroundEnd { get; set; }
    public string ScrollBarThumb { get; set; }
    public string ButtonBackground { get; set; }
    public string TextForeground { get; set; }
}