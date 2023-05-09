using Microsoft.AspNetCore.Mvc;

namespace FirstProject.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "P327 Home Page";
        }

        public string About()
        {
            return "P327 About Page";
        }

        public string Detail(int? id)
        {
            return $"P327 Student id: {id}";
        }
    }
}
