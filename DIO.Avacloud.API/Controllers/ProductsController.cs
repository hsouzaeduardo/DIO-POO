using DIO.Avacloud.Entidades;
using DIO.Avacloud.Entidades.Contrato;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DIO.Avacloud.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IRepository<Product> _repository;
        public ProductsController(IRepository<Product> repository)
        {
            _repository = repository; 
        }

        // GET: api/<ProductsController>
        [HttpGet]
        public async Task<IEnumerable<Product>> Get()
        {
            return await _repository.GetAllAsync();
        }

        // GET api/<ProductsController>/5
        [HttpGet("{id}")]
        public async Task<Product> Get(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        // POST api/<ProductsController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Product produto)
        {
            if (produto.Validate())
            {
                int result = await _repository.AddAsync(produto);
                return StatusCode(201, new { id = result });
            }

            return StatusCode(403, "Produto Inválido");
        }

        // PUT api/<ProductsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ProductsController>/5
        [HttpDelete]
        public async Task<IActionResult> Delete([FromBody] Product produto)
        {
            await _repository.DeleteAsync(produto);

            return Ok("Produto excluido com sucesso");
        }
    }
}
