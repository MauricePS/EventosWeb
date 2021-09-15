using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EventBunker.Models;

namespace EventBunker.Data
{
    public class EventBunkerContext : DbContext
    {
        public EventBunkerContext (DbContextOptions<EventBunkerContext> options)
            : base(options)
        {
        }

        public DbSet<EventBunker.Models.Event> Event { get; set; }
    }
}
