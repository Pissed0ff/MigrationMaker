﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MigrationMaker
{
    [NotMapped]
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Country Country { get; set; }
        public Company(string name)
        {
            Name = name;
        }
        public Company() { }
        
    }
}
