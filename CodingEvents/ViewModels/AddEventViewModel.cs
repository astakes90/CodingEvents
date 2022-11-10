using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using CodingEvents.Models;
using Microsoft.AspNetCore.Mvc.Rendering;


namespace CodingEvents.ViewModels
{
    public class AddEventViewModel
    {
        [Required(ErrorMessage = "Name is required.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Name must be between 3 and 50 characters.")]
        public string Name { get; set; }

        [Required(ErrorMessage ="Please include a description.")]
        [StringLength(500, ErrorMessage = "Description is too long!")]
        public string Description { get; set; }

        [Required(ErrorMessage ="Location of event is required.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Location must be between 3 and 50 characters.")]
        public string EventLocation { get; set; }

        [Required]
        [Range(0, 100000)]
        public int NumOfAttendees { get; set; }

        [EmailAddress]
        public string? ContactEmail { get; set; }

        public EventType Type { get; set; }

        public List<SelectListItem> EventTypes { get; set; } = new List<SelectListItem>
        {
            new SelectListItem(EventType.Conference.ToString(), ((int)EventType.Conference).ToString()),
            new SelectListItem(EventType.Meetup.ToString(), ((int)EventType.Meetup).ToString()),
            new SelectListItem(EventType.Workshop.ToString(), ((int)EventType.Workshop).ToString()),
            new SelectListItem(EventType.Social.ToString(), ((int)EventType.Social).ToString())
        };
    }
}

