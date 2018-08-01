using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ScottAllenDemo.Models
{
    public class RestaurantReview
    {
        public int Id { get; set; }
        public string  ReviewerName { get; set; }

        //[Range(1,10)]
        //[StringLength(1024)]
        public int Rating { get; set; }
    }
}