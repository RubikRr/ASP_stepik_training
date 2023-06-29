using Microsoft.AspNetCore.Mvc;

namespace WomanShop.Controllers
{
    public class CalculatorController : Controller
    {
        public string Index(int x, int y)
        {
            return $"{x}+{y}={x + y}";

        }
    }
}
