using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projeto_Liga_Tabajara.Models
{
	public enum Posicao
	{
        Goleiro, Zagueiro, Volante, Meia, Atacante, Pontadireita, Pontaesquerda, Lateraldireito, Lateralesquerdo
    }

	public enum PePreferido
	{
		Direito, Esquerdo, Ambidestro
	}
	public class Jogador
	{
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Nacionalidade { get; set; }
        public Posicao Posicao { get; set; }
        public int NumeroCamisa { get; set; }
        public double Altura { get; set; }
        public double Peso { get; set; }
        public PePreferido PePreferido { get; set; }

        public int TimeId { get; set; }
        public virtual Time Time { get; set; }

    }
}