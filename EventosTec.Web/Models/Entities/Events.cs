﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EventosTec.Web.Models.Entities
{
    public class Events
    {
        public int Id { get; set; }
        [Required]
        [Display(Name ="Nombre")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Fecha del Evento")]
        public DateTime EventDate { get; set; }
        [Display(Name = "Descripcion")]
        public string Description { get; set; }
        [Display(Name = "Foto")]
        public Byte[] Picture { get; set; }
        [Display(Name = "Asistentes")]
        public int People { get; set; }
        [Display(Name = "Duracion")]
        public int Duration { get; set; }
        [Required]
        public int CityId { get; set; }
        [ForeignKey("CityId")]
        public City City { get; set; }
    }
}
