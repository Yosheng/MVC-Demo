using System;
using System.Collections.Generic;

namespace Demo.Domain
{
    public class Blog
    {
        public int Id { get; set; }
        public Guid OwnerId { get; set; }
        public string Caption { get; set; }
        public DateTime DateCreated { get; set; }

        public BlogInfo Info { get; set; }
        public ICollection<BlogArticle> Articles { get; set; }
    }
}