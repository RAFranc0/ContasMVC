using ContasMVC.Data;
using ContasMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ContasMVC.Controllers;

public class ReceitasController : Controller
{
    private readonly ContasDbContext _contasdb;

    public ReceitasController(ContasDbContext contasdb)
    {
        _contasdb = contasdb;
    }

    [HttpGet]
    public IActionResult AdicionarReceita()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Adicionar(ReceitaModel receita)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest();
        }

        _contasdb.Receitas.Add(receita);
        await _contasdb.SaveChangesAsync();
        return RedirectToAction("Index", "Home");
    }

    [HttpGet]
    public async Task<IActionResult> Listar()
    {
        var listaDeReceitas = await _contasdb.Receitas.ToListAsync();
        return View("ListarReceitas", listaDeReceitas);
    }
}