using System;
using System.Collections.Generic;

namespace Teste.Models
{
    public partial class DetlheCapct
    {
        public DetlheCapct()
        {
            this.AgndCapcts = new List<AgndCapct>();
        }

        public int IdDetlheCapct { get; set; }
        public int IdCapct { get; set; }
        public int IdPrflv { get; set; }
        public string DescrCapct { get; set; }
        public virtual ICollection<AgndCapct> AgndCapcts { get; set; }
        public virtual Capct Capct { get; set; }
        public virtual Prfl Prfl { get; set; }
    }
}
