﻿using exercise.wwwapi.Model;
using Microsoft.EntityFrameworkCore;


namespace exercise.wwwapi.Data
{
    public class DataContext : DbContext
    {
        
            public DataContext(DbContextOptions<DataContext> options) : base(options)
            {

            }
            public DbSet<Product> products { get; set; }
            //public DbSet<Motorbike> Motorbikes { get; set; }
        
    }
}
