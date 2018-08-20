namespace MySiteWCF
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class Context : DbContext
    {
        // Your context has been configured to use a 'Model' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'MySiteWCF.Model' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'Model' 
        // connection string in the application configuration file.
        public Context()
            : base("name=Context")
        {
           
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //or configure all DateTime Preperties globally(EF 6 and Above)
            modelBuilder.Properties<DateTime>()
                .Configure(c => c.HasColumnType("datetime2"));
        }

        public virtual DbSet<Info> _Info { get; set; }
        public virtual DbSet<UserSign> Users { get; set; }
    }
    
}