using EventBunker.Data;
using EventBunker.Models;
using EventBunker.Services.Exceptions;
using Microsoft.EntityFrameworkCore;
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

        public void Update(EventForm obj)
        {
            if (!_context.EventForm.Any(x => x.Id == obj.Id))
            {
                throw new NotFoundException("Id não encontrada");
            }
            try
            {
                _context.Update(obj);
                _context.SaveChanges();
            }
            catch(DbUpdateConcurrencyException e)
            {
                throw new DbConcurrencyException(e.Message);
            }
        }

    }
}
