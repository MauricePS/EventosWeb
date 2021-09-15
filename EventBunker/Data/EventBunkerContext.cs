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

        public DbSet<Event> Event { get; set; }
        public DbSet<EventForm> EventForm { get; set; }
    }
}
