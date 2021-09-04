using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projeto_ASP.Models
{
    public class Movimento
    {
        public int IdMovimento { get; set; }
        public int IdArtigo { get; set; }
        public int IdFornecedor { get; set; }

        public string NumDoc { get; set; }

        public int Quantidade { get; set; }

        public string TipoMovimento { get; set; }
    }
}