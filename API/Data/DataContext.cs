﻿using API.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace API.Data
{
    public class DataContext : DbContext
    { 
        public DataContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<AppUser> Users { get; set; }
        
    }
}
