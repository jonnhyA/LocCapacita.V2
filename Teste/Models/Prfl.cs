using System;
using System.Collections.Generic;

namespace Teste.Models
{
    public partial class Prfl
    {
        public Prfl()
        {
            this.AgndCapcts = new List<AgndCapct>();
            this.AgndCapcts1 = new List<AgndCapct>();
            this.Avalcs = new List<Avalc>();
            this.Avalcs1 = new List<Avalc>();
            this.Capcts = new List<Capct>();
            this.Contatoes = new List<Contato>();
            this.DetlheCapcts = new List<DetlheCapct>();
            this.Empresas = new List<Empresa>();
            this.Usuarios = new List<Usuario>();
            this.PrflInscritoes = new List<PrflInscrito>();
            this.PrflInstrutorPrfls = new List<PrflInstrutorPrfl>();
            this.PrflInstrutorPrfls1 = new List<PrflInstrutorPrfl>();
            this.PrflInstrutorPrfls2 = new List<PrflInstrutorPrfl>();
            this.PrflTagsCompts = new List<PrflTagsCompt>();
            this.Representantes = new List<Representante>();
            this.Representantes1 = new List<Representante>();
        }

        public int IdPrfl { get; set; }
        public string ImgPrfl { get; set; }
        public System.DateTime DtCadPrfl { get; set; }
        public int TpoPrfl { get; set; }
        public string DescrPrfl { get; set; }
        public virtual ICollection<AgndCapct> AgndCapcts { get; set; }
        public virtual ICollection<AgndCapct> AgndCapcts1 { get; set; }
        public virtual ICollection<Avalc> Avalcs { get; set; }
        public virtual ICollection<Avalc> Avalcs1 { get; set; }
        public virtual ICollection<Capct> Capcts { get; set; }
        public virtual ICollection<Contato> Contatoes { get; set; }
        public virtual ICollection<DetlheCapct> DetlheCapcts { get; set; }
        public virtual ICollection<Empresa> Empresas { get; set; }
        public virtual ICollection<Usuario> Usuarios { get; set; }
        public virtual ICollection<PrflInscrito> PrflInscritoes { get; set; }
        public virtual ICollection<PrflInstrutorPrfl> PrflInstrutorPrfls { get; set; }
        public virtual ICollection<PrflInstrutorPrfl> PrflInstrutorPrfls1 { get; set; }
        public virtual ICollection<PrflInstrutorPrfl> PrflInstrutorPrfls2 { get; set; }
        public virtual ICollection<PrflTagsCompt> PrflTagsCompts { get; set; }
        public virtual ICollection<Representante> Representantes { get; set; }
        public virtual ICollection<Representante> Representantes1 { get; set; }
    }
}
