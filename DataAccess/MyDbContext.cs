using System.Data.Entity;
using TestTeamCityBuild.Model;

namespace TestTeamCityBuild.DataAccess
{
    public class MyDbContext: DbContext
    {
        public DbSet<BinaryFile> BinaryFiles { get; set; }
    }
}