using BinanceAPI.models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.SQLite;

namespace BinanceAPI.db
{
    public class CryptoAlertDb : DbContext
    {
        public CryptoAlertDb(string databaseFilePath) :
            base(new SQLiteConnection()
            {
                ConnectionString = new SQLiteConnectionStringBuilder() { DataSource = databaseFilePath, ForeignKeys = true }.ConnectionString
            }, true)
        {}

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Product>? Products { get; set; }
    }
}
