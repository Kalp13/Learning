using BookStore.Website.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Website.Contracts
{
    public interface IAuthorRepository : IBaseRepository<AuthorModel>
    {
    }
}
