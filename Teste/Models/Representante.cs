using System;
using System.Collections.Generic;

namespace Teste.Models
{
    public partial class Representante
    {
        public int IdRpstt { get; set; }
        public int IdPrflRpstt { get; set; }
        public int IdPrfl { get; set; }
        public System.DateTime DtCad { get; set; }
        public Nullable<System.DateTime> DtCadFim { get; set; }
        public virtual Prfl Prfl { get; set; }
        public virtual Prfl Prfl1 { get; set; }
    }
}
