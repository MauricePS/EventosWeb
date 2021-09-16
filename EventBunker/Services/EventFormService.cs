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

        public EventForm FindById(int id)
        {
            return _context.EventForm.FirstOrDefault(obj => obj.Id == id);
        }

        public void Remove(int id)
        {
            var obj = _context.EventForm.Find(id);
            _context.EventForm.Remove(obj);
            _context.SaveChanges();
        }
    }
}
