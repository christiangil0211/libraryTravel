using LibraryTravel.Common.Models;
using Microsoft.EntityFrameworkCore;

namespace LibraryTravel.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<Authors> Authors { get; set; }
    }
}
