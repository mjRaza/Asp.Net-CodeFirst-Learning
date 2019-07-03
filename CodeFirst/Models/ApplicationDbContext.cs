using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CodeFirst.Models
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext() : base("DBCS")
        {

        }



        public DbSet<Student> Student { get; set; }
    }
}