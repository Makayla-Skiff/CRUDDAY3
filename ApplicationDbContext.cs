using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using CRUDDAY3.Data;

namespace CRUDDAY3.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<CRUDDAY3.Data.Departments> Departments { get; set; }
        public DbSet<CRUDDAY3.Data.Employees> Employees { get; set; }

    }
}
