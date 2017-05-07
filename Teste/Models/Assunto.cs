using System;
using System.Collections.Generic;

namespace Teste.Models
{
    public partial class Assunto
    {
        public int IdAsstn { get; set; }
        public string NomeAssnt { get; set; }
        public string DescrAssnt { get; set; }
        public System.DateTime DtCad { get; set; }
        public virtual AssuntoAvalc AssuntoAvalc { get; set; }
    }
}
