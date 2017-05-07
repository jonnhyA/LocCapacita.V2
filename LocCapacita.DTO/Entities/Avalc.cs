using System;
using System.Collections.Generic;

namespace LocCapacita.DTO.Entities
{
    public partial class Avalc
    {
        public Avalc()
        {
            this.AssuntoAvalcs = new List<AssuntoAvalc>();
        }

        public int IdAvalc { get; set; }
        public int IdPrflAvalc { get; set; }
        public double Valor { get; set; }
        public string Coment { get; set; }
        public System.DateTime DtAvalc { get; set; }
        public bool Ativo { get; set; }
        public Nullable<int> IdAgndCapct { get; set; }
        public Nullable<int> IdPrfl { get; set; }
        public virtual AgndCapct AgndCapct { get; set; }
        public virtual ICollection<AssuntoAvalc> AssuntoAvalcs { get; set; }
        public virtual Prfl Prfl { get; set; }
        public virtual Prfl Prfl1 { get; set; }
    }
}
