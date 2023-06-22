using Microsoft.AspNetCore.Mvc;

namespace Shop2.Controllers
{
    [Route("categories")]
    public class CategoryController : ControllerBase
    {
        [HttpGet]
        [Route("")]
        public string MeuMetodoGet()
        {
            return "Voce requisitou um metodo get na api do bruno dias";
        }
        [HttpPost]
        [Route("")]
        public string MeuMetodoPost()
        {
            return "Voce requisitou um metodo Post";
        }
    }
}

