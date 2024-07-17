using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Casodistudio.Entities;
using Casodistudio.Repo;

namespace Casodistudio.Service
{
    public class BookService : IBookService
    {
      private readonly IBookRepository bookRepository;

      public BookService(IBookRepository bookRepository)
      {
        this.bookRepository = bookRepository;
      }
        public List<Book> GetAll()
        {
            List<Book> books = bookRepository.GetAll();
            return books;
        }
    }
}