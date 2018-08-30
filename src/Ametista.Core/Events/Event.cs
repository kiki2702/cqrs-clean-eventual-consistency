﻿using System;

namespace Ametista.Core.Events
{
    public class Event : IEvent
    {
        public Event()
        {
            Id = Guid.NewGuid();
            Date = DateTime.Now;
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
    }
}