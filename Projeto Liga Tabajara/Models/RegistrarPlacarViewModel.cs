using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Projeto_Liga_Tabajara.Models
{
    public class JogadorGolsViewModel
    {
        public int JogadorId { get; set; }
        public string Nome { get; set; }
        public Posicao Posicao { get; set; }

        [Range(0, 20, ErrorMessage = "Gols deve ser >= 0")]
        public int Gols { get; set; }
    }

    public class RegistrarPlacarViewModel
    {
        public int PartidaId { get; set; }
        public string MandanteNome { get; set; }
        public string VisitanteNome { get; set; }
        public DateTime Data { get; set; }

        public List<JogadorGolsViewModel> Mandante { get; set; }
        public List<JogadorGolsViewModel> Visitante { get; set; }
    }
}
