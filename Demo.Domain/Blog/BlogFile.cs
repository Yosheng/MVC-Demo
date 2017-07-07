using System;
using System.Collections.Generic;

namespace Demo.Domain
{
    public class BlogFile
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public ICollection<BlogArticle> Articles { get; set; }
    }
}