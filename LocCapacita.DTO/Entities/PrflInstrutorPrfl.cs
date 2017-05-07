using System;
using System.Collections.Generic;

namespace LocCapacita.DTO.Entities
{
    public partial class PrflInstrutorPrfl
    {
        public int IdPrfl { get; set; }
        public int IdPrflInstrutor { get; set; }
        public System.DateTime DtCad { get; set; }
        public System.DateTime DtFim { get; set; }
        public virtual Prfl Prfl { get; set; }
        public virtual Prfl Prfl1 { get; set; }
        public virtual Prfl Prfl2 { get; set; }
    }
}
