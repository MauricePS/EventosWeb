using System;

namespace EventBunker.Models
{
    public class EventForm
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public string Organizer{ get; set; }
                
        public Event Event { get; set; }

        public EventForm()
        {
        }

        public EventForm(int id, string name, DateTime startDate, DateTime endDate, string organizer)
        {
            Id = id;
            Name = name;
            StartDate = startDate;
            EndDate = endDate;
            Organizer = organizer;
        }
    }
}
