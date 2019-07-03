using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CodeFirst.Models
{

    //ye class khud banani ha uska bad DbContext se inherit krwao pher constructor banao uska uska bad usko base se relate krwao or wahan pe database ka name dedo jo k bad mein webconfig mein b same use hoga
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext() : base("DBCS")
        {

        }


        //yahan pe jitne b database banain ge uska dbset aiga isi tarhan
        public DbSet<Student> Student { get; set; }
    }
}