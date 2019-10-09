using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTA.Database
{
    public class DreamTeamContext : DbContext
    {
        public DreamTeamContext():base("name=DreamTeamAppDB")
        {

        }

        //public DbSet<T> ts { get; set; }
    }
}
