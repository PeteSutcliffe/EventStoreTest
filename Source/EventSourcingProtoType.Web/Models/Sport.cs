﻿using System;

namespace EventSourcingProtoType.Web.Models
{
    public class Sport
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; } 
    }
}