﻿using Microsoft.EntityFrameworkCore;
using Portfolio.Models;

namespace Portfolio.Data
{

    public class DataDbContext:DbContext
    {
        public DataDbContext(DbContextOptions<DataDbContext> options) : base(options)
        {

        }

        public DbSet<Home>home { get; set; }
        public DbSet<Services>Services { get; set; }

        public DbSet<Blogs> Blogs { get; set; }
    }
}
