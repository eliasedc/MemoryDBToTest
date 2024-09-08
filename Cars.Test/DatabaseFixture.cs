using System;
using DBRepository.Model;
using Microsoft.EntityFrameworkCore;

namespace Cars.Test
{
    public class DatabaseFixture : IDisposable
    {
        public EliasdcDevContext Context { get; private set; }

        public DatabaseFixture()
        {
            DbContextOptions<EliasdcDevContext> options = new DbContextOptionsBuilder<EliasdcDevContext>()
                /*here you can put other definitions. 
                 *Examples:
                 *  Cache=Shared: Allows the in-memory database to be shared across multiple connections.
                 *  Cache=Private: Creates a private in-memory database for each connection (default).
                 *  Foreign Keys=True: Enables foreign key constraint enforcement in SQLite.
                */
                .UseSqlite("DataSource=:memory:")
                .Options;

            Context = new EliasdcDevContext(options);            

            Context.Database.OpenConnection();
            Context.Database.EnsureCreated();
        } 

        public void Dispose()
        {
            Context?.Dispose();
        }
    }
}
