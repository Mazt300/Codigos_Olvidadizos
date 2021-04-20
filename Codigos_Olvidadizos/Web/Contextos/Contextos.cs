﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Model.Modelo;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace System.Model
{
    public class DbContext : DbContext
    {
        public DbContext() : base("Server=tcp:almacendedatos.database.windows.net,1433;Initial Catalog = BD; Persist Security Info=False;User ID = administradorglobal; Password=Cs_almacendatos; MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout = 300;")
        {
        }

        public DbSet<TB1> TB1{ get; set; }
        public DbSet<TB2> TB2{ get; set; }
        public DbSet<TB2> TB3{ get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }
    }
}
