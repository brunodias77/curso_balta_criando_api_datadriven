using Microsoft.AspNetCore.Mvc;
using Shop2.Models;

namespace Shop2.Controllers
{
    [Route("categories")]
    public class CategoryController : ControllerBase
    {
        [HttpGet]
        [Route("")]
        public async Task<ActionResult<List<Category>>> MeuMetodoGet()
        {
            return new List<Category>() { };
        }

        [HttpGet]
        [Route("{id:int}")]
        public async Task<ActionResult<Category>> MeuMetodoGetById(int id)
        {
            return new Category() { };
        }

        [HttpPost]
        [Route("")]
        public async Task<ActionResult<Category>> MeuMetodoPost([FromBody] Category model)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            return Ok(model);
        }

        [HttpPut]
        [Route("{id:int}")]
        public async Task<ActionResult<List<Category>>> MeuMetodoPut(int id, [FromBody] Category model)
        {
            // Verifica se o ID informado é o mesmo do modelo
            if (model.Id != id) return NotFound(new { message = "Categoria não encontrada" });
            // Verifica se os dados sao validos
            if (!ModelState.IsValid) return BadRequest(ModelState);
            return BadRequest();
        }

        [HttpDelete]
        [Route("{id:int}")]
        public async Task<ActionResult<List<Category>>> MeuMetodoDelete()
        {
            return Ok();
        }
    }
}

