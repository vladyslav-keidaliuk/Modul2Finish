namespace Modul2Finish.Models
{
    public interface IDataRepository
    {
        public IEnumerable<Author> GetAuthors();
        public IEnumerable<Book> GeBooks();
    }
}
