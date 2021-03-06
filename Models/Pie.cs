﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BroadWay_Cafe.Models
{
    public class Pie
    {
        public int pieId { get; set; }
        public int PieId { get; internal set; }
        public string Name { get; set; }
        public string shortDescription { get; set; }
        public string LongDescription { get; set; }
        public string AlleryInformation { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public string ImageThumbnailUrl { get; set; }
        public bool IsPieOfTheWeek { get; set; }
        public bool InStock { get; set; }
        public int CategotyId { get; set; }
        public Category Category { get; set; }
    }

}
