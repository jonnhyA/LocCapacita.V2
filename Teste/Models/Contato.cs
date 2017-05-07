using System;
using System.Collections.Generic;

namespace Teste.Models
{
    public partial class Contato
    {
        public int IdCtto { get; set; }
        public Nullable<int> IdPrfl { get; set; }
        public int IdTpoCtto { get; set; }
        public string DescrCtto { get; set; }
        public virtual Prfl Prfl { get; set; }
    }
}
