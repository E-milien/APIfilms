using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace APIfilms.Models.EntityFramework
{
    [Table("t_e_film_flm")]
    public class Film
    {
        public Film()
        {
            
        }

        [Column("flm_id")]
        public int Flm_id { get; set; }

        [Column("flm_titre")]
        [StringLength(100)]
        public string Flm_titre { get; set; }

        [Column("flm_resume", TypeName = "text")]
        public string Flm_resume { get; set; }

        [Column("flm_datesortie", TypeName = "Date")]
        public DateTime Flm_datesortie { get; set; }

        [Column("flm_duree", TypeName = "numeric(3,0)")]
        public decimal Flm_duree { get; set; }

        [Column("flm_genre")]
        [StringLength(30)]
        public string Flm_genre { get; set; }

        [InverseProperty("NotesFilm")]
        public virtual  ICollection<Notation> NotesFilm { get; set; }
    }
}
