using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RP2.Models
{
    public class DataContext:DbContext
    {
        public DataContext():base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<RP2.Models.Person> People { get; set; }
    }
}