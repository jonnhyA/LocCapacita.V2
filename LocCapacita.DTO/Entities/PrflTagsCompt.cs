using System;
using System.Collections.Generic;

namespace LocCapacita.DTO.Entities
{
    public partial class PrflTagsCompt
    {
        public int IdPrfl { get; set; }
        public int IdTagsCompt { get; set; }
        public System.DateTime DtCad { get; set; }
        public virtual Prfl Prfl { get; set; }
        public virtual TagsCompt TagsCompt { get; set; }
    }
}
