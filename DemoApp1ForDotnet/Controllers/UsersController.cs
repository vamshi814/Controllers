using Microsoft.AspNetCore.Mvc;

namespace DemoApp1ForDotnet.Controllers
{
    public class UsersController : Controller
    {
        static List<string> users = new List<string>
        {
            "Alice",
            "Bob",
            "Charlie"
        };

        public string Index()
        {
            return string.Join(", ", users);
        }
    }
}
