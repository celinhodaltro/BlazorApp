using Microsoft.EntityFrameworkCore;
using Lib.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Configuration;

namespace Lib.Data
{
    public class AplicationDbContext : DbContext
    {

        public AplicationDbContext():base()
        {

        }


        //            options = options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"))

        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            string CS = "Server = (localdb)\\MSSQLLocalDB; Database = Blazor_Base_ProjectDb; Trusted_Connection = True; MultipleActiveResultSets = true";

            dbContextOptionsBuilder.UseSqlServer(CS);

            base.OnConfiguring(dbContextOptionsBuilder);

        }
        public DbSet<Entities.Tarefa> Tarefas { get; set; }



    }
}
