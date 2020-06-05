using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
//primer modelo y primera clase, el modelo solo tendra propiedades, cada modelo es una tabla en la base de datos
namespace EventosTec.Web.Models.Entities
{
    public class Client
    {
            public int Id { get; set; }
            
            [MaxLength(500)]
            [Display(Name = "Dirección")]
            public string Address { get; set; }

            public User User { get; set; }

        public ICollection<Event> Events { get; set; }

    }
    }
