using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphTDL.Api.Repositories;

    public record BooksRepository(Guid id,string Title,Author Author);
