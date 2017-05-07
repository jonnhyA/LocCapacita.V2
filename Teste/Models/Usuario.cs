using System;
using System.Collections.Generic;

namespace Teste.Models
{
    public partial class Usuario
    {
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public System.DateTime DtNasc { get; set; }
        public int IdPrfl { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public virtual Prfl Prfl { get; set; }
    }
}
