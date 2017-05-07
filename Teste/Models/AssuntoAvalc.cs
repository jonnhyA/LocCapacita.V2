using System;
using System.Collections.Generic;

namespace Teste.Models
{
    public partial class AssuntoAvalc
    {
        public Nullable<int> IdAvalcAssnt { get; set; }
        public int IdAsstn { get; set; }
        public Nullable<int> IdPrfl { get; set; }
        public virtual Assunto Assunto { get; set; }
        public virtual Avalc Avalc { get; set; }
    }
}
