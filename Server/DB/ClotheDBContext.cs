using Microsoft.EntityFrameworkCore;
using BuyStarOn.Server.Controllers;
using BuyStarOn.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuyStarOn.Server.DB
{
    public class ClotheDBContext : DbContext
    {
        public ClotheDBContext(DbContextOptions<ClotheDBContext> options)
            : base(options)
        {}
        public DbSet<Articles> Clothes {get; set;}
        public override int SaveChanges()
        {
            ChangeTracker.DetectChanges();
            return base.SaveChanges();
        }
    }
}