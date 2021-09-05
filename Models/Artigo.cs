using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projeto_ASP.Models
{
    public class Artigo
    {
        //Chave Primaria
        public int IdArtigo { get; set; }

        public int IdEntidade { get; set; }

        public int StockMinimo { get; set; }

        public string NomeArtigo { get; set; }

        public double Preco { get; set; }

        //Chave Estrangeira
        public int IdTipoDeAtigo { get; set; }

    }
}