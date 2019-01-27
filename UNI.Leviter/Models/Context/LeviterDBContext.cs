using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;


namespace UNI.Leviter.Models.Context
{
    public class LeviterDBContext : DbContext
    {
        public LeviterDBContext() : base("name=db") { }

        public virtual DbSet<Models.Usuario.Usuario> Usuario { get; set; }
    }
}