using Chat.Desktop.ViewModels;
using System.Net;

namespace Chat.Desktop.Helpers
{
    public class User
    {
        public static CookieContainer AuthCookie { get; set; }
        public static RoomViewModel CurrentRoom { get; set; }
    }
}