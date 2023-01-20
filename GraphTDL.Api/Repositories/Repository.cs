using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphTDL.Api.Repositories;

    public class Repository
    {
       List<Author> Authors = new List<Author>(); 
       List<BooksRepository> Books = new List<BooksRepository>();

       public Task<List<BooksRepository>> GetBooksAsync()
       {
         return Task.FromResult(Book);
       }


       public Task<Author?> GetAuthor(Guid authorId );





    }
