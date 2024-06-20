using Application.Dtos;
using Application.Extensions;
using Application.Services.Interfaces;
using Domain.Entities;
using Infra.Repositories.Interfaces;

namespace Application.Services;

public class BookService : IBookService
{
    private readonly IBookRepository _bookRepository;

    public BookService(IBookRepository bookRepository)
    {
        _bookRepository = bookRepository;
    }

    /// <summary>
    /// Store a new book in the database
    /// </summary>
    /// <param name="newBook"></param>
    /// <returns></returns>
    public async Task<BookEntity> InsertBook(Book newBook)
    {
        return await _bookRepository.InsertBook(newBook);
    }

    /// <summary>
    /// Get a book by its ID
    /// </summary>
    /// <param name="Id"></param>
    /// <returns></returns>
    public async Task<Book> GetById(Guid Id)
    {
        var book = await _bookRepository.GetById(Id);
        var newBook = new Book()
        {
            BookName = book.BookName ?? "",
            BookAuthor = book.BookAuthor ?? "",
            PublicationDate = book.PublicationDate != null ? book.PublicationDate.Value.ToUniversalIso8601() : DateTime.Now.ToUniversalIso8601(),
            BookResume = book.BookResume ?? ""
        };
        return newBook;
    }

    /// <summary>
    /// List all books stored in the database
    /// </summary>
    /// <param name="pageIndex"></param>
    /// <param name="totalPerPage"></param>
    /// <returns></returns>
    public async Task<List<Book>> ListAll(int pageIndex, int totalPerPage = 50)
    {
        var books = await _bookRepository.ListAll();
        var booksListPaginated = books.GetPage(pageIndex, totalPerPage);
        var newBooks = new List<Book>();
        booksListPaginated.ToList().ForEach(book =>
        {
            newBooks.Add(new Book()
            {
                BookName = book.BookName ?? "",
                BookAuthor = book.BookAuthor ?? "",
                PublicationDate = book.PublicationDate != null ? book.PublicationDate.Value.ToUniversalIso8601() : DateTime.Now.ToUniversalIso8601(),
                BookResume = book.BookResume ?? ""
            });
        });
        return newBooks;
    }

    /// <summary>
    /// Delete a specific book by its ID
    /// </summary>
    /// <param name="Id"></param>
    public async Task DeleteBook(Guid Id)
    { 
        await _bookRepository.DeleteBook(Id);
    }

    /// <summary>
    /// Update provided book information by its ID
    /// </summary>
    /// <param name="Id"></param>
    /// <param name="updatedInfo"></param>
    /// <returns></returns>
    public async Task<BookEntity> UpdateBook(Guid Id, Book updatedInfo)
    {
        return await _bookRepository.UpdateBook(Id, updatedInfo);
    }
}