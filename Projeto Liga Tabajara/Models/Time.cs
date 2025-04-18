using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Web;

namespace Projeto_Liga_Tabajara.Models
{
	public class Time
	{
        public int Id { get; set; }
        [Display(Name = "Nome do Time")]
        public string Nome { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        [Display(Name = "Ano de Fundação")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy}", ApplyFormatInEditMode = true)]
        public DateTime AnoFundacao { get; set; }
        public string Estadio { get; set; }
        [Display(Name = "Capacidade Estádio")]
        public int CapacidadeEstadio { get; set; }
        [Display(Name = "Cor Uniforme Primária")]
        public string CorUniformePrimaria { get; set; }
        [Display(Name = "Cor Uniforme Secundária")]
        public string CorUniformeSecundaria { get; set; }
        public bool Status { get; set; }

        public virtual ICollection<Jogador> Jogadores { get; set; }
        public virtual ICollection<ComissaoTecnica> ComissaoTecnica { get; set; }

    }
}