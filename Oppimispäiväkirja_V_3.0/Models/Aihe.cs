using System;
using System.ComponentModel.DataAnnotations;

namespace Oppimispäiväkirja_V_3._0.Models
{
    public class Aihe
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Syötä otsikko")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Syötä kuvaus")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Syötä arvioitu kesto")]
        public int TimeToMaster { get; set; }
        [Required(ErrorMessage = "Syötä käytetty aika")]
        public int TimeSpent { get; set; }
        [Required(ErrorMessage = "Syötä lähde")]
        public string Source { get; set; }
        [Required(ErrorMessage = "Syötä aloitus ajankohta")]
        public DateTime StartLearningDate { get; set; }
        [Required(ErrorMessage = "Valitse onko aihe yhä kesken")]
        public bool? InProgress { get; set; }
        [Required(ErrorMessage = "Syötä lopetus ajankohta")]
        public DateTime CompletionDate { get; set; }
    }
}
