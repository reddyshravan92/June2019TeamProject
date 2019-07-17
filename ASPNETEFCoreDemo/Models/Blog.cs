using System;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Blog
    {
        public int Id { get; set; }

        [Required]
        public string Title {get;set;}

        [Required]
        public string Author { get; set; }

        public DateTime? CreatedDt { get; set; }
        public string CreatedBy { get; set; }

        public DateTime? UpdatedDt { get; set; }
        public string UpdatedBy { get; set; }


    }
}
