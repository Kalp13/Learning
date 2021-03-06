﻿using BookStore.WebAPI.Contracts;
using BookStore.WebAPI.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace BookStore.WebAPI.Services
{
    public class AuthorRepository : IAuthorRepository
    {
        private readonly ApplicationDbContext applicationDb;

        public AuthorRepository(ApplicationDbContext dbContext)
        {
            this.applicationDb = dbContext;
        }

        public async Task<bool> Create(Author entity)
        {
            await this.applicationDb.Authors.AddAsync(entity);

            return await this.Save();
        }

        public async Task<bool> Delete(Author entity)
        {
            this.applicationDb.Authors.Remove(entity);

            return await this.Save();
        }

        public async Task<bool> DoesExist(int id)
        {
            return await this.applicationDb.Authors.AnyAsync(x => x.Id == id);
        }

        public async Task<IList<Author>> FindAll()
        {
            var authors = await this.applicationDb.Authors.Include(q => q.Books).ToListAsync();

            return authors;
        }

        public async Task<Author> FindById(int id)
        {
            var author = await this.applicationDb.Authors.Include(q => q.Books).FirstAsync(x => x.Id == id);

            return author;
        }

        public async Task<bool> Save()
        {
            var changes = await this.applicationDb.SaveChangesAsync();

            return changes > 0;
        }

        public async Task<bool> Update(Author entity)
        {
            this.applicationDb.Authors.Update(entity);

            return await this.Save();
        }
    }
}
