using Library.ApplicationCore.Entities;

namespace Library.ApplicationCore;

public interface IBookRepository
{
    Task<Book?> GetBook(int id);
    Task<Book?> GetBookByTitle(string title);
}
