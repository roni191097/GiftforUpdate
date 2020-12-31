using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GiftforUpdate.Models;

namespace GiftforUpdate.Data
{
    public class GiftforUpdateContext : DbContext
    {
        public GiftforUpdateContext (DbContextOptions<GiftforUpdateContext> options)
            : base(options)
        {
        }

        public DbSet<GiftforUpdate.Models.Order> Order { get; set; }

        public DbSet<GiftforUpdate.Models.User> User { get; set; }
    }
}
