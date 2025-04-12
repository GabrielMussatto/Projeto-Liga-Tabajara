using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;

namespace Projeto_Liga_Tabajara.Models
{
	public class Time
	{
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public DateTime AnoFundacao { get; set; }
        public string Estadio { get; set; }
        public int CapacidadeEstadio { get; set; }
        public string CorUniformePrimaria { get; set; }
        public string CorUniformeSecundaria { get; set; }
        public bool Status { get; set; }

        public virtual ICollection<Jogador> Jogadores { get; set; } = new List<Jogador>();
        public virtual ICollection<ComissaoTecnica> ComissaoTecnica { get; set; } = new List<ComissaoTecnica>();

    }
}