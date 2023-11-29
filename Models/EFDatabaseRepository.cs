using Microsoft.EntityFrameworkCore;

namespace Modul2Finish.Models
{
    public class EFDatabaseRepository : IDataRepository
    {
        private EFDabaseContext _context;

        public EFDatabaseRepository(EFDabaseContext context)
        {
            _context = context;
        }
        public IEnumerable<Author> GetAuthors()
        {
            return _context.Set<Author>()
                .Include(b => b.Books);
        }

        public IEnumerable<Book> GeBooks()
        {
            return _context.Books;
        }
    }
}
