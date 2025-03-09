using CadastroDeProdutos.Data;
using CadastroDeProdutos.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace CadastroDeProdutos.Controllers
{
    public class ProdutoController : Controller
    {
        private readonly AppDbContext _context;

        public ProdutoController(AppDbContext context)
        {
            _context = context;
        }

        // Exibir lista de produtos
        public async Task<IActionResult> Index()
        {
            // Busca os produtos do banco e retorna para a View
            var produtos = await _context.Produtos.ToListAsync();
            return View(produtos);
        }

        // Exibir o formulário para adicionar um novo produto
        public IActionResult Create()
        {
            return View();
        }

        // Processar o envio do formulário para criar um novo produto
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Nome,Categoria,Descricao,Imagem,Preco")] Produto produto)
        {
            if (ModelState.IsValid)
            {
                _context.Add(produto);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index)); // Redireciona para a página de produtos após salvar
            }
            return View(produto); // Se houver erros, retorna à página de criação
        }
    }
}
