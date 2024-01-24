using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudAvaloniaUI.Models
{
    public class Pessoas
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public int Idade { get; set; }

        public List<Pessoas> ListaPessoas { get; set; } 
    }
}
