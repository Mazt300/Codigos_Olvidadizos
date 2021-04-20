    public class DbContext : DbContext
    {
        public DbContext() : base("Conexion")
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

