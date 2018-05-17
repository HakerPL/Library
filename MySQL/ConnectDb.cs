using System.Data.Common;
using MySql.Data.MySqlClient;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using MySQL.Entities;
using MySQL.Migrations;

namespace MySQL
{
    [DbConfigurationType(typeof(MySql.Data.Entity.MySqlEFConfiguration))]
    public class ConnectDb : DbContext
    {
        private static DbConnection _dbConnection = new MySqlConnection("Server=127.0.0.1;Database=library;Uid=root;Pwd=root;");

        public ConnectDb(DbConnection dbConnection) : base(dbConnection, false)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<ConnectDb, Configuration>());
            Database.Initialize(false);
            _dbConnection = dbConnection;
            SetConfigurationEntitu();
        }

        public ConnectDb() : base(_dbConnection, false)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<ConnectDb, Configuration>());
            Database.Initialize(false);
            SetConfigurationEntitu();
        }

        private void SetConfigurationEntitu()
        {
            Configuration.LazyLoadingEnabled = true;
            Configuration.AutoDetectChangesEnabled = false;
        }

        public class MyContextFactory : IDbContextFactory<ConnectDb>
        {
            public ConnectDb Create()
            {
                return new ConnectDb(_dbConnection);
            }
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //modelBuilder.Entity<Client>()
            //    .HasOptional(e => e.ClientStudent)
            //    .WithRequired(e => e.Client);

            //modelBuilder.Entity<Client>()
            //    .HasMany(e => e.ClientsCompany)
            //    .WithOptional(e => e.ClientCompany)
            //    .HasForeignKey(e => e.ClientCompanyId);

            //modelBuilder.Entity<Client>()
            //    .HasMany(e => e.ClientsNew)
            //    .WithOptional(e => e.ClientNew)
            //    .HasForeignKey(e => e.ClientCompanyId);
        }

        public virtual DbSet<Author> Author { get; set; }
        public virtual DbSet<Reader> Reader { get; set; }
        public virtual DbSet<Book> Book { get; set; }
        public virtual DbSet<BookHistory> BookHistory { get; set; }
        public virtual DbSet<ReaderBorrowBook> ReaderBorrowBook { get; set; }
    }
}
