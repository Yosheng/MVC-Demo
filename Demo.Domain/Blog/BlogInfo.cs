using System;

namespace Demo.Domain
{
    public class BlogInfo
    {
        public Guid Id { get; set; }
        public string Author { get; set; }

        public Blog Blog { get; set; }
    }
}