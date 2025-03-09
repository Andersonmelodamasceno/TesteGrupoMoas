using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using CadastroDeProdutos.Models;
using CadastroDeProdutos.Data;

namespace CadastroDeProdutos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApiProductController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ApiProductController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/ApiProduct
        [HttpGet]
        public ActionResult<IEnumerable<Produto>> GetProdutos()
        {
            var produtos = _context.Produtos.ToList();
            return Ok(produtos);
        }
    }
}
