﻿using Domain;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace Persistence
{
    public class DataContext : IdentityDbContext<AppUser>
    {
        public DataContext(DbContextOptions options): base(options)
        {

        }

        public DbSet<Channel> Channel { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Siembra de datos de prueba
            modelBuilder.Entity<Channel>().HasData(new Channel
            {
                Id = Guid.NewGuid(),
                Name = "DotnetCore",
                Description = "Canal dedicado a dotnet core"
            },
            new Channel
            {
                Id = Guid.NewGuid(),
                Name = "Angular",
                Description = "Canal dedicado a Angular"
            },
            new Channel
            {
                Id = Guid.NewGuid(),
                Name = "Reactjs",
                Description = "Canal dedicado a Reactjs"
            });
        }

    }
}
