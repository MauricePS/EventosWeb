using EventBunker.Data;
using EventBunker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventBunker.Services
{
    public class EventFormService
    {
        private readonly EventBunkerContext _context;

        public EventFormService(EventBunkerContext context)
        {
            _context = context;
        }

        public List<EventForm> FindAll()
        {
            return _context.EventForm.ToList();
        }

        public void Insert(EventForm obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }
    }
}
