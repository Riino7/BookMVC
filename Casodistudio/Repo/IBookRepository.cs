using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Casodistudio.Data;
using Casodistudio.Controllers;
using Microsoft.AspNetCore.Mvc;
using Casodistudio.Entities;
namespace Casodistudio.Repo
{
    public interface IBookRepository
    {
        public List<Book> GetAll();
    }
}