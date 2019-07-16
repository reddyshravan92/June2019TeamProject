﻿using System;

namespace Models
{
    public class Blog
    {
        public int Id { get; set; }

        public string Title {get;set;}

        public string Author { get; set; }
        public DateTime? CreatedDt { get; set; }
        public string CreatedBy { get; set; }

        public DateTime? UpdatedDt { get; set; }
        public string UpdatedBy { get; set; }


    }
}
