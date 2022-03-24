using System;
using System.Collections.Generic;
using System.Text;

namespace ReBrunchV1.Shared
{
    public class BlogPost
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public string Title { get; set; }
        public string Restaurant { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Diet { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string Description { get; set; }
        public string ReviewerId { get; set; }
        public string AuthorAddress { get; set; }
        public string Image { get; set; }
        public int Rating { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now;
        public bool IsPublished { get; set; } = true;
        public bool IsDeleted { get; set; } = false;
    }
}
