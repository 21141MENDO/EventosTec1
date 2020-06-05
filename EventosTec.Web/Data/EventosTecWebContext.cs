using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EventosTec.Web.Models.Entities;

namespace EventosTec.Web.Data
{
    public class EventosTecWebContext : DbContext
    {
        public EventosTecWebContext (DbContextOptions<EventosTecWebContext> options)
            : base(options)
        {
        }

        public DbSet<EventosTec.Web.Models.Entities.Client> Client { get; set; }
    }
}
