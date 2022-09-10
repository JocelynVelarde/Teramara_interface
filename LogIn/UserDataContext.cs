using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogIn
{
    public class UserDataContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //CONECTAR CON SQL LITE ABRIENDO LA BASE DE DATOS 
            optionsBuilder.UseSqlite("Data Source = Data.db");
        }
            //CREAR TABLAS COMO PROPIEDAD
            //SE DEFINE EL TIPO DE SCHEMA QUE TENDRA LA PROPIEDAD PARA MODELAR LOS DATOS (LOS ESPACIOS QUE TENDRA)
            public DbSet<User>? Users { get; set; }
    }

    
}
