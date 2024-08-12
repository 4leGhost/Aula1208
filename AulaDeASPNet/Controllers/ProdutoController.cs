using AulaDeASPNet.Data;
using AulaDeASPNet.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AulaDeASPNet.Controllers
{
    public class ProdutoController : Controller
    {
        private readonly AulaContext _context;

        public ProdutoController(AulaContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> BuscarProduto()
        {
            return View(await _context.Clientes.ToListAsync());
        }
        public async Task<IActionResult> DetalhesProduto(int id)
        {
            return View(await _context.Clientes.FindAsync());
        }
        public async Task<IActionResult> AlterarProduto(int id)
        {
            return View(await _context.Clientes.FindAsync(id));
        }

        public async Task<IActionResult> CadastroProdutoAsync(int? id)
        {
            {
                if (id == null)
                {
                    return View();
                }
                else
                {
                    return View(await _context.Produtos.FindAsync(id));
                }
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CadastroProduto(
           [Bind("Descricao,Marca,Categoria,Preco,Qtde,Peso,Largura,Altura")]
            Produto produto)
        {
            if (ModelState.IsValid)
            {
                _context.Add(produto);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", "NossoApp");
            }
            return View(produto);
        }
    }
}
