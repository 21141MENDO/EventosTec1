using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventosTec.Web.Models.Entities
{
    public class Manager
    {
        public int id { get; set; }

        public User User { get; set; }
    }
}
