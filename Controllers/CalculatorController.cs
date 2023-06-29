using Microsoft.AspNetCore.Mvc;

namespace WomanShop.Controllers
{
    public class CalculatorController : Controller
    {
        public string Index(int x, int y,string operation)
        {
            switch (operation)
            {
                case "+":
                    return $"{x}+{y}={x + y}";
                case "-":
                    return $"{x}-{y}={x - y}";
                case "*":
                    return $"{x}*{y}={x * y}";
                case null:
                    return $"{x}+{y}={x + y}";
                default:
                    return "Неправильный формат передачи\nВозможны 3 варинта:*,-,+";
            }
        }
    }
}
