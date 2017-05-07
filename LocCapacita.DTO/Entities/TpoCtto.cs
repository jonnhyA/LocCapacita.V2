using System;
using System.Collections.Generic;

namespace LocCapacita.DTO.Entities
{
    public partial class TpoCtto
    {
        public int IdTpoCtto { get; set; }
        public string NomeCtto { get; set; }
        public System.DateTime DtCad { get; set; }
        public Nullable<System.DateTime> DtFimCad { get; set; }
    }
}
