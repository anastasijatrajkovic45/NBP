﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;

namespace SkiExplorer.Models
{
    public class Staza
    {
        public int Id { get; set; }
        public required string Naziv { get; set;}
        public float Tezina { get; set;}
        public float Duzina { get; set;}
        public required Skijaliste Skijaliste { get; set; }
        //public List<Recenzija> Recenzije { get; set; }
        //public VremenskaPrognoza VremenskaPrognoza { get; set;}

    }
}
