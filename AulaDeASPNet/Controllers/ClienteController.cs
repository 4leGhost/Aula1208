using AulaDeASPNet.Data;
using AulaDeASPNet.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AulaDeASPNet.Controllers
{
    public class ClienteController : Controller
    {
        private readonly AulaContext _context;

        public ClienteController(AulaContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> BuscarCliente()
        {
            return View(await _context.Clientes.ToListAsync());
        }
        public async Task<IActionResult> DetalhesCliente(int id)
        {
            return View(await _context.Clientes.FindAsync(id));
        }
        public async Task<IActionResult> AlterarCliente(int id)
        {
            return View(await _context.Clientes.FindAsync(id));
        }

        public async Task<IActionResult> CadastroCliente(int? id)
        {
            if (id == null)
            {
                return View();
            }
            else
            {
                return View(await _context.Clientes.FindAsync(id));
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CadastroCliente(
            [Bind("Nome, CPF, RG,Telefone, Email, Usuario, Senha," +
            "CEP,UF,Cidade,Bairro,Rua,Numero,Complemento")]
            Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                if (cliente.Id != 0)
                {
                    _context.Update(cliente);
                    await _context.SaveChangesAsync();

                }
                else
                {
                    _context.Add(cliente);
                    await _context.SaveChangesAsync();
                }
                return RedirectToAction("BuscarClientes");
            }
            return View(cliente);
        }
    }
}