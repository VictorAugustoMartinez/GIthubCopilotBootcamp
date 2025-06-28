using Library.ApplicationCore;
using Library.ApplicationCore.Entities;

namespace Library.Infrastructure.Data;

public class JsonBookRepository : IBookRepository
{
    private readonly JsonData _jsonData;

    public JsonBookRepository(JsonData jsonData)
    {
        _jsonData = jsonData;
    }

    public async Task<Book?> GetBook(int id)
    {
        await _jsonData.EnsureDataLoaded();

        foreach (Book book in _jsonData.Books!)
        {
            if (book.Id == id)
            {
                return _jsonData.GetPopulatedBook(book);
            }
        }
        return null;
    }

    public async Task<Book?> GetBookByTitle(string title)
    {
        await _jsonData.EnsureDataLoaded();

        foreach (Book book in _jsonData.Books!)
        {
            if (book.Title.Equals(title, StringComparison.OrdinalIgnoreCase))
            {
                return _jsonData.GetPopulatedBook(book);
            }
        }
        return null;
    }
}

