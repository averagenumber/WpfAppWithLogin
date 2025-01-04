using System.Security.Principal;

namespace WpfApp.Classes;

public class GetUserId
{
    public string GetUserSid() {
        try {
            var user = WindowsIdentity.GetCurrent();
            var sid = user.User.Value;
            return sid;
        } catch (Exception ex) {
            Console.WriteLine($"Error retrieving user SID: {ex.Message}");
            return string.Empty;
        }
    }
}