using Microsoft.EntityFrameworkCore;

namespace Modul2Finish.Models
{
    public class EFDabaseContext : DbContext
    {
        public EFDabaseContext(DbContextOptions<EFDabaseContext> options) : base(options)
        {

        }

        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
    }
}
