using ContasMVC.Data;
using ContasMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ContasMVC.Controllers;

public class DespesasController : Controller
{
    private readonly ContasDbContext _contasdb;

    public DespesasController(ContasDbContext contasdb)
    {
        _contasdb = contasdb;
    }

    [HttpGet]
    public IActionResult AdicionarDespesa()
    {
        return View();
    }
    
    [HttpPost]
    public async Task<IActionResult> Adicionar(DespesaModel despesa)
    {
        if (!ModelState.IsValid)
        {
            return RedirectToAction("Adicionar");
        }

        _contasdb.Despesas.Add(despesa);
        await _contasdb.SaveChangesAsync();
        return RedirectToAction("Index", "Home");
    }

    [HttpGet]
    public async Task<IActionResult> Listar()
    {
        var listaDeDespesas = await _contasdb.Despesas.ToListAsync();
        return View("ListarDespesas", listaDeDespesas);
    }
}