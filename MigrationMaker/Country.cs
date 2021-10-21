﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MigrationMaker
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Country(string name)
        {
            Name = name;
        }
        public Country() { }
    }
}
