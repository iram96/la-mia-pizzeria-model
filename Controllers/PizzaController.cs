using la_mia_pizzeria_static.Models;
using Microsoft.AspNetCore.Mvc;

namespace la_mia_pizzeria_static.Controllers
{
    public class PizzaController : Controller
    {
        //List<Pizza> pizzaList = new List<Pizza>();
        public static pizzaList pizze;
        public IActionResult Pizzeria()
        {
            pizze = new pizzaList();


            Pizza Pizza1 = new Pizza("Margherita", "Pomodoro Mozzarella", 10);

            Pizza Pizza2 = new Pizza("Marinara", "Pomodoro Origano", 10);

            Pizza Pizza3 = new Pizza("Diavola", "Pomodoro Mozzarella Salame piccante", 15);


            pizze.ListaPizze.Add(Pizza1);
            pizze.ListaPizze.Add(Pizza2);
            pizze.ListaPizze.Add(Pizza3);

            return View(pizze);
        }
    }
}
