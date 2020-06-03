using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace EventosTec.Web.Models.Entities
{
    public class User:IdentityUser
    {
      
        [Display(Name ="Nombre Completo")]
        [MaxLength(150)]
        public string FullName { get; set; }
        [MaxLength (300)]
        [Display(Name = "Descripcion")]
        public string Description { get; set; }
        [Display(Name = "Foto")]    
        public string ImgUrl { get; set; }
        [Display(Name ="Fecha de Nacimiento")]
        public DateTime? BirthDate { get; set; }

    }
}
