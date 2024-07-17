using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Casodistudio.Data;
using Casodistudio.Entities;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
namespace Casodistudio.Repo
{
    public class BookRepository : IBookRepository
    {

        private readonly DataContext dbcontex;

        public BookRepository(DataContext dbcontex)
        {
            this.dbcontex = dbcontex;
        }
        public List<Book> GetAll()
        {
            List<Book> books = dbcontex.books.ToList();
            return books;
        }
    }
}