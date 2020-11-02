﻿using System.ComponentModel.DataAnnotations;

namespace Hospital.DAL.Entities
{
    public class Bio:BaseEntity
    {
        public string Logo { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Facebook { get; set; }
        public string Address { get; set; }
    }
}