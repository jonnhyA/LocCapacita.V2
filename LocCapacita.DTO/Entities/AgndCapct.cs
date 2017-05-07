using System;
using System.Collections.Generic;

namespace LocCapacita.DTO.Entities
{
    public partial class AgndCapct
    {
        public AgndCapct()
        {
            this.Avalcs = new List<Avalc>();
            this.PrflInscritoes = new List<PrflInscrito>();
        }

        public int IdAgndCapct { get; set; }
        public int IdDetlheCapct { get; set; }
        public int TpoCapct { get; set; }
        public int IdPrflInstrutor { get; set; }
        public int IdLocal { get; set; }
        public System.DateTime DtInit { get; set; }
        public System.DateTime DtFim { get; set; }
        public System.TimeSpan HrInit { get; set; }
        public System.TimeSpan HrFim { get; set; }
        public bool Cetficado { get; set; }
        public bool PrepCerticacao { get; set; }
        public int IdPrfl { get; set; }
        public int CargaHr { get; set; }
        public virtual DetlheCapct DetlheCapct { get; set; }
        public virtual Prfl Prfl { get; set; }
        public virtual Prfl Prfl1 { get; set; }
        public virtual ICollection<Avalc> Avalcs { get; set; }
        public virtual ICollection<PrflInscrito> PrflInscritoes { get; set; }
    }
}
