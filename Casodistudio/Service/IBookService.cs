using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Casodistudio.Entities;
namespace Casodistudio.Service
{
    public interface IBookService
    {
        public List<Book> GetAll();
    }
}