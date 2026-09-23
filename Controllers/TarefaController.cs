using Microsoft.AspNetCore.Mvc;

namespace Lista_de_tarefas.Controllers
{
    public class TarefaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
