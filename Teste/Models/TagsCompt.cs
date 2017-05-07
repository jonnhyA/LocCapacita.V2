using System;
using System.Collections.Generic;

namespace Teste.Models
{
    public partial class TagsCompt
    {
        public TagsCompt()
        {
            this.PrflTagsCompts = new List<PrflTagsCompt>();
        }

        public int IdTagsCompt { get; set; }
        public string NomeCompt { get; set; }
        public System.DateTime DtCad { get; set; }
        public virtual ICollection<PrflTagsCompt> PrflTagsCompts { get; set; }
    }
}
