using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Casodistudio.Entities;
using Microsoft.EntityFrameworkCore;

namespace Casodistudio.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) :base(options) //richiamo il costruttore padre
        {

        }

        public DbSet<Book> books {set; get;}
    }

}