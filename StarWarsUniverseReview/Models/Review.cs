using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web;

namespace StarWarsUniverseReview.Models
{
    public class Review
    {
        [Key] 
        public int RevId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime PubDate { get; set; }
        public int Rating { get; set; }

        [ForeignKey ("Category")]
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }
    }
}