using EventosTec.Web.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventosTec.Web.Models
{
    public class DataDbContext:DbContext
    {// se crea un constructor con el mismo nombre de la clase,  es para la conexion con la base de datos
        public DataDbContext(DbContextOptions<DataDbContext> options):base(options)
        {

        }
        //get servira para hacer conexion y optener la conexion
        public DbSet<Client> clients { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Events> Events { get; set; }

    }
}
