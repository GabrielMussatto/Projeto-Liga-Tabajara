using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projeto_Liga_Tabajara.Models
{
	public class Liga
	{
        public int Id { get; set; }
        public string Nome { get; set; } = "Liga Tabajara de Futebol";
        public bool Status { get; set; }

        public virtual ICollection<Time> Times { get; set; }
    }
}