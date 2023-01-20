using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphTDL.Api;

    public class Query
    {
        public Task<List<BooksRepository>> GetBooks([Service] Repositories repositories) =>
             repository.GetBooksAsync();
    }
