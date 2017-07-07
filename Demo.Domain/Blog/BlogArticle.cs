using System;
using System.Collections.Generic;

namespace Demo.Domain
{
    public class BlogArticle
    {
        public Guid Id { get; set; }
        public int BlogId { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }

        public Blog Blog { get; set; }
        public ICollection<BlogFile> Files { get; set; }
    }
}