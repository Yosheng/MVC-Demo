using System.Collections.Generic;

namespace Demo.Domain
{
    public class ColumeType
    {
        public int ColumeTypeID { get; set; }
        public string Name { get; set; }

        public ICollection<Colume> Columes { get; set; } 
    }
}