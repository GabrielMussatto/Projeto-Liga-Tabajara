using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Projeto_Liga_Tabajara.Models
{
    public enum Resultado
    {
        VitoriaMandante,
        VitoriaVisitante,
        Empate,
        NaoRealizada
    }

    public class Partida
    {
        public int Id { get; set; }
        [Display(Name = "Data da Partida")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Data { get; set; }
        public int Rodada { get; set; }
        public string Estadio { get; set; }

        public int TimeMandanteId { get; set; }
        public virtual Time TimeMandante { get; set; }

        public int TimeVisitanteId { get; set; }
        public virtual Time TimeVisitante { get; set; }

        public int GolsMandante { get; set; }
        public int GolsVisitante { get; set; }
        public Resultado Resultado { get; set; }

        public virtual ICollection<Estatistica> Estatisticas { get; set; }
    }

}