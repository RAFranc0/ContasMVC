using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContasMVC.Models
{
    public class ReceitaModel
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public double Valor { get; set; }
        public string Usuario { get; set; } = string.Empty;
        public string Tipo { get; set; } = string.Empty;
    }
}