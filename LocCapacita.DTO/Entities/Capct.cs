using System;
using System.Collections.Generic;

namespace LocCapacita.DTO.Entities
{
    public partial class Capct
    {
        public Capct()
        {
            this.DetlheCapcts = new List<DetlheCapct>();
        }

        public int IdCapct { get; set; }
        public string NomeCapct { get; set; }
        public int IdPrflCad { get; set; }
        public System.DateTime DtCad { get; set; }
        public virtual Prfl Prfl { get; set; }
        public virtual ICollection<DetlheCapct> DetlheCapcts { get; set; }
    }
}
