using ContasMVC.Models;

namespace ContasMVC.ViewModels;

public class VisaoGeralViewModel
{
    public List<DespesaModel> VisaoGeralDespesas { get; set; }
    public List<ReceitaModel> VisaoGeralReceitas { get; set; }
}