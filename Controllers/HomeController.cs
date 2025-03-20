using System.Diagnostics;
using ContasMVC.Data;
using Microsoft.AspNetCore.Mvc;
using ContasMVC.Models;
using ContasMVC.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace ContasMVC.Controllers;

public class HomeController : Controller
{
    private readonly ContasDbContext _contasdb;

    public HomeController(ContasDbContext contasdb)
    {
        _contasdb = contasdb;
    }
    
    public async Task<IActionResult> Index()
    {
        var visaoGeral = new VisaoGeralViewModel();
        
        visaoGeral.VisaoGeralDespesas = await _contasdb.Despesas.ToListAsync();
        visaoGeral.VisaoGeralReceitas = await _contasdb.Receitas.ToListAsync();
        
        return View(visaoGeral);
    }

    public IActionResult Privacy()
    {
        return View();
    }
}
