using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ScottAllenDemo.Models
{
    public class RestaurantReview
    {
        public int Id { get; set; }
<<<<<<< HEAD
        public int Rating { get; set; }
        public string Body { get; set; }
        public int RestaurantId { get; set; }
=======
        public string  Name { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public int Rating { get; set; }
>>>>>>> 3054eea5984e26d57b9e46a36e6ac1181a5a8c1c
    }
}