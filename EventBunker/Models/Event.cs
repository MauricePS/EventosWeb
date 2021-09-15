using System;
using System.Collections.Generic;

namespace EventBunker.Models
{
    public class Event
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<EventForm> EventFroms { get; set; } = new List<EventForm>();

        public Event()
        {
        }

        public Event(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
