namespace WpfApp.Classes;

public class WindowsCheck
{
    public bool IsWindows11() {
        var version = Environment.OSVersion;
        return version.Platform == PlatformID.Win32NT &&
               version.Version.Major == 10 && version.Version.Build >= 22000;
    }
}