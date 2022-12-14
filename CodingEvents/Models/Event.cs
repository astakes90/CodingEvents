using System;
namespace CodingEvents.Models
{
    public class Event
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public string EventLocation { get; set; }

        public int NumOfAttendees { get; set; }

        public string ContactEmail { get; set; }

        public EventType Type { get; set; }

        public int Id { get; set; }

        public Event()
        {
        }

        public Event(string name, string description, string contactEmail, string eventLocation, int numOfAttendees)
        {
            Name = name;
            Description = description;
            EventLocation = eventLocation;
            NumOfAttendees = numOfAttendees;
            ContactEmail = contactEmail;
        }

        public override string? ToString()
        {
            return Name;
        }

        public override bool Equals(object? obj)
        {
            return obj is Event @event &&
                   Id == @event.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }
    }
}

