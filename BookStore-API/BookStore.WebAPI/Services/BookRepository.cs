﻿using BookStore.WebAPI.Contracts;
using BookStore.WebAPI.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BookStore.WebAPI.Services
{
    public class BookRepository : IBookRepository
    {
        private readonly ApplicationDbContext applicationDb;

        public BookRepository(ApplicationDbContext dbContext)
        {
            this.applicationDb = dbContext;
        }

        public async Task<bool> Create(Book entity)
        {
            await this.applicationDb.Books.AddAsync(entity);

            return await this.Save();
        }

        public async Task<bool> Delete(Book entity)
        {
            this.applicationDb.Books.Remove(entity);

            return await this.Save();
        }

        public async Task<bool> DoesExist(int id)
        {
            return await this.applicationDb.Books.AnyAsync(x => x.Id == id);
        }

        public async Task<IList<Book>> FindAll()
        {
            var books = await this.applicationDb.Books.Include(x => x.Author).ToListAsync();

            return books;
        }

        public async Task<Book> FindById(int id)
        {
            var book = await this.applicationDb.Books.Include(x => x.Author).FirstAsync(y => y.Id == id);

            return book;
        }

        public async Task<bool> Save()
        {
            var changes = await this.applicationDb.SaveChangesAsync();

            return changes > 0;
        }

        public async Task<bool> Update(Book entity)
        {
            this.applicationDb.Books.Update(entity);

            return await this.Save();
        }
    }
}
