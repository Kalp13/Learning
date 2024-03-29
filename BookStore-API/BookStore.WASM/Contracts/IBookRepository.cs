﻿using BookStore.WASM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.WASM.Contracts
{
    public interface IBookRepository : IBaseRepository<BookModel>
    {
    }
}
