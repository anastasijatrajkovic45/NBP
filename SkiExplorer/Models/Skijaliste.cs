﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SkiExplorer.Models
{
    public class Skijaliste
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public string Lokacija { get; set; }
        //public List<Staza> Staze { get; set; } 
    }
}
