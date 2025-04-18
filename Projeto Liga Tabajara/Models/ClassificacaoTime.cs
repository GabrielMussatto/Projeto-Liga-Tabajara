using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projeto_Liga_Tabajara.Models
{
    public class ClassificacaoTime
    {
        public int TimeId { get; set; }
        public string TimeNome { get; set; }
        public int Pontos { get; set; }
        public int Jogos { get; set; }
        public int Vitorias { get; set; }
        public int Empates { get; set; }
        public int Derrotas { get; set; }
        public int GolsPro { get; set; }
        public int GolsContra { get; set; }
        public int SaldoGols => GolsPro - GolsContra;
    }
}