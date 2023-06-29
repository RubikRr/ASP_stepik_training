using Microsoft.AspNetCore.Mvc;

namespace WomanShop.Controllers
{
    public class StartController : Controller
    {
        public string Hello()
        {
            var hours=DateTime.Now.TimeOfDay.Hours;
            if (hours >= 0 && hours <= 5)
            {
                return "Ночь";
            }
            else if (hours >= 6 && hours <= 11)
            {
                return "Утро";
            }
            else if (hours >= 12 && hours <= 17)
            {
                return "День";
            }
            else if (hours >= 18 && hours <= 23)
            {
                return "Вечер";
            }
            else
            {
                return "Вы на другой планете";
            }
            
        }
    }
}
