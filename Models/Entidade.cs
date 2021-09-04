using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projeto_ASP.Models
{
    public class Entidade
    {
        public int IdEntidade { get; set; }
        public string Designacao { get; set; }

        public virtual ICollection <Movimento> Movimentos {get; set;}
    }
}