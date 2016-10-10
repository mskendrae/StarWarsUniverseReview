using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StarWarsUniverseReview.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Review> Review { get; set; }
    }
}