using ClassLibrary1.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;



namespace ClassLibrary1
{

    public class AppDatabase : DbContext
    {
        private readonly string schema;

        public AppDatabase(string schema) : base("AppDatabaseConnectionString")
        {
            this.schema = schema;
        }

        public DbSet<Candle> Candles { get; set; }

        protected override void OnModelCreating(DbModelBuilder builder)
        {
            builder.HasDefaultSchema(this.schema);
            base.OnModelCreating(builder);
        }
    }
}
