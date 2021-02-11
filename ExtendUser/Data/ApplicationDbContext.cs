using System;
using System.Collections.Generic;
using System.Text;
using ExtendUser.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ExtendUser.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // created dbset for accessing our custom class under models
        public DbSet<ApplicationUser> ApplicationUsers {get; set;}


    }
}
