using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Projeto_Liga_Tabajara.Models
{
	public enum Posicao
	{
        Goleiro, Zagueiro, Volante, Meia, Atacante, Lateraldireito, Lateralesquerdo
    }

	public enum PePreferido
	{
		Direito, Esquerdo, Ambidestro
	}
	public class Jogador
	{
        public int Id { get; set; }
        [Display(Name = "Nome do Jogador")]
        public string Nome { get; set; }
        [Display(Name = "Data de Nascimento")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DataNascimento { get; set; }
        public string Nacionalidade { get; set; }
        public Posicao Posicao { get; set; }
        [Display(Name = "Número Camisa")]
        public int NumeroCamisa { get; set; }

        [DisplayFormat(DataFormatString = "{0:0.00}", ApplyFormatInEditMode = true)]
        [Display(Name = "Altura (m)")]
        public double Altura { get; set; }

        [DisplayFormat(DataFormatString = "{0:0.00}", ApplyFormatInEditMode = true)]
        [Display(Name = "Peso (kg)")]
        public double Peso { get; set; }

        [Display(Name = "Pé Preferido")]
        public PePreferido PePreferido { get; set; }

        public int TimeId { get; set; }
        public virtual Time Time { get; set; }

    }
}