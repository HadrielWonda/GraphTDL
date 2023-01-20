using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphTDL.Api;

    public class Mutation
    {
        public async Task<AuthorPayload> AddAuthor(AuthorInput input,[Service] Repositories repositories)
        {
            var author = new Author(Guid.NewGuid(), input.name);
            await repositories.AddAuthor(author);
            return new AuthorPayload(author);
        }

        public async Task<BookPayload> AddBook(BookInput bookInput,[Service] Repositories repositories)
        {
            var author = await repositories.GetAuthor(input.author) ??
                  throw new Exception("Can't find this Author");

            var book = new Book(Guid .NewGuid(),input.title,author);
                 await repositories.AddBook(book);

            return new BookPayload();           
        }
    }



     public record BookPayload(Book? record,string? error = null);
     public record BookInput(string title,Guid author);
     public record AuthorPayload(Author record);
     public record AuthorInput(string name);
