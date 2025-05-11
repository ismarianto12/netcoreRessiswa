using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using RestSekolah.Data;

namespace RestSekolah
{
    public class SekolahDbContextFactory : IDesignTimeDbContextFactory<SekolahDbContext>
    {
        public SekolahDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<SekolahDbContext>();
            var connectionString = "server=localhost;port=3308;database=sekolah;user=root;password=root;AllowPublicKeyRetrieval=True;SslMode=none;";

            optionsBuilder.UseMySql(connectionString, new MySqlServerVersion(new Version(8, 0, 36)));

            return new SekolahDbContext(optionsBuilder.Options);
        }
    }
}
