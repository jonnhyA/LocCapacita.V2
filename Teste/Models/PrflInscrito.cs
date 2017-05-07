using System;
using System.Collections.Generic;

namespace Teste.Models
{
    public partial class PrflInscrito
    {
        public int IdPrflInscrito { get; set; }
        public int IdPrfl { get; set; }
        public int AgndCapct { get; set; }
        public bool Pago { get; set; }
        public Nullable<System.DateTime> DtPago { get; set; }
        public virtual AgndCapct AgndCapct1 { get; set; }
        public virtual Prfl Prfl { get; set; }
    }
}
