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

        despesa.Data = DateTime.UtcNow;

        _contasdb.Despesas.Add(despesa);
        await _contasdb.SaveChangesAsync();
        return RedirectToAction("Listar");
    }

    [HttpGet]
    public async Task<IActionResult> Listar()
    {
        var listaDeDespesas = await _contasdb.Despesas.ToListAsync();
        return View("ListarDespesas", listaDeDespesas);
    }

    [HttpPost]
    public async Task<IActionResult> Remover(Guid? Id)
    {
        if (Id == null)
        {
            return NotFound();
        }

        var despesa = await _contasdb.Despesas.FindAsync(Id);
        if (despesa == null)
        {
            return NotFound();
        }

        _contasdb.Despesas.Remove(despesa);
        await _contasdb.SaveChangesAsync();

        return RedirectToAction("Listar");
    }
}