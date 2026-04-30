using Microsoft.AspNetCore.Mvc;

namespace DemoApp1ForDotnet.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: /HelloWorld/
        public string Index()
        {
            return "This is my default action...";
        }

        // GET: /HelloWorld/Welcome/ 
        public string Welcome()
        {
            return "This is the Welcome action method...";
        }

        static List<string> names = new List<string>() { "Alice", "Bob", "Charlie" };

        public string GetNames()
        {
            return string.Join(", ", names);
        }
    }
}
